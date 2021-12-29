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
        }

        

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
