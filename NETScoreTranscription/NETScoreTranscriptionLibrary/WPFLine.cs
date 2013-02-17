using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.Drawing;
using NETScoreTranscriptionLibrary.MusicXML30;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary
{
    public class WPFLine
    {
        /// <summary>
        /// Get or set the font size for all measures
        /// </summary>
        public double FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                foreach (var measure in Measures) measure.FontSize = value;
            }
        }
        private double _fontSize;

        /// <summary>
        /// The measures that make up this Line
        /// </summary>
        public IList<WPFMeasure> Measures { get; private set; }

        public WPFLine() : this(new List<WPFMeasure>(), Constants.MusicFonts.DEFAULT_SIZE)
        {
            
        }

        public WPFLine(IList<WPFMeasure> measures, double fontSize)
        {
            FontSize = fontSize;
            Measures = measures;
        }
    }
}
