namespace GuitarProgram
{
    internal class LoopPlayer : ILoopPlayer
    {
        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        private List<Chord> currentLoop = new List<Chord>();
        private int loopPointer = 0;
        private int numberOfChords = 0;

        #endregion

        //============================================================================================================
        // PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLI
        //============================================================================================================

        #region Public Methods

        public LoopPlayer()
        {

        }

        public List<Chord> Loop { set { currentLoop = value; numberOfChords = currentLoop.Count; } get { return currentLoop; } }

        public int NumberOfChords { get { return numberOfChords; } }

        public int LoadLoop(string[] input)
        {
            // Getting lenght of the input: 
            int lenghtOfInput = input.Length;

            // Creating new list:
            List<Chord> newLoop = new List<Chord>();

            // Processing of input parts
            for (int i = 0; i < lenghtOfInput; i++)
            {
                string Line = input[i].ToUpper();
                string[] parts = Line.Split(";");

                // Not enough information:
                if(parts.Length != 3)
                {
                    return i;
                }

                // Getting correct format:
                Tones tone = getRootNote(parts[0].Trim());
                ChordTypes chordType = getChordType(parts[1].Trim());
                Duration duration = getDuration(parts[2].Trim());

                // Dash:
                if ((tone == Tones.None || chordType == ChordTypes.None) && duration != Duration.None)
                {
                    newLoop.Add(new Chord(Tones.None, ChordTypes.None, duration));
                }
                // Bad input (Nothing happens):
                else if (duration == Duration.None)
                {
                    newLoop.Add(new Chord(Tones.None, ChordTypes.None, Duration.None));
                }
                // Normal tone:
                else
                {
                    newLoop.Add(new Chord(tone, chordType, duration));
                }
            }

            // Saves the new loop
            this.Loop = newLoop;

            // Successful load:
            return -1;
        }

        public Chord NextChord()
        {
            // Saving chord to return:
            Chord toReturn = currentLoop[loopPointer];

            // Increment of pointer:
            loopPointer++;
            loopPointer %= numberOfChords;

            // Returning the value:
            return toReturn;
        }

        public void Reset()
        {
            loopPointer = 0;
        }

        #endregion

        //============================================================================================================
        // PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS -
        //============================================================================================================

        #region Private Methods

        /// <summary>
        /// Converts the root note to the desired format
        /// </summary>
        /// <param name="rootNote">Root note as string</param>
        /// <returns>Root note as enum</returns>
        private Tones getRootNote(string rootNote)
        {
            switch (rootNote)
            {
                case "C":
                    return Tones.C;
                case "CIS":
                    return Tones.Cis;
                case "D":
                    return Tones.D;
                case "DIS":
                    return Tones.Dis;
                case "E":
                    return Tones.E;
                case "F":
                    return Tones.F;
                case "FIS":
                    return Tones.Fis;
                case "G":
                    return Tones.G;
                case "GIS":
                    return Tones.Gis;
                case "A":
                    return Tones.A;
                case "AIS":
                    return Tones.Ais;
                case "H":
                    return Tones.H;
                default:
                    return Tones.None;
            }
        }

        /// <summary>
        /// Converts the type of chord to the desired format
        /// </summary>
        /// <param name="chordType">Type of chord as string</param>
        /// <returns>Type of chord as enum</returns>
        private ChordTypes getChordType(string chordType)
        {
            switch (chordType)
            {
                case "DUR":
                    return ChordTypes.dur;
                case "MOLL":
                    return ChordTypes.moll;
                default:
                    return ChordTypes.None;
            }
        }

        /// <summary>
        /// Converts the duration to the desired format
        /// </summary>
        /// <param name="duration">Duration as string</param>
        /// <returns>Duration as enum</returns>
        private Duration getDuration(string duration)
        {
            switch (duration)
            {
                case "WHOLE":
                    return Duration.Whole;
                case "HALF":
                    return Duration.Half;
                case "HALFD":
                    return Duration.HalfD;
                case "QUARTER":
                    return Duration.Quarter;
                case "QUARTERD":
                    return Duration.QuarterD;
                case "EIGHT":
                    return Duration.Eight;
                case "EIGHTD":
                    return Duration.EightD;
                case "SIXTEENTH":
                    return Duration.Sixteenth;
                case "SIXTEENTHD":
                    return Duration.SixteenthD;
                default:
                    return Duration.None;
            }
        }

        #endregion
    }
}
