using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProgram
{
    internal interface IGuitar
    {
        /// <summary>
        /// Calculates the offset of the shape and displays it
        /// </summary>
        /// <param name="RootNote">Root note of wanted chord</param>
        /// <param name="ChordType">Type of wanted chord</param>
        public void GetChordShape(Tones RootNote, ChordTypes ChordType);

        /// <summary>
        /// Plays currently displayed chord
        /// If root note and chord type is given, than firstly displays the chord and then plays
        /// </summary>
        /// <param name="duration">The desired length of the chord</param>
        /// <param name="RootNote">Root note of wanted chord</param>
        /// <param name="ChordType">Type of wanted chord</param>
        public void PlayChord(Duration duration, Tones RootNote = Tones.None, ChordTypes ChordType = ChordTypes.None);

        /// <summary>
        /// Changes speeed of chords
        /// </summary>
        /// <param name="bpm">Pace in bpm</param>
        public void ChangeBPM(int bpm);

        /// <summary>
        /// Resets displayed chord to none
        /// </summary>
        public void Reset();

        /// <summary>
        /// Closes all dependences
        /// </summary>
        public void Close();

        /// <summary>
        /// Changes shapes
        /// </summary>
        public void ChangeShape();
    }
}
