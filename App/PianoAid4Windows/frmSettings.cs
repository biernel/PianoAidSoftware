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
    public partial class frmSettings : frmStyling
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadAvailableCommPorts();
        }

        private void LoadAvailableCommPorts()
        {
            var portNames = SerialPort.GetPortNames();
            foreach (var portName in portNames)
            {
                cmbAvailablePorts.Items.Add(portName);
                //Console.WriteLine(portName);
            }
            if (portNames.Length > 0)
                cmbAvailablePorts.SelectedItem = portNames[0];
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string SelectedPortName { get; set; }

        private void cmbAvailablePorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPortName = cmbAvailablePorts.SelectedItem.ToString();
        }
    }
}
