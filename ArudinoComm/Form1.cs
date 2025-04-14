using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArudinoComm
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
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
            string dump = serialPort1.ReadLine();
            incomingTB.Text = incomingTB.Text + dump;
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
    }
}
