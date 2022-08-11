using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GuitarProgram
{
    internal class FileLoader : IFileLoader
    {
        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        // Components:
        XmlReader reader;

        #endregion

        //============================================================================================================
        // PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLI
        //============================================================================================================

        #region Public Methods

        public FileLoader()
        {

        }

        public List<Chord> ReadFile(string FileName)
        {
            // Loading file:
            reader = XmlReader.Create(FileName);

            // Variable to return
            List<Chord> chordList = new List<Chord>();

            // Default variables for reading the file:
            ChordTypes chordType = ChordTypes.dur;
            Tones RootNote = Tones.None;
            Duration duration = 0;
            bool dot = false;
            string element = "";

            // Reading every line of file:
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    element = reader.Name;
                }

                else if (reader.NodeType == XmlNodeType.Text)
                {
                    switch (element)
                    {
                        case "root":
                            RootNote = this.getRootNote(int.Parse(reader.Value));
                            break;
                        case "name":
                            chordType = this.getChordType(reader.Value);
                            break;
                        case "durationType":
                            duration = this.getDuration(reader.Value, dot);
                            break;
                        case "dots":
                            dot = true;
                            break;
                    }
                }

                else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Rest")
                {
                    // Adding found chord:
                    if(RootNote != Tones.None)
                    { 
                        chordList.Add(new Chord(RootNote, chordType, duration));
                    }
                    else
                    {
                        chordList.Add(new Chord(RootNote, ChordTypes.None, duration));
                    }

                    // Reseting values for next chord:
                    chordType = ChordTypes.dur;
                    RootNote = Tones.None;
                    duration = Duration.None;
                    dot = false;
                }
            }

            return chordList;
        }

        #endregion

        //============================================================================================================
        // PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS - PRIVATE METHODS -
        //============================================================================================================

        #region Private Methods

        /// <summary>
        /// Converts the duration to the desired format
        /// </summary>
        /// <param name="duration">Duration from file</param>
        /// <param name="dot">Presence of a dot</param>
        /// <returns>Duration as enum</returns>
        private Duration getDuration(string duration, bool dot)
        {
            if (dot)
            {
                switch (duration)
                {
                    case "half":
                        return Duration.HalfD;
                    case "quarter":
                        return Duration.QuarterD;
                    case "eighth":
                        return Duration.EightD;
                    case "16th":
                        return Duration.SixteenthD;
                    default:
                        return Duration.None;
                }
            }
            switch (duration)
            {
                case "whole":
                    return Duration.Whole;
                case "half":
                    return Duration.Half;
                case "quarter":
                    return Duration.Quarter;
                case "eighth":
                    return Duration.Eight;
                case "16th":
                    return Duration.Sixteenth;
                default:
                    return Duration.None;
            }
        }

        /// <summary>
        /// Converts the type of chord to the desired format
        /// </summary>
        /// <param name="name">Type of chord from file</param>
        /// <returns>Type of chord as enum</returns>
        private ChordTypes getChordType(string name)
        {
            switch (name)
            {
                case "m":
                    return ChordTypes.moll;
                default:
                    return ChordTypes.dur;
            }
        }

        /// <summary>
        /// Converts the root note of the chord to the desired format
        /// </summary>
        /// <param name="root">Root note of the chord from file</param>
        /// <returns>Root note as enum</returns>
        private Tones getRootNote(int root)
        {
            switch (root)
            {
                case 14:
                    return Tones.C;
                case 21:
                    return Tones.Cis;
                case 16:
                    return Tones.D;
                case 23:
                    return Tones.Dis;
                case 18:
                    return Tones.E;
                case 13:
                    return Tones.F;
                case 20:
                    return Tones.Fis;
                case 15:
                    return Tones.G;
                case 22:
                    return Tones.Gis;
                case 17:
                    return Tones.A;
                case 24:
                    return Tones.Ais;
                case 19:
                    return Tones.H;
                default:
                    return Tones.None;
            }
        }

        #endregion
    }
}
