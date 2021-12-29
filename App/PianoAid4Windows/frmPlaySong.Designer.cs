
namespace PianoAid4Windows
{
    partial class frmPlaySong
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.chkCommunication = new System.Windows.Forms.CheckBox();
            this.cmbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(909, 54);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(321, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "01030610";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(909, 80);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(146, 27);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "Send Command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(909, 409);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 9;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(909, 113);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceived.Size = new System.Drawing.Size(320, 290);
            this.txtReceived.TabIndex = 10;
            // 
            // chkCommunication
            // 
            this.chkCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCommunication.AutoSize = true;
            this.chkCommunication.ForeColor = System.Drawing.Color.Black;
            this.chkCommunication.Location = new System.Drawing.Point(1031, 415);
            this.chkCommunication.Name = "chkCommunication";
            this.chkCommunication.Size = new System.Drawing.Size(170, 17);
            this.chkCommunication.TabIndex = 11;
            this.chkCommunication.Text = "Check if communication works";
            this.chkCommunication.UseVisualStyleBackColor = true;
            this.chkCommunication.CheckedChanged += new System.EventHandler(this.chkCommunication_CheckedChanged);
            // 
            // cmbAvailablePorts
            // 
            this.cmbAvailablePorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbAvailablePorts.FormattingEnabled = true;
            this.cmbAvailablePorts.Location = new System.Drawing.Point(12, 581);
            this.cmbAvailablePorts.Name = "cmbAvailablePorts";
            this.cmbAvailablePorts.Size = new System.Drawing.Size(121, 21);
            this.cmbAvailablePorts.TabIndex = 14;
            this.cmbAvailablePorts.SelectedIndexChanged += new System.EventHandler(this.cmbAvailablePorts_SelectedIndexChanged);
            // 
            // frmPlaySong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 614);
            this.Controls.Add(this.cmbAvailablePorts);
            this.Controls.Add(this.chkCommunication);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.txtCommand);
            this.Name = "frmPlaySong";
            this.Text = "frmPlaySong";
            this.Load += new System.EventHandler(this.frmPlaySong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.CheckBox chkCommunication;
        private System.Windows.Forms.ComboBox cmbAvailablePorts;
    }
}