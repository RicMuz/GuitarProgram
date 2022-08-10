namespace GuitarProgram
{
    internal class VisualGuitar : IVisualGuitar
    {
        //============================================================================================================
        // DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DATA - DA
        //============================================================================================================

        #region Data

        // Display components:
        PictureBox[] points;
        PictureBox fretBoard;

        //Constansts:
        private Point[] originalPositionsOfPoints;
        private const int x = 41;
        private const int numberOfStrings = 6;
        private int[] openStrings = new int[numberOfStrings] { 0, 0, 0, 0, 0, 0 };
        double[] y = new double[numberOfStrings] { 4 / 3, 1 / 3, 2 / 3, -2 / 3, -1 / 3, -4 / 3 };

        #endregion

        //============================================================================================================
        // PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLIC METHODS - PUBLI
        //============================================================================================================

        #region Public Methods

        /// <summary>
        /// Initialize viual output and sets used components
        /// </summary>
        /// <param name="Points">Position indicator for each string</param>
        /// <param name="Fretboard">Background image</param>
        public VisualGuitar(ref PictureBox[] Points, ref PictureBox Fretboard)
        {
            // Initializing components used to show the chord
            this.points = Points;
            this.fretBoard = Fretboard;

            // Saving oroginal positions
            originalPositionsOfPoints = new Point[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                originalPositionsOfPoints[i] = points[i].Location;
            }
        }

        public void Reset()
        {
            // All points to original position
            this.ShowChord(openStrings);
        }

        public void ShowChord(int[] ChordShape)
        {
            // Moves all points to desired chord shape
            for (int i = 0; i < numberOfStrings; i++)
            {
                points[i].Location = new Point(originalPositionsOfPoints[i].X + ChordShape[i] * x, (int)((double)originalPositionsOfPoints[i].Y + (double)ChordShape[i] * y[i]));
            }

            // Background refresh
            fretBoard.Refresh();
        }

        #endregion
    }
}
