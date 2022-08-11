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
        Thread playerThread;

        // Variables:
        // TODO: This should be also reset, when changing modes
        // TODO: When no chord is selected buttons shouldn't be enabled
        Tones selectedRootNote = Tones.None;
        ChordTypes selectedChordType = ChordTypes.None;
        bool shouldPlay = false;
        bool printing = false;

        #endregion

        //============================================================================================================
        // GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL - GENERAL
        //============================================================================================================

        #region General

        public Form1()
        {
            InitializeComponent();

            // Unification of points used by visual modul:
            points = new PictureBox[numberOfStrings] { pictureBoxLE, pictureBoxA, pictureBoxD, pictureBoxG, pictureBoxH, pictureBoxHE };

            // Initialize used classes:
            guitar = new Guitar(ref points, ref pictureBoxFretboard);
            fileLoader = new FileLoader();
            player = new LoopPlayer();
            playerThread = new Thread(playLoop);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(playerThread.IsAlive)
            {
                playerThread.Join();
            }
            guitar.Close();
        }

        #endregion

        //============================================================================================================
        // CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD SELECTOR - CHORD
        //============================================================================================================

        #region Chord Selector

        /// <summary>
        /// Resets chord selector to the state like after the application is opened
        /// </summary>
        private void resetChordSelector()
        {
            selectedChordType = ChordTypes.None;
            selectedRootNote = Tones.None;
            comboBoxChordType.Text = "";
            comboBoxRootNote.Text = "";
        }

        /// <summary>
        /// Enables/unenables all controls for chord selector
        /// </summary>
        /// <param name="b">True => enables, false => unenables</param>
        private void chordSelectorEnableControls(bool b)
        {
            comboBoxRootNote.Enabled = b;
            comboBoxChordType.Enabled = b;
            buttonChangeChordShape.Enabled = b;
            buttonPlayDisplayedChord.Enabled = b;
        }

        /// <summary>
        /// Selecting root note of wanted chord for chord selector
        /// </summary>
        private void comboBoxRootNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select root note and save:
            selectedRootNote = (Tones)comboBoxRootNote.SelectedIndex;

            // If both necessary information are completed, show the chord:
            if (selectedChordType != ChordTypes.None)
            {
                guitar.GetChordShape(selectedRootNote, selectedChordType);
                buttonPlayDisplayedChord.Enabled = true;
                buttonChangeChordShape.Enabled = true;
            }
        }

        /// <summary>
        /// Selecting chord type of wanted chord for chord selector
        /// </summary>
        private void comboBoxChordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select type of chord and save:
            selectedChordType = (ChordTypes)comboBoxChordType.SelectedIndex;

            // If both necessary information are completed, show the chord:
            if (selectedRootNote != Tones.None)
            {
                guitar.GetChordShape(selectedRootNote, selectedChordType);
                buttonPlayDisplayedChord.Enabled = true;
                buttonChangeChordShape.Enabled = true;
            }
        }

        /// <summary>
        /// Plays showed chord, if there is any
        /// </summary>
        private void buttonPlayDisplayedChord_Click(object sender, EventArgs e)
        {
            if (selectedChordType != ChordTypes.None && selectedRootNote != Tones.None)
            {
                guitar.PlayChord(Duration.Whole);
            }
        }

        /// <summary>
        /// Cycles through all possible chord shapes
        /// </summary>
        private void buttonChangeChordShape_Click(object sender, EventArgs e)
        {
            if (selectedChordType != ChordTypes.None && selectedRootNote != Tones.None)
            {
                guitar.ChangeShape();
            }
        }

        #endregion

        //============================================================================================================
        // LOOP PLAYER - LOOP PLAYER - LOOP PLAYER - LOOP PLAYER - LOOP PLAYER - LOOP PLAYER - LOOP PLAYER - LOOP PLAY
        //============================================================================================================

        #region Loop Player

        /// <summary>
        /// Opens file
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogFileInput.ShowDialog() == DialogResult.OK)
            {
                // Getting path to the file:
                string fileName = openFileDialogFileInput.FileName;

                // Loading and processing the file:
                List<Chord> loop = fileLoader.ReadFile(fileName);

                // Setting loaded loop as current loop:
                player.Loop = loop;

                // Reseting pointer:
                player.Reset();

                // Clearing GUI:
                richTextBoxLoop.Text = "";
                buttonPlayStopLoop.Enabled = true;
                buttonResetLoop.Enabled = true;

                // Printing loaded loop:
                foreach (Chord ch in loop)
                {
                    // The user won't have to validate again the loop:
                    printing = true;
                    richTextBoxLoop.Text += $"{ch.RootNote}; {ch.Type}; {ch.duration}\n";
                }
            }
        }

        /// <summary>
        /// Cycles through the current loop while flag is true
        /// </summary>
        private void playLoop()
        {
            // Changing mode of guitar to loop mode:
            guitar.ChangeMode();

            while (shouldPlay)
            {
                // Getting next chord in the loop:
                Chord currentChord = player.NextChord();

                // Play the chord: 
                guitar.PlayChord(currentChord.duration, currentChord.RootNote, currentChord.Type);
            }

            // Changing guitar back to normal mode:
            guitar.ChangeMode();
        }

        /// <summary>
        /// Starts/stops playing current loop and changes controls in GUI
        /// </summary>
        private void buttonPlayStopLoop_Click(object sender, EventArgs e)
        {
            // Start:
            if (!shouldPlay)
            {
                shouldPlay = true;

                // Creating new thread so the user won't loose control over the program:
                playerThread = new Thread(playLoop);

                // Changing the GUI:
                buttonPlayStopLoop.Text = "Stop Loop";
                resetChordSelector();
                chordSelectorEnableControls(false);

                // Starting the playing thread:
                playerThread.Start();
            }
            //Stop:
            else
            {
                shouldPlay = false;

                // Changing the GUI: 
                buttonPlayStopLoop.Text = "Play Loop";
                chordSelectorEnableControls(true);
                guitar.Reset();
            }
        }

        /// <summary>
        /// Unchecked (also unloaded) loop can't be played
        /// </summary>
        private void richTextBoxLoop_TextChanged(object sender, EventArgs e)
        {
            // Just if it's really not checked:
            if (!printing)
            {
                // Changing the GUI:
                buttonPlayStopLoop.Enabled = false;
                buttonResetLoop.Enabled = false;
                buttonValidateLoop.Enabled = true;
            }
            printing = false;
        }

        /// <summary>
        /// Loads loop from text
        /// </summary>
        private void buttonValidateLoop_Click(object sender, EventArgs e)
        {
            // Reseting pointer:
            player.Reset();

            // Spliting text by lines
            string[] inputLoop = richTextBoxLoop.Text.Split('\n');

            // Getting rid of last empty line:
            if (inputLoop[inputLoop.Length - 1] == "")
            {
                inputLoop = inputLoop.SkipLast(1).ToArray();
            }

            // Validation and loading:
            try
            {
                // Loads the loop:
                player.LoadLoop(inputLoop);

                // Printing the valid loop again (in a formated way):
                richTextBoxLoop.Text = "";
                foreach (Chord ch in player.Loop)
                {
                    //The user won't have to validate again the loop (endless loop otherwise):
                    printing = true;
                    richTextBoxLoop.Text += $"{ch.RootNote}; {ch.Type}; {ch.duration}\n";
                }

                // Changing GUI controls:
                buttonPlayStopLoop.Enabled = true;
                buttonResetLoop.Enabled = true;
                buttonValidateLoop.Enabled = false;
            }
            // If not valid:
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Non valid loop...\n Try again");
            }
        }

        /// <summary>
        /// Resets the pointer of the player
        /// </summary>
        private void buttonResetLoop_Click(object sender, EventArgs e)
        {
            player.Reset();
        }

        #endregion
    }
}