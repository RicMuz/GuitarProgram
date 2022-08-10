namespace GuitarProgram.Classes
{
    internal class Guitar : IGuitar
    {

        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        // Constants:
        private const int NumberOfTones = (int)Tones.H + 1;
        private const int NumberOfStrings = 6;
        private int[] openStrings = new int[NumberOfStrings] { -1, -1, -1, -1, -1, -1 };

        // Moduls:
        private Sounds sounds;
        private VisualGuitar visualGuitar;

        // Current state:
        private Tones currentRootNote = Tones.None;
        private ChordTypes currentChordType = ChordTypes.None;
        private int[] currentChordShape = new int[6] { -1, -1, -1, -1, -1, -1 };
        private int shapeNumber = 0;

        // List of chords:
        private Dictionary<ChordTypes, Shape[]> chordShapes = new Dictionary<ChordTypes, Shape[]>();

        // Open string tones:
        private Tones[] rootNotesOfStrings = new Tones[6] { Tones.E, Tones.A, Tones.D, Tones.G, Tones.H, Tones.E };

        #endregion

        //============================================================================================================
        // PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLI
        //============================================================================================================

        #region Public Methods

        /// <summary>
        /// Initializing guitar
        /// </summary>
        /// <param name="Points">Display module points</param>
        /// <param name="Fretboard">Display modeule background</param>
        public Guitar(ref PictureBox[] Points, ref PictureBox Fretboard)
        {
            // Chord display module initialization:
            visualGuitar = new VisualGuitar(ref Points, ref Fretboard);

            // Audio module initialization:
            sounds = new Sounds();

            // Initialazing chord shapes:
            chordShapes[ChordTypes.dur] = new Shape[3] { new Shape(new int[6] { 0, 2, 2, 1, 0, 0 }, 0), new Shape(new int[6] { 0, 3, 2, 0, 1, 0 }, 4), new Shape(new int[6] { 0, 0, 2, 2, 2, 0 }, 1) };
            chordShapes[ChordTypes.moll] = new Shape[2] { new Shape(new int[6] { 0, 2, 2, 0, 0, 0 }, 0), new Shape(new int[6] { 0, 0, 2, 2, 1, 0 }, 1) };
        }

        public void ChangeBPM(int bpm)
        {
            // Just if value is possible
            if (bpm > 0)
            { 
                sounds.Pace = bpm;
            }
        }

        public void ChangeShape()
        {
            // Changing number of chord shape
            shapeNumber++;
            shapeNumber %= chordShapes[currentChordType].Length;

            // Get new offset
            this.GetChordShape(currentRootNote, currentChordType);
        }

        public void Close()
        {
            // Release midi device
            sounds.Close();
        }

        public void GetChordShape(Tones RootNote, ChordTypes ChordType)
        {
            if (RootNote != Tones.None && ChordType != ChordTypes.None)
            {
                // If the type of chord is changing reset to original shape (otherwise => IndexOutOfRange)
                if(ChordType != currentChordType)
                {
                    shapeNumber = 0;
                }

                // Saving root note and type of chord of current chord
                currentRootNote = RootNote;
                currentChordType = ChordType;

                // Selecting possible shape of chord from the list
                Shape shape = chordShapes[currentChordType][shapeNumber];

                // Initializing variables to count the offset
                int offset = 0;
                Tones currentNote = rootNotesOfStrings[shape.RootTone];
                currentNote = (Tones)(((int)currentNote + shape.FretboardShape[shape.RootTone]) % NumberOfTones);

                // Finding the offset on string where root note of the chord shape is 
                while (currentNote != currentRootNote)
                {
                    offset++;
                    currentNote = (Tones)(((int)currentNote + 1) % NumberOfTones);
                }

                // Adding the offset to given shape and saves into currentChordShape
                for (int i = 0; i < NumberOfStrings; i++)
                {
                    currentChordShape[i] = shape.FretboardShape[i] + offset;
                }

                // Visualizing found chord shape
                visualGuitar.ShowChord(currentChordShape);
            }
        }

        public void PlayChord(Duration duration, Tones RootNote = Tones.None, ChordTypes ChordType = ChordTypes.None)
        {
            // Changing chord if needed
            if(RootNote != Tones.None && ChordType != ChordTypes.None)
            {
                this.GetChordShape(RootNote, ChordType);
            }
            else if((RootNote != Tones.None && ChordType == ChordTypes.None) || (RootNote == Tones.None && ChordType != ChordTypes.None))
            {
                throw new Exception("Neither or both"); // TODO: This line
            }

            // Playing the souds of the chord
            sounds.PlayChord(currentChordShape, duration);
        }

        public void Reset()
        {
            // Resets all variables:
            shapeNumber = 0;
            currentChordShape = openStrings;
            currentChordType = ChordTypes.None;
            currentRootNote = Tones.None;

            // Reset visual modul:
            visualGuitar.Reset();

            // Reset original bpm:
            sounds.Pace = 60;
        }

        #endregion
    }
}
