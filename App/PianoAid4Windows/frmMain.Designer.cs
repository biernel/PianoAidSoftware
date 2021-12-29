
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
            this.btnSongName = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMidiFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;

            // 
            // btnMidiFile
            // 
            this.btnMidiFile.Location = new System.Drawing.Point(476, 103);
            this.btnMidiFile.Name = "btnMidiFile";
            this.btnMidiFile.Size = new System.Drawing.Size(132, 21);
            this.btnMidiFile.TabIndex = 9;
            this.btnMidiFile.Text = "midi file convertor";
            this.btnMidiFile.UseVisualStyleBackColor = true;
            this.btnMidiFile.Click += new System.EventHandler(this.btnMidiFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1070, 496);
            this.Controls.Add(this.btnMidiFile);
            this.Controls.Add(this.btnSongName);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "Piano Aid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSongName;
        private System.Windows.Forms.Button btnMidiFile;
    }
}

