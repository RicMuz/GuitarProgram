using NAudio.Midi;

namespace GuitarProgram
{
    internal class Sounds : ISounds
    {
        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        // Midi device:
        private MidiOut midiOut;

        // Constants:
        private const int guitar = 26;
        private const int numberOfStrings = 6;
        private const int chanel = 1;
        private const int volume = 127;
        private const int minute = 60000;
        private GuitarTones[] openStrings = new GuitarTones[numberOfStrings] { GuitarTones.E3, GuitarTones.A3, GuitarTones.D4, GuitarTones.G4, GuitarTones.H4, GuitarTones.E5 };
        private int[] silence = new int[numberOfStrings] { -1, -1, -1, -1, -1, -1 };

        // Variables:
        private int lengtOfQuarter = 1000;
        private int[] currentlyPlaying = new int[numberOfStrings];

        #endregion

        //============================================================================================================
        // PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLI
        //============================================================================================================

        #region Public Methods

        public Sounds(int OutputDeviceID = 0)
        {
            // Initializing MidiOut device
            midiOut = new MidiOut(OutputDeviceID);

            // Setting instrument to guitar
            midiOut.Send(MidiMessage.ChangePatch(guitar, chanel).RawData);

            // Setting default value
            currentlyPlaying = silence;
        }

        public int Pace { set => lengtOfQuarter = minute / value; }

        public void ChangeOutputDevice(int OutputDeviceID)
        {
            // Releases current output device
            this.Close();

            // Initialize new output device
            midiOut = new MidiOut(OutputDeviceID);
        }

        public void Close()
        {
            // Ends the currently playing chord (if there is any)
            this.stopChord();

            //Releases current output device
            midiOut.Dispose();
        }

        public void PlayChord(int[] ChordShape, Duration duration)
        {
            // Starts playing given chord
            this.startChord(ChordShape);

            // Waits
            Thread.Sleep(howLongShouldWait(duration));

            // Ends the currently playing chord
            this.stopChord();
        }

        #endregion

        //============================================================================================================
        // PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS -
        //============================================================================================================

        #region Private Methods

        /// <summary>
        /// Starts playing given chord
        /// </summary>
        /// <param name="ChordShape">Array of 6 ints representing given tones on guitar fretboard</param>
        private void startChord(int[] ChordShape)
        {
            // Saving what is playing now
            currentlyPlaying = ChordShape;

            // Activation of all strings
            for (int i = 0; i < numberOfStrings; i++)
            {
                if (ChordShape[i] != -1)
                {
                    midiOut.Send(MidiMessage.StartNote((int)openStrings[i] + ChordShape[i], volume, chanel).RawData);
                }
            }
        }

        /// <summary>
        /// Ends the currently playing chord
        /// </summary>
        private void stopChord()
        {
            // Deactivation of all strings
            for (int i = 0; i < numberOfStrings; i++)
            {
                if (currentlyPlaying[i] != -1)
                {
                    midiOut.Send(MidiMessage.StartNote((int)openStrings[i] + currentlyPlaying[i], volume, chanel).RawData);
                }
            }

            // Setting default value
            currentlyPlaying = silence;
        }

        /// <summary>
        /// Calculates the waiting time
        /// </summary>
        /// <param name="duration">The desired length of the chord</param>
        /// <returns>Wait time relative to length and relative to bpm in milliseconds</returns>
        private int howLongShouldWait(Duration duration)
        {
            switch (duration)
            {
                case Duration.Whole:
                    return 4 * lengtOfQuarter;
                case Duration.HalfD:
                    return 3 * lengtOfQuarter;
                case Duration.Half:
                    return 2 * lengtOfQuarter;
                case Duration.QuarterD:
                    return (int)(3.0 / 2.0 * (double)lengtOfQuarter);
                case Duration.Quarter:
                    return 1 * lengtOfQuarter;
                case Duration.EightD:
                    return (int)(3.0 / 4.0 * (double)lengtOfQuarter);
                case Duration.Eight:
                    return (int)(1.0 / 2.0 * (double)lengtOfQuarter);
                case Duration.SixteenthD:
                    return (int)(3.0 / 8.0 * (double)lengtOfQuarter);
                case Duration.Sixteenth:
                    return (int)(1.0 / 4.0 * (double)lengtOfQuarter);
                default:
                    return 0;
            }
        }

        #endregion
    }
}
