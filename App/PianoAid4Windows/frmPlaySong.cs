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
using System.Timers;

namespace PianoAid4Windows
{
    public partial class frmPlaySong : frmStyling
    {
        System.Timers.Timer timer = new System.Timers.Timer(1);
        private int sequenceCounter = 0;
        public frmPlaySong(string pathToMidiFile)
        {
            _pathToMidiFile = pathToMidiFile;
            InitializeComponent();
            timer.Elapsed += OnTimedEvent;
        }
        private string _pathToMidiFile;

        private void btnStartSong_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void btnStopSong_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnResetSong_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sequenceCounter = 0;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //var signalTime = e.SignalTime;
            sequenceCounter += 4;

            if (langPapiereke.ContainsKey((long)sequenceCounter))
            {
                if (_serialPort == null)
                    return;
                _serialPort.Write(langPapiereke[(long)sequenceCounter] + "#>");
            }

        }

        Dictionary<long, String> langPapiereke;

        private void frmPlaySong_Load(object sender, EventArgs e)
        {
            LoadAvailableCommPorts();

            langPapiereke = ConvertMidiFileToSongSequenceList(_pathToMidiFile);
        }

        private void frmPlaySong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort != null)
                _serialPort.Close();
        }

        private static Dictionary<long, string> ConvertMidiFileToSongSequenceList(string pathToMidiFile)
        {
            //Note has Time and Length properties. Units of values returned by these properties defined by the time division of a MIDI file.
            //But you can get time and length of a note in more understandable format.For hours, minutes, seconds you can write:
            //Using TimeAs and LengthAs methods you don't need to do any calculations by yourself. Instance of MetricTimeSpan can be implicitly casted to TimeSpan.

            var file = MidiFile.Read(pathToMidiFile);
            var notes = file.GetNotes();
            var tempoMap = file.GetTempoMap();
            var langPapiereke = new Dictionary<long, string>();
            foreach (var note in notes)
            {
                //MetricTimeSpan metricTime = note.TimeAs<MetricTimeSpan>(tempoMap);
                //MetricTimeSpan metricLength = note.LengthAs<MetricTimeSpan>(tempoMap);

                var ledId = mapMidiNoteNumberToLedID(note.NoteNumber);
                if (!langPapiereke.ContainsKey(note.Time))
                    langPapiereke.Add(note.Time, ledId);
                else
                    langPapiereke[note.Time] += ledId;
            }

            return langPapiereke;
        }

        private static string mapMidiNoteNumberToLedID(int midiNoteNumber)
        {

            var ledID = (midiNoteNumber - 36)*2;

            return ledID.ToString().PadLeft(2, '0');

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
        public string SelectedPortName { get; set; }

        private void cmbAvailablePorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPortName = cmbAvailablePorts.SelectedItem.ToString();

            if (_serialPort != null)
                _serialPort.Close();

            if (!string.IsNullOrEmpty(SelectedPortName))
            {
                _serialPort = new SerialPort(SelectedPortName, 9600, Parity.None, 8, StopBits.One);
                //_serialPort.DtrEnable = true;
                _serialPort.DataReceived += _serialPort_DataReceived;
                _serialPort.ErrorReceived += _serialPort_ErrorReceived;
                _serialPort.Open();
            }

        }

        static SerialPort _serialPort;
        List<string> strReceived = new List<string>();
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //strReceived.Add(_serialPort.ReadExisting().ToString().Replace("\n", "").Replace("\\n", "").Replace("\r", "").Replace("\\r", "").Replace("\0", "").Replace("\\0", ""));
            strReceived.Add(_serialPort.ReadExisting().ToString());
            DisplayReceivedText(strReceived);
        }

        private void _serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            // TODO processing error message here
            string message = "";
            switch (e.EventType)
            {
                case SerialError.Frame:
                    message = "Framing error ";
                    break;
                case SerialError.Overrun:
                    message = "character-buffer overrun ";
                    break;
                case SerialError.RXOver:
                    message = "Input buffer overflow";
                    break;
                case SerialError.RXParity:
                    message = "parity error pada hardware";
                    break;
                case SerialError.TXFull:
                    message = "transmit data, namun output buffer sedang penuh";
                    break;
            }
            if (!string.IsNullOrEmpty(message))
            {
                DisplayReceivedText(new List<string>() { message });
            }
        }

        //https://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        delegate void SetTextCallback(List<string> text);
        private void DisplayReceivedText(List<string> text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtReceived.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(DisplayReceivedText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtReceived.Text = "";
                foreach (var line in text)
                {
                    this.txtReceived.Text += line + Environment.NewLine;
                }
            }
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


        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            if (_serialPort == null)
                return;

            _serialPort.Write(txtCommand.Text + "#>");

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            strReceived = new List<string>();
            txtReceived.Text = "";
        }

        private void frmPlaySong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && pnlDebug.Visible)
                pnlDebug.Visible = false;
            else if (e.KeyCode == Keys.F12)
                pnlDebug.Visible = true;
        }
    }
}
