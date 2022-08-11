using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProgram
{
    internal interface ILoopPlayer
    {
        /// <summary>
        /// Sets/returns given loop to current loop
        /// </summary>
        public List<Chord> Loop { set; get; }

        /// <summary>
        /// Converts given text to loop
        /// </summary>
        /// <param name="input">Input text in defined format</param>
        public void LoadLoop(string[] input);

        /// <summary>
        /// Increases pointer and returns next chord
        /// </summary>
        /// <returns>Next chord in loop</returns>
        public Chord NextChord();

        /// <summary>
        /// Resets pointer of the loop to the beggining
        /// </summary>
        public void Reset();
    }
}
