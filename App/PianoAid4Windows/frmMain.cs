using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
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
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management;

namespace PianoAid4Windows
{
    public partial class frmMain : frmStyling
    {
        public frmMain()
        {
            InitializeComponent();

            var songLoader = new SongLoader();
            var songs = songLoader.LoadSongs(@"C:\Data\eline\school\2021-2022\GIP\PianoAid Software\PianoAidSoftware\App\Songs");


            var songCounter = 0;
            var columnCounter = 0;

            tblSongList.RowCount -= 1;
            tblSongList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblSongList.RowStyles.Clear();
            tblSongList.ColumnStyles.Clear();
            tblSongList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tblSongList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tblSongList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));

            
            foreach (var songKeyValuePair in songs)
            {
                columnCounter = songCounter % 3;
                
                if (songCounter % 3 == 0) { 
                    tblSongList.RowCount += 1;
                    tblSongList.RowStyles.Add(new RowStyle(SizeType.Absolute, 350f));
                }

                var panel = new Panel();
                panel.Size = new Size(250, 350);
                var pictureBox = new PictureBox();
                pictureBox.Size = new Size(240, 250);
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Image = Image.FromFile(songKeyValuePair.Value.PathToImage);
                pictureBox.Anchor = AnchorStyles.None;
                panel.Controls.Add(pictureBox);

                var button = new Button();
                button.Text = songKeyValuePair.Key;
                button.Tag = songKeyValuePair.Value.PathToMidiFile;
                button.Click += Button_Click;
                button.Anchor = AnchorStyles.None;
                button.Size = new Size(226, 40);
                button.Top = 230;
                panel.Controls.Add(button);

                panel.Anchor = AnchorStyles.None;
                tblSongList.Controls.Add(panel, columnCounter, tblSongList.RowCount - 1);

                songCounter++;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            tblSongList.MaximumSize = this.Size;
            tblSongList.AutoScroll = true;
            tblSongList.AutoSize = true;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var frmPlaySong = new frmPlaySong((string) button.Tag);
            frmPlaySong.ShowDialog();
        }

        private void tblSongList_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Gray), e.CellBounds);
        }


    }
}
