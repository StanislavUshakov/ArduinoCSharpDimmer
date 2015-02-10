namespace Arduino_Dimmer
{
    partial class MainForm
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
            this.cbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.lbBrightness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAvailablePorts
            // 
            this.cbAvailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailablePorts.FormattingEnabled = true;
            this.cbAvailablePorts.Location = new System.Drawing.Point(12, 12);
            this.cbAvailablePorts.Name = "cbAvailablePorts";
            this.cbAvailablePorts.Size = new System.Drawing.Size(121, 21);
            this.cbAvailablePorts.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(153, 10);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(119, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(109, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: Disconnected";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Enabled = false;
            this.tbBrightness.LargeChange = 20;
            this.tbBrightness.Location = new System.Drawing.Point(15, 90);
            this.tbBrightness.Maximum = 255;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(397, 45);
            this.tbBrightness.SmallChange = 2;
            this.tbBrightness.TabIndex = 3;
            this.tbBrightness.ValueChanged += new System.EventHandler(this.tbBrightness_ValueChanged);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(293, 10);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(119, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(185, 138);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(185, 13);
            this.lbLink.TabIndex = 5;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "http://arduino.cc/en/Tutorial/Dimmer";
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(9, 138);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(170, 13);
            this.lbHelp.TabIndex = 6;
            this.lbHelp.Text = "Code for Arduino can be found on:";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(290, 213);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(138, 13);
            this.lbCopyright.TabIndex = 7;
            this.lbCopyright.Text = "(c) Stanislav Ushakov 2015";
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBrightness.Location = new System.Drawing.Point(12, 74);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(68, 15);
            this.lbBrightness.TabIndex = 8;
            this.lbBrightness.Text = "Brightness:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 235);
            this.Controls.Add(this.lbBrightness);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbAvailablePorts);
            this.Name = "MainForm";
            this.Text = "Arduino Dimmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAvailablePorts;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Label lbBrightness;

    }
}

