using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using NETScoreTranscriptionLibrary.Drawing;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary
{
    public class WPFMeasure
    {
        /// <summary>
        /// Get or set the font size used for this measure
        /// </summary>
        public double FontSize { get; set; }

        /// <summary>
        /// The ScorePartwisePartMeasure for this measure
        /// </summary>
        public ScorePartwisePartMeasure ScoreMeasure { get; private set; }

        /// <summary>
        /// The rendering information for the measure
        /// </summary>
        public FrameworkElement MeasureFrameworkElement { get; private set; }
        
        /// <summary>
        /// Default constructor for a WPFMeasure
        /// </summary>
        public WPFMeasure() : this(new ScorePartwisePartMeasure(), Constants.MusicFonts.DEFAULT_SIZE)
        {
        }


        public WPFMeasure(ScorePartwisePartMeasure measure, double fontSize)
        {
            FontSize = fontSize;
            ScoreMeasure = measure;
            MeasureFrameworkElement = WpfMeasureRendering.RenderMeasure(measure, 0, fontSize); //todo: staff properly
        }
    }
}
