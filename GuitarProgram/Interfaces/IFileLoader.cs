using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarProgram
{
    internal interface IFileLoader
    {
        /// <summary>
        /// Reads and processes the file
        /// </summary>
        /// <param name="FileName">Name of wanted file</param>
        /// <returns>List of chords to be play in loop</returns>
        public List<Chord> ReadFile(string FileName);
    }
}
