namespace stm_gui
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
            this.SerialControl = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.PortNo = new System.Windows.Forms.Label();
            this.cBoxPortNo = new System.Windows.Forms.ComboBox();
            this.Databit = new System.Windows.Forms.Label();
            this.cBoxData = new System.Windows.Forms.ComboBox();
            this.Baud = new System.Windows.Forms.Label();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.Label();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.Stop = new System.Windows.Forms.Label();
            this.cBoxStopbit = new System.Windows.Forms.ComboBox();
            this.SerialSelect = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SerialControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SerialSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialControl
            // 
            this.SerialControl.Controls.Add(this.progressBar1);
            this.SerialControl.Controls.Add(this.Disconnect);
            this.SerialControl.Controls.Add(this.Connect);
            this.SerialControl.Location = new System.Drawing.Point(12, 181);
            this.SerialControl.Name = "SerialControl";
            this.SerialControl.Size = new System.Drawing.Size(203, 77);
            this.SerialControl.TabIndex = 1;
            this.SerialControl.TabStop = false;
            this.SerialControl.Text = "Serial Control";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(116, 51);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(10, 51);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(8, 35);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(75, 23);
            this.manual.TabIndex = 2;
            this.manual.Text = "Manual";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(114, 35);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(75, 23);
            this.auto.TabIndex = 3;
            this.auto.Text = "Auto";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.auto);
            this.groupBox1.Controls.Add(this.manual);
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode selection";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(221, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(598, 468);
            this.zedGraphControl1.TabIndex = 5;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // PortNo
            // 
            this.PortNo.AutoSize = true;
            this.PortNo.Location = new System.Drawing.Point(7, 22);
            this.PortNo.Name = "PortNo";
            this.PortNo.Size = new System.Drawing.Size(51, 15);
            this.PortNo.TabIndex = 0;
            this.PortNo.Text = "Port No.";
            // 
            // cBoxPortNo
            // 
            this.cBoxPortNo.FormattingEnabled = true;
            this.cBoxPortNo.Location = new System.Drawing.Point(70, 22);
            this.cBoxPortNo.Name = "cBoxPortNo";
            this.cBoxPortNo.Size = new System.Drawing.Size(121, 21);
            this.cBoxPortNo.TabIndex = 1;
            // 
            // Databit
            // 
            this.Databit.AutoSize = true;
            this.Databit.Location = new System.Drawing.Point(7, 78);
            this.Databit.Name = "Databit";
            this.Databit.Size = new System.Drawing.Size(50, 15);
            this.Databit.TabIndex = 2;
            this.Databit.Text = "Data Bit";
            // 
            // cBoxData
            // 
            this.cBoxData.FormattingEnabled = true;
            this.cBoxData.Location = new System.Drawing.Point(70, 76);
            this.cBoxData.Name = "cBoxData";
            this.cBoxData.Size = new System.Drawing.Size(121, 21);
            this.cBoxData.TabIndex = 3;
            // 
            // Baud
            // 
            this.Baud.AutoSize = true;
            this.Baud.Location = new System.Drawing.Point(6, 49);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(65, 15);
            this.Baud.TabIndex = 4;
            this.Baud.Text = "Baud Rate";
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Location = new System.Drawing.Point(70, 49);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudrate.TabIndex = 5;
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Location = new System.Drawing.Point(7, 105);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(37, 15);
            this.Parity.TabIndex = 6;
            this.Parity.Text = "Parity";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Location = new System.Drawing.Point(70, 103);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(121, 21);
            this.cBoxParity.TabIndex = 7;
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.Location = new System.Drawing.Point(7, 132);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(49, 15);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Stop Bit";
            // 
            // cBoxStopbit
            // 
            this.cBoxStopbit.FormattingEnabled = true;
            this.cBoxStopbit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopbit.Location = new System.Drawing.Point(70, 130);
            this.cBoxStopbit.Name = "cBoxStopbit";
            this.cBoxStopbit.Size = new System.Drawing.Size(121, 21);
            this.cBoxStopbit.TabIndex = 9;
            // 
            // SerialSelect
            // 
            this.SerialSelect.AccessibleName = "";
            this.SerialSelect.Controls.Add(this.cBoxStopbit);
            this.SerialSelect.Controls.Add(this.Stop);
            this.SerialSelect.Controls.Add(this.cBoxParity);
            this.SerialSelect.Controls.Add(this.Parity);
            this.SerialSelect.Controls.Add(this.cBoxBaudrate);
            this.SerialSelect.Controls.Add(this.Baud);
            this.SerialSelect.Controls.Add(this.cBoxData);
            this.SerialSelect.Controls.Add(this.Databit);
            this.SerialSelect.Controls.Add(this.cBoxPortNo);
            this.SerialSelect.Controls.Add(this.PortNo);
            this.SerialSelect.Location = new System.Drawing.Point(12, 12);
            this.SerialSelect.Name = "SerialSelect";
            this.SerialSelect.Size = new System.Drawing.Size(203, 163);
            this.SerialSelect.TabIndex = 0;
            this.SerialSelect.TabStop = false;
            this.SerialSelect.Text = "Serial Parameters";
            this.SerialSelect.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Received data";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 368);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 112);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 492);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SerialControl);
            this.Controls.Add(this.SerialSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.SerialSelect.ResumeLayout(false);
            this.SerialSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox SerialControl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button manual;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label PortNo;
        private System.Windows.Forms.ComboBox cBoxPortNo;
        private System.Windows.Forms.Label Databit;
        private System.Windows.Forms.ComboBox cBoxData;
        private System.Windows.Forms.Label Baud;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.Label Parity;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.Label Stop;
        private System.Windows.Forms.ComboBox cBoxStopbit;
        private System.Windows.Forms.GroupBox SerialSelect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

