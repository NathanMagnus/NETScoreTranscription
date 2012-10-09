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
        public void CalculateMeasuresPerLine() 
        { 
            //todo: add up measure widths until line full
            //      if measure in X column on next line is larger, recalc all previous lines
        }

        public void CalculateLinesPerPage() 
        { 
            //todo: for each line use max height so far and calculate until page full
        }

        public void CalculateMeasureWidth() 
        { 
            //todo: for each item, calculate width, then add it all up
        }

        public void CalculateLineHeight() 
        {
            //todo: for each measure, calculate height of all measures then take max
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
        public Canvas RenderPage(Page page)
        {
            Canvas canvas = new Canvas();
            System.Windows.Shapes.Line line = new System.Windows.Shapes.Line();
            line.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            line.X1 = 1;
            line.X2 = 50;
            line.Y1 = 1;
            line.Y2 = 50;
            line.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            line.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            line.StrokeThickness = 2;

            canvas.Children.Add(line);
            Label l = GetMusicalLabel(char.ConvertFromUtf32(0x1D100) + char.ConvertFromUtf32(0x1D11A) + Constants.Clefs.TREBLE + char.ConvertFromUtf32(0x1D11A) + char.ConvertFromUtf32(0x1D11A));
            l.Margin = new Thickness(80);
            canvas.Children.Add(l);
            l = GetMusicalLabel(char.ConvertFromUtf32(0x1D15F));
            l.Margin = new Thickness(130, 63, 80, 80);
            canvas.Children.Add(l);
            
            //todo: figure out how to include ttf font in this so that don't have to draw treble cleff self
            

            //todo: render score info (large on page 1, small on pages after) (optionally selectable)
            //todo: render each line
            //todo: render page number
            return canvas;
        }

        /// <summary>
        /// Wrapper for rendering a page. This is here so that passing in information that is not represented in 
        /// MusicXML can be done.
        /// </summary>
        /// <param name="measure">The measure to render</param>
        /// <returns>Measure drawn on a canvas</returns>
        public Canvas RenderMeasure(ScorePartwisePartMeasure measure)
        {
            return WPFMeasureRendering.RenderMeasure(measure);
        }

        public void RenderLine() 
        { 
            //todo: render staff
            //todo: render each masure
        }

        public void RenderScoreInformation() 
        { 
        
        }
    }
}
