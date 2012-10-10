using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using NETScoreTranscriptionLibrary.MusicXML30;
using System.Windows.Media;
using NETScoreTranscription;
using System.Windows;
using System.Windows.Media.Animation;
using NETScoreTranscriptionLibrary.Drawing.Interfaces;
using NETScoreTranscriptionLibrary.Drawing;

namespace NETScoreTranscriptionLibrary
{
    /// <summary>
    /// Rendering class. This class exists to hold information that cannot be represented
    /// in the MusicXML definition.
    /// </summary>
    public class WPFRendering : Canvas, IRendering
    {
        public double Scale { get; set; } //todo: invalidate drawing when scale is changed

        /* TODO: Calculate size
         * - Positions determined by defaultx, defaulty, relativex, relativey
         *  - defaults used only if relatiave is not specified
         * - Add in a scaling option and multiply all sizes and positions by that
         * - Changing scale will need everything to be recalced
         * - Page and Line classes exist to allow storage of info so can change later
         * - Change of color only needs to invalidate affected elements
         * - Have items inherit System.Windows.Shapes.Shape?
         */
        public int CalculateMeasuresPerLine()
        {
            //todo: add up measure widths until line full
            //      if measure in X column on next line is larger, recalc all previous lines
            return 0;
        }

        public int CalculateLinesPerPage(IList<Line> scoreLines)
        { 
            //todo: for each line use max height so far and calculate until page full
            return 0;
        }


        public double CalculateMeasureWidth()
        { 
            //todo: for each item, calculate width, then add it all up
            //      maybe just render it and then take the width of that, though that is a lot of processing for nothing
            return 0d;
        }
        
        public double CalculateLineHeight(Line line)
        {
            //todo: for each measure, calculate height of all measures then take max
            return 0d;
        }

        /// <summary>
        /// Get the height of the font used
        /// </summary>
        /// <param name="size">The font size used</param>
        /// <param name="font">The font used</param>
        /// <returns>The height of the font that is being used</returns>
        public static double GetFontHeight(double size, FontFamily font)
        {
            return Math.Ceiling(size * font.LineSpacing);
        }

        /// <summary>
        /// Get a label for a Musical symbol/string
        /// </summary>
        /// <param name="str">The string to make into a label</param>
        /// <returns>A new label with the musical symbol/string in it</returns>
        public static Label GetMusicalLabel(string str)
        {
            Label stringLabel = new Label();
            stringLabel.Content = str;
            stringLabel.FontFamily = Constants.MusicFonts.MUSICA;
            stringLabel.FontSize = 75; //todo: use font size that is settable
            //stringLabel.Background = Brushes.Aqua; //todo: remove


            RecalculateSize(stringLabel);
            return stringLabel;
        }

        /// <summary>
        /// Recalculate the size of a FrameworkElement
        /// </summary>
        /// <param name="element">The FrameworkElement to recalculate the size for</param>
        public static void RecalculateSize(FrameworkElement element)
        {
            element.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
            element.Arrange(new Rect(element.DesiredSize));
        }

        /// <summary>
        /// Wrapper for rendering a page. This is here so that information not held within the
        /// definition of MusicXML can be passed in.
        /// </summary>
        /// <returns>Canvas with a page rendered on it</returns>
        public Grid RenderPage(Page page)
        {
            Grid grid = new Grid();
            //todo: render score info (large on page 1, small on pages after) (optionally selectable)
            //todo: render each line
            //todo: render page number
            return grid;
        }

        /// <summary>
        /// Wrapper for rendering a page. This is here so that passing in information that is not represented in 
        /// MusicXML can be done.
        /// </summary>
        /// <param name="measure">The measure to render</param>
        /// <returns>Measure drawn on a canvas</returns>
        public Panel RenderMeasure(ScorePartwisePartMeasure measure)
        {
            return WPFMeasureRendering.RenderMeasure(measure);
        }

        /// <summary>
        /// Render a line of music
        /// </summary>
        /// <returns>A Grid containing a line of the musical score</returns>
        public Grid RenderLine() 
        {
            Grid grid = new Grid();
            //todo: render staff
            //todo: render each masure
            return grid;
        }

        /// <summary>
        /// Render the score information
        /// </summary>
        /// <returns>A Grid containing the score information</returns>
        public Grid RenderScoreInformation() 
        {
            Grid grid = new Grid();

            return grid;
        }
    }
}
