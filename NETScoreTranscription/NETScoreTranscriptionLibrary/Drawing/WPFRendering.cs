using System;
using System.Collections.Generic;
using System.Windows.Controls;
using NETScoreTranscriptionLibrary.MusicXML30;
using System.Windows.Media;
using System.Windows;
using System.Linq;
using NETScoreTranscriptionLibrary.Drawing.Interfaces;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary.Drawing
{
    // TODO: refresh option that refreshes only the notes/measures/lines/pages that have changed

    /// <summary>
    /// Rendering class. This class exists to hold information that cannot be represented
    /// in the MusicXML definition.
    /// </summary>
    public class WPFRendering : Canvas, IRendering
    {
        /// <summary>
        /// The font size to use for this rendering
        /// </summary>
        public double FontSize { get; set; }

        public Size ScoreSize { get; set; }

        private IList<WPFMeasure> _allMeasures = null;
        public IList<WPFMeasure> AllMeasures
        {
            get
            {
                if(_allMeasures == null)
                {
                    _allMeasures = new List<WPFMeasure>();
                    foreach (var part in ScorePartwise.part)
                        foreach(var measure in part.measure)
                            _allMeasures.Add(new WPFMeasure(measure, FontSize));
                }
                return _allMeasures;
            }
            private set { _allMeasures = value; }
        }
        private ScorePartwise _originalScore = null;

        private ScorePartwise _scorePartwise = null;
        public ScorePartwise ScorePartwise
        {
            get { return (_scorePartwise != null) ? _scorePartwise : _originalScore; }
            set { _scorePartwise = value; }
        }

        //todo: properties with public getter and private setter for the Pages/Lines/Measures
        
        /// <summary>
        /// Constructor for the WPFRendering component
        /// </summary>
        /// <param name="fontSize">The size of the font to use</param>
        public WPFRendering(ScorePartwise originalScore, double fontSize)
        {
            FontSize = fontSize;
            ScoreSize = new Size(Application.Current.MainWindow.Width, Application.Current.MainWindow.Height);

            // keep a copy of the original score
            _originalScore = originalScore;
        }

        public WPFRendering(ScorePartwise originalScore, Size size, double fontSize) : this(originalScore, fontSize)
        {
            ScoreSize = size;
        }

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
            double maxWidth = AllMeasures.Max(x => x.MeasureFrameworkElement.ActualWidth);
            
            return (int)Math.Ceiling(ScoreSize.Width / maxWidth);
        }


        public int CalculateLinesPerPage(IList<WPFLine> scoreLines)
        { 
            //todo: for each line use max height so far and calculate until page full
            return 0;
        }

        /// <summary>
        /// Calculate the width of a measure
        /// </summary>
        /// <param name="measure">The measure to calculate the width of</param>
        /// <returns>The width of the measure inserted</returns>
        public double CalculateMeasureWidth(ScorePartwisePartMeasure measure)
        { 
            return RenderMeasure(measure).ActualWidth;
        }
        
        public double CalculateLineHeight(WPFLine wpfLine)
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
            return GetMusicalLabel(str, Constants.MusicFonts.DEFAULT_SIZE);//todo: size properly
        }

        /// <summary>
        /// Get a Label with a mysical symbol/string in it
        /// </summary>
        /// <param name="str">The string to put in the label</param>
        /// <param name="fontSize">The current font size</param>
        /// <returns>A Label that has the string in the appropriate musical font</returns>
        public static Label GetMusicalLabel(string str, double fontSize)
        {
            Label stringLabel = new Label
                                    {
                                        Content = str,
                                        FontFamily = Constants.MusicFonts.DEFAULT,
                                        FontSize = fontSize,
                                        Padding = new Thickness(0, 0, 0, 0),
                                        Margin = new Thickness(0, 0, 0, 0)
                                    };

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
        public Grid RenderPage(WPFPage wpfPage)
        {
            Grid grid = WPFRendering.CreateAutoSizingGrid();
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
            //todo: render top staff measure and bottom then combine
            return WpfMeasureRendering.RenderMeasure(measure, 0, FontSize);
        }

        public Panel RenderMeasure(ScorePartwisePartMeasure measure, List<int> staves)
        {
            // todo: only render certain staves of a line of music
            return WPFRendering.CreateAutoSizingGrid();
        }

        /// <summary>
        /// Get a grid that auto sizes to the size of its elements
        /// </summary>
        /// <returns>Grid that auto sizes to size of elements</returns>
        public static Grid CreateAutoSizingGrid()
        {
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            return grid;
        }

        /// <summary>
        /// Render a line of music
        /// </summary>
        /// <returns>A Grid containing a line of the musical score</returns>
        public Grid RenderLine()
        {
            Grid grid = WPFRendering.CreateAutoSizingGrid();
            //todo: render staff
            int measuresPerLine = Math.Min(CalculateMeasuresPerLine(), AllMeasures.Count);

            FrameworkElement prev = null;
            for (int i = 0; i < measuresPerLine; i++)
            {
                var measure = AllMeasures[i].MeasureFrameworkElement;
                if (prev != null)
                {
                    measure.Margin = new Thickness(prev.Margin.Left + prev.ActualWidth, prev.Margin.Top, 0, 0);
                }

                grid.Children.Add(measure);
                prev = measure;
                //todo: should be a f(n) of line number and measure OR use a line class to hold
            }
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


        /// <summary>
        /// Scale a number according to the font size and default font size.
        /// </summary>
        /// <param name="value">The number to scale based on current font size and default font size</param>
        /// <param name="fontSize">The current font size</param>
        /// <returns></returns>
        public static double GetFontFraction(double value, double fontSize)
        {
            return value * fontSize / Constants.MusicFonts.DEFAULT_SIZE;
        }

        /// <summary>
        /// Get the size ratio between the current font size and default font size
        /// </summary>
        /// <param name="fontSize">Current font size</param>
        /// <returns>Value to divide current font size to get default font size</returns>
        public static double GetFontFraction(double fontSize)
        {
            return GetFontFraction(1, fontSize);
        }
    }
}
