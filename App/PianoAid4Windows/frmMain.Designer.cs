
namespace PianoAid4Windows
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chkCommunication = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblSelectedCommPort = new System.Windows.Forms.Label();
            this.btnSongName = new System.Windows.Forms.Button();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCommunication
            // 
            this.chkCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCommunication.AutoSize = true;
            this.chkCommunication.ForeColor = System.Drawing.Color.Black;
            this.chkCommunication.Location = new System.Drawing.Point(888, 614);
            this.chkCommunication.Name = "chkCommunication";
            this.chkCommunication.Size = new System.Drawing.Size(170, 17);
            this.chkCommunication.TabIndex = 0;
            this.chkCommunication.Text = "Check if communication works";
            this.chkCommunication.UseVisualStyleBackColor = true;
            this.chkCommunication.CheckedChanged += new System.EventHandler(this.chkCommunication_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(1033, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(25, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblSelectedCommPort
            // 
            this.lblSelectedCommPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedCommPort.AutoSize = true;
            this.lblSelectedCommPort.ForeColor = System.Drawing.Color.Black;
            this.lblSelectedCommPort.Location = new System.Drawing.Point(977, 17);
            this.lblSelectedCommPort.Name = "lblSelectedCommPort";
            this.lblSelectedCommPort.Size = new System.Drawing.Size(50, 13);
            this.lblSelectedCommPort.TabIndex = 2;
            this.lblSelectedCommPort.Text = "CommXX";
            this.lblSelectedCommPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSongName
            // 
            this.btnSongName.ForeColor = System.Drawing.Color.Black;
            this.btnSongName.Location = new System.Drawing.Point(45, 248);
            this.btnSongName.Name = "btnSongName";
            this.btnSongName.Size = new System.Drawing.Size(180, 25);
            this.btnSongName.TabIndex = 4;
            this.btnSongName.Text = "I Wanted To Leave";
            this.btnSongName.UseVisualStyleBackColor = true;
            this.btnSongName.Click += new System.EventHandler(this.btnSongName_Click);
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(335, 103);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(127, 22);
            this.btnSendCommand.TabIndex = 5;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(335, 68);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(321, 20);
            this.txtCommand.TabIndex = 6;
            this.txtCommand.Text = "01030610";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(335, 150);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(320, 290);
            this.txtReceived.TabIndex = 7;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(335, 446);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 8;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1070, 643);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.btnSongName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelectedCommPort);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.chkCommunication);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "Piano Aid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCommunication;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblSelectedCommPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSongName;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Button btnClearLog;
    }
}

