namespace GuitarProgram
{
    //============================================================================================================
    // ENUMS - ENUMS - ENUMS - ENUMS -ENUMS -ENUMS - ENUMS - ENUMS - ENUMS - ENUMS - ENUMS - ENUMS - ENUMS - ENUMS 
    //============================================================================================================

    #region Enums

    /// <summary>
    /// Basic tones
    /// </summary>
    public enum Tones
    {
        C,
        Cis,
        D,
        Dis,
        E,
        F,
        Fis,
        G,
        Gis,
        A,
        Ais,
        H,
        None
    }

    /// <summary>
    /// Implemented types of chords
    /// </summary>
    public enum ChordTypes
    {
        dur,
        moll,
        None
    }

    /// <summary>
    /// Tones of basic tuning of a six-string guitar
    /// Special numbering: E3 in midi has number 52
    /// </summary>
    public enum GuitarTones
    {
        E3 = 52,
        F3,
        Fis3,
        G3,
        Gis3,
        A3,
        Ais3,
        H3,
        C4,
        Cis4,
        D4,
        Dis4,
        E4,
        F4,
        Fis4,
        G4,
        Gis4,
        A4,
        Ais4,
        H4,
        C5,
        Cis5,
        D5,
        Dis5,
        E5,
        F5,
        Fis5,
        G5,
        Gis5,
        A5,
        Ais5,
        H5,
        C6,
        Cis6,
        D6,
        Dis6,
        E6,
        F6,
        Fis6,
        G6,
        Gis6,
        A6,
        Ais6,
        H6,
        C7
    }

    /// <summary>
    /// Basic durations
    /// D at the end means with dot
    /// </summary>
    public enum Duration
    {
        Whole,
        HalfD,
        Half,
        Quarter,
        QuarterD,
        EightD,
        Eight,
        Sixteenth,
        SixteenthD,
        None
    }

    #endregion

    //============================================================================================================
    // STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS - STRUCTS
    //============================================================================================================

    #region Structs

    /// <summary>
    /// Given ChordType has shapes on fretboard
    /// </summary>
    public struct Shape
    {
        // Array of 6 ints, creating the shape
        public int[] FretboardShape;

        // Index of the string where root note is located in the shape
        public int RootTone;

        /// <summary>
        /// Creates a new shape
        /// </summary>
        /// <param name="FretboardShape">Array of 6 ints, creating the shape</param>
        /// <param name="RootTone">Index of a guitar string where root note is located in the shape</param>
        public Shape(int[] FretboardShape, int RootTone)
        {
            this.RootTone = RootTone;
            this.FretboardShape = FretboardShape;
        }
    }

    /// <summary>
    /// Struct for the loop
    /// </summary>
    public struct Chord
    {
        /// <summary>
        /// Contains basic information of given chord
        /// </summary>
        /// <param name="RootNote">Root note of given chord</param>
        /// <param name="Type">Type of wanted chord</param>
        /// <param name="Duration">Duration of wanted chord</param>
        public Chord(Tones RootNote, ChordTypes Type, Duration Duration)
        {
            this.RootNote = RootNote;
            this.Type = Type;
            this.duration = Duration;
        }

        // Root note of given chord
        public Tones RootNote;

        // Type of wanted chord
        public ChordTypes Type;

        // Duration of wanted chord
        public Duration duration;
    }

    #endregion
}