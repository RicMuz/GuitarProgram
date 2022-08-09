using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProgram
{
    internal interface ISounds
    {
        /// <summary>
        /// Sets pace in bpm
        /// </summary>
        public int Pace { set; }

        /// <summary>
        /// Plays the given chord
        /// </summary>
        /// <param name="ChordShape">Array of 6 ints representing given tones on guitar fretboard</param>
        /// <param name="duration">The desired length of the chord</param>
        public void PlayChord(int[] ChordShape, Duration duration);

        /// <summary>
        /// Changing output device
        /// </summary>
        /// <param name="OutputDeviceID">ID of new output device</param>
        public void ChangeOutputDevice(int OutputDeviceID);

        /// <summary>
        /// Release of used equipment
        /// </summary>
        public void Close();
    }
}
