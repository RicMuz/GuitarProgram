namespace GuitarProgram
{
    public partial class Form1 : Form
    {
        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        // Constants: 
        private const int numberOfStrings = 6;

        // Components:
        Guitar guitar;
        PictureBox[] points;
        FileLoader fileLoader;
        LoopPlayer player;

        // Variables:
        // TODO: This should be also reset, when changing modes
        // TODO: When no chord is selected buttons shouldn't be enabled
        Tones selectedRootNote = Tones.None;
        ChordTypes selectedChordType = ChordTypes.None;
        bool shouldPlay = false;

        #endregion

        //============================================================================================================
        // GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL
        //============================================================================================================

        #region General

        public Form1()
        {
            InitializeComponent();
            points = new PictureBox[numberOfStrings]  { pictureBoxLE, pictureBoxA, pictureBoxD, pictureBoxG, pictureBoxH, pictureBoxHE };

            guitar = new Guitar(ref points, ref pictureBoxFretboard);
            fileLoader = new FileLoader();
            player = new LoopPlayer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            guitar.Close();
        }

        #endregion

        //============================================================================================================
        // CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD
        //============================================================================================================

        #region Chord Selector

        private void resetChordSelector()
        {
            selectedChordType = ChordTypes.None;
            selectedRootNote = Tones.None;
            comboBoxChordType.Text = "";
            comboBoxRootNote.Text = "";
        }

        private void chordSelectorEnableControls(bool b)
        {
            comboBoxRootNote.Enabled = b;
            comboBoxChordType.Enabled = b;
            buttonChangeChordShape.Enabled = b;
            buttonPlayDisplayedChord.Enabled = b;
        }

        private void comboBoxRootNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRootNote = (Tones)comboBoxRootNote.SelectedIndex;

            if(selectedChordType != ChordTypes.None)
            {
                guitar.GetChordShape(selectedRootNote, selectedChordType);
                buttonPlayDisplayedChord.Enabled = true;
                buttonChangeChordShape.Enabled = true;
            }
        }

        private void comboBoxChordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedChordType = (ChordTypes)comboBoxChordType.SelectedIndex;

            if(selectedRootNote != Tones.None)
            {
                guitar.GetChordShape(selectedRootNote,selectedChordType);
                buttonPlayDisplayedChord.Enabled = true;
                buttonChangeChordShape.Enabled= true;
            }
        }

        private void buttonPlayDisplayedChord_Click(object sender, EventArgs e)
        {
            if(selectedChordType != ChordTypes.None && selectedRootNote != Tones.None)
            {
                guitar.PlayChord(Duration.Whole);
            }
        }

        private void buttonChangeChordShape_Click(object sender, EventArgs e)
        {
            if (selectedChordType != ChordTypes.None && selectedRootNote != Tones.None)
            {
                guitar.ChangeShape();
            }
        }

        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialogFileInput.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialogFileInput.FileName;
                List<Chord> loop = fileLoader.ReadFile(fileName);

                player.Loop = loop;
                player.Reset();
                richTextBoxLoop.Text = "";
                buttonPlayStopLoop.Enabled = true;

                foreach(Chord ch in loop)
                {
                    richTextBoxLoop.Text += $"{ch.RootNote}; {ch.Type}; {ch.duration}\n";
                }
            }
        }

        private void playLoop()
        {
            while(shouldPlay)
            {
                Chord currentChord = player.NextChord();
                guitar.PlayChord(currentChord.duration, currentChord.RootNote, currentChord.Type);
            }
        }

        private void buttonPlayStopLoop_Click(object sender, EventArgs e)
        {
            if(!shouldPlay)
            {
                shouldPlay = true;
                buttonPlayStopLoop.Text = "Stop Loop";
                resetChordSelector();
                chordSelectorEnableControls(false);
                playLoop();
            }
            else
            {
                shouldPlay = false;
                buttonPlayStopLoop.Text = "Play Loop";
                chordSelectorEnableControls(true);
            }
        }
    }
}