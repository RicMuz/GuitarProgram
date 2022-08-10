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

        // Variables:
        // TODO: This should be also reset, when changing modes
        // TODO: When no chord is selected buttons shouldn't be enabled
        Tones selectedRootNote = Tones.None;
        ChordTypes selectedChordType = ChordTypes.None;

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
    }
}