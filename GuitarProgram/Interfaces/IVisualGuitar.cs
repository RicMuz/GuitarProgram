using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProgram
{
    internal interface IVisualGuitar
    {
        /// <summary>
        /// Graphicaly shows how given chord is hold on fretboard
        /// </summary>
        /// <param name="ChordShape">Array of 6 ints representing given tones on guitar fretboard</param>
        public void ShowChord(int[] ChordShape);

        /// <summary>
        /// Resets the graphical representation like if no chord is hold
        /// </summary>
        public void Reset();
    }
}
