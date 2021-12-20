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

namespace PianoAid4Windows
{
    public partial class frmMain : frmStyling
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private frmSettings frmSettings = new frmSettings();

        static SerialPort _serialPort;

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblSelectedCommPort.Text = "";

        }      

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort != null)
                _serialPort.Close();
        }

        private void chkCommunication_CheckedChanged(object sender, EventArgs e)
        {
            if (_serialPort == null)
                return;

            if (chkCommunication.Checked)
                _serialPort.Write("1");
            else
                _serialPort.Write("0");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if(_serialPort != null)
                _serialPort.Close();
            frmSettings.ShowDialog();
            if (!string.IsNullOrEmpty(frmSettings.SelectedPortName))
            {
                lblSelectedCommPort.Text = frmSettings.SelectedPortName;
                _serialPort = new SerialPort(frmSettings.SelectedPortName, 9600);
                _serialPort.Open();
            }
        }
    }
}
