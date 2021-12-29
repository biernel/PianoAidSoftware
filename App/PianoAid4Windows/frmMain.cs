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
        }

        private frmSettings frmSettings = new frmSettings();
        private frmPlaySong frmPlaySong = new frmPlaySong();


        private void btnSongName_Click(object sender, EventArgs e)
        {
            //frmPlaySong.PathToMidiFile = 
            frmPlaySong.ShowDialog();

        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMidiFile_Click(object sender, EventArgs e)
        {

            //Note has Time and Length properties. Units of values returned by these properties defined by the time division of a MIDI file.
            //But you can get time and length of a note in more understandable format.For hours, minutes, seconds you can write:
            //Using TimeAs and LengthAs methods you don't need to do any calculations by yourself. Instance of MetricTimeSpan can be implicitly casted to TimeSpan.

            var pathToMidiFile = @"C:\Data\eline\school\2021-2022\GIP\PianoAid Software\PianoAidSoftware\App\MidiFile\DurationNotes.mid";

            var songSequenceList = ConvertMidiFileToSongSequenceList(pathToMidiFile);



        }

        private Dictionary<long, string> ConvertMidiFileToSongSequenceList(string pathToMidiFile) 
        {
            var file = MidiFile.Read(pathToMidiFile);
            var notes = file.GetNotes();
            var tempoMap = file.GetTempoMap();
            var songSequenceList = new Dictionary<long, string>();
            foreach (var note in notes)
            {
                //MetricTimeSpan metricTime = note.TimeAs<MetricTimeSpan>(tempoMap);
                //MetricTimeSpan metricLength = note.LengthAs<MetricTimeSpan>(tempoMap);

                var ledId = mapMidiNoteNumberToLedID(note.NoteNumber);
                if (!songSequenceList.ContainsKey(note.Time))
                    songSequenceList.Add(note.Time, ledId);
                else
                    songSequenceList[note.Time] += ledId;
            }

            return songSequenceList;
        }

        private string mapMidiNoteNumberToLedID(int midiNoteNumber) {

            var ledID = midiNoteNumber - 24;

            return ledID.ToString().PadLeft(2, '0');

        }
    }
}
