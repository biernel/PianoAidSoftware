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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static SerialPort _serialPort;

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort = new SerialPort("COM10", 9600);
            _serialPort.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                _serialPort.Write("1");
            else
                _serialPort.Write("0");
        }
    }
}
