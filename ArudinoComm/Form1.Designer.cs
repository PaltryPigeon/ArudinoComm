namespace ArudinoComm
{
    partial class Form1
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
            this.connectBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.scanBT = new System.Windows.Forms.Button();
            this.disconnectBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.comportCB = new System.Windows.Forms.ComboBox();
            this.incomingTB = new System.Windows.Forms.RichTextBox();
            this.outgoingTB = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectBT
            // 
            this.connectBT.Location = new System.Drawing.Point(18, 367);
            this.connectBT.Name = "connectBT";
            this.connectBT.Size = new System.Drawing.Size(131, 52);
            this.connectBT.TabIndex = 0;
            this.connectBT.Text = "CONNECT";
            this.connectBT.UseVisualStyleBackColor = true;
            this.connectBT.Click += new System.EventHandler(this.connectBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(343, 367);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(131, 52);
            this.clearBT.TabIndex = 1;
            this.clearBT.Text = "CLEAR";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // scanBT
            // 
            this.scanBT.Location = new System.Drawing.Point(180, 428);
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
            this.disconnectBT.Location = new System.Drawing.Point(18, 428);
            this.disconnectBT.Name = "disconnectBT";
            this.disconnectBT.Size = new System.Drawing.Size(131, 52);
            this.disconnectBT.TabIndex = 3;
            this.disconnectBT.Text = "DISCONNECT";
            this.disconnectBT.UseVisualStyleBackColor = true;
            this.disconnectBT.Click += new System.EventHandler(this.disconnectBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(343, 428);
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
            this.baudrateCB.Location = new System.Drawing.Point(180, 398);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(131, 21);
            this.baudrateCB.TabIndex = 5;
            // 
            // comportCB
            // 
            this.comportCB.FormattingEnabled = true;
            this.comportCB.Location = new System.Drawing.Point(180, 367);
            this.comportCB.Name = "comportCB";
            this.comportCB.Size = new System.Drawing.Size(131, 21);
            this.comportCB.TabIndex = 6;
            // 
            // incomingTB
            // 
            this.incomingTB.Location = new System.Drawing.Point(18, 36);
            this.incomingTB.Name = "incomingTB";
            this.incomingTB.Size = new System.Drawing.Size(456, 246);
            this.incomingTB.TabIndex = 7;
            this.incomingTB.Text = "";
            // 
            // outgoingTB
            // 
            this.outgoingTB.Location = new System.Drawing.Point(18, 306);
            this.outgoingTB.Name = "outgoingTB";
            this.outgoingTB.Size = new System.Drawing.Size(456, 21);
            this.outgoingTB.TabIndex = 8;
            this.outgoingTB.Text = "";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outgoingTB);
            this.Controls.Add(this.incomingTB);
            this.Controls.Add(this.comportCB);
            this.Controls.Add(this.baudrateCB);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.disconnectBT);
            this.Controls.Add(this.scanBT);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.connectBT);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.RichTextBox outgoingTB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
    }
}

