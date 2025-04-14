using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArudinoComm
{
    public partial class autoScrollCB : Form
    {
        public autoScrollCB()
        {
            InitializeComponent();
        }

        private void scanBT_Click(object sender, EventArgs e)
        {
            comportCB.Text = "";
            comportCB.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            comportCB.Items.AddRange(ports);
        }

        private void connectBT_Click(object sender, EventArgs e)
        {
            if(ConnectPort() == true)
            {
                connectBT.Enabled = false;
                disconnectBT.Enabled = true;
                comportCB.Enabled = false;
                baudrateCB.Enabled = false;
            }
        }

        public bool ConnectPort()
        {
            try
            {
                if (comportCB.Text != "" || baudrateCB.Text != "")
                {
                    serialPort1.PortName = comportCB.Text;
                    serialPort1.BaudRate = Int32.Parse(baudrateCB.Text);
                    serialPort1.Open();
                    InitializeChart();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Temperature";

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "TempSeries",
                Color = System.Drawing.Color.Blue,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            };

            chart1.Series.Add(series);
        }


        private void disconnectBT_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            connectBT.Enabled = true;
            disconnectBT.Enabled = false;
            comportCB.Enabled = true;
            baudrateCB.Enabled = true;
        }



        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(serialPort1_DataRecieved));
        }

        private void serialPort1_DataRecieved(object sender, EventArgs e)
        {
            try
            {
                string dump = serialPort1.ReadLine();

                incomingTB.AppendText(dump.Trim() + Environment.NewLine);

                if (autoCB.Checked)
                {
                    incomingTB.SelectionStart = incomingTB.Text.Length;
                    incomingTB.ScrollToCaret();
                }

                // Parse and plot if CSV formatted
                string[] parts = dump.Split(',');
                if (parts.Length == 2 &&
                    double.TryParse(parts[0], out double xVal) &&
                    double.TryParse(parts[1], out double yVal))
                {
                    if (chart1.InvokeRequired)
                    {
                        chart1.Invoke(new Action(() =>
                        {
                            chart1.Series["TempSeries"].Points.AddXY(xVal, yVal);
                        }));
                    }
                    else
                    {
                        chart1.Series["TempSeries"].Points.AddXY(xVal, yVal);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Arduino disconnected.\n" + ex.Message, "Connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Serial port was unexpectedly closed.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            incomingTB.Text = "";
        }

        private void saveBT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Serial Data";
            saveFileDialog.FileName = "SerialData.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save the contents of the RichTextBox to a file
                    System.IO.File.WriteAllText(saveFileDialog.FileName, incomingTB.Text);
                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
        private void PlotDataFromTextBox()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Temperature";

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "TempSeries",
                Color = System.Drawing.Color.Blue,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            };

            chart1.Series.Add(series);

            string[] lines = incomingTB.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines.Skip(1)) // Skip header line
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 &&
                    double.TryParse(parts[0], out double xVal) &&
                    double.TryParse(parts[1], out double yVal))
                {
                    series.Points.AddXY(xVal, yVal);
                }
            }
        }
    }
}
