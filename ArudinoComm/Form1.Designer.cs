namespace ArudinoComm
{
    partial class autoScrollCB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connectBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.scanBT = new System.Windows.Forms.Button();
            this.disconnectBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.comportCB = new System.Windows.Forms.ComboBox();
            this.incomingTB = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.autoCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBT
            // 
            this.connectBT.Location = new System.Drawing.Point(33, 428);
            this.connectBT.Name = "connectBT";
            this.connectBT.Size = new System.Drawing.Size(131, 52);
            this.connectBT.TabIndex = 0;
            this.connectBT.Text = "CONNECT";
            this.connectBT.UseVisualStyleBackColor = true;
            this.connectBT.Click += new System.EventHandler(this.connectBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(335, 367);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(131, 52);
            this.clearBT.TabIndex = 1;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // scanBT
            // 
            this.scanBT.Location = new System.Drawing.Point(180, 367);
            this.scanBT.Name = "scanBT";
            this.scanBT.Size = new System.Drawing.Size(131, 52);
            this.scanBT.TabIndex = 2;
            this.scanBT.Text = "SCAN";
            this.scanBT.UseVisualStyleBackColor = true;
            this.scanBT.Click += new System.EventHandler(this.scanBT_Click);
            // 
            // disconnectBT
            // 
            this.disconnectBT.Enabled = false;
            this.disconnectBT.Location = new System.Drawing.Point(180, 428);
            this.disconnectBT.Name = "disconnectBT";
            this.disconnectBT.Size = new System.Drawing.Size(131, 52);
            this.disconnectBT.TabIndex = 3;
            this.disconnectBT.Text = "DISCONNECT";
            this.disconnectBT.UseVisualStyleBackColor = true;
            this.disconnectBT.Click += new System.EventHandler(this.disconnectBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(335, 428);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(131, 52);
            this.saveBT.TabIndex = 4;
            this.saveBT.Text = "SAVE";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // baudrateCB
            // 
            this.baudrateCB.FormattingEnabled = true;
            this.baudrateCB.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.baudrateCB.Location = new System.Drawing.Point(98, 398);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(66, 21);
            this.baudrateCB.TabIndex = 5;
            // 
            // comportCB
            // 
            this.comportCB.FormattingEnabled = true;
            this.comportCB.Location = new System.Drawing.Point(98, 371);
            this.comportCB.Name = "comportCB";
            this.comportCB.Size = new System.Drawing.Size(66, 21);
            this.comportCB.TabIndex = 6;
            // 
            // incomingTB
            // 
            this.incomingTB.Location = new System.Drawing.Point(18, 36);
            this.incomingTB.Name = "incomingTB";
            this.incomingTB.Size = new System.Drawing.Size(456, 289);
            this.incomingTB.TabIndex = 7;
            this.incomingTB.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Incoming Serial Data";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(540, 36);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(491, 444);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // autoCB
            // 
            this.autoCB.AutoSize = true;
            this.autoCB.Location = new System.Drawing.Point(394, 16);
            this.autoCB.Name = "autoCB";
            this.autoCB.Size = new System.Drawing.Size(72, 17);
            this.autoCB.TabIndex = 12;
            this.autoCB.Text = "Autoscroll";
            this.autoCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "COM Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Baud Rate";
            // 
            // autoScrollCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoCB);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomingTB);
            this.Controls.Add(this.comportCB);
            this.Controls.Add(this.baudrateCB);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.disconnectBT);
            this.Controls.Add(this.scanBT);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.connectBT);
            this.Name = "autoScrollCB";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button scanBT;
        private System.Windows.Forms.Button disconnectBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.ComboBox baudrateCB;
        private System.Windows.Forms.ComboBox comportCB;
        private System.Windows.Forms.RichTextBox incomingTB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox autoCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

