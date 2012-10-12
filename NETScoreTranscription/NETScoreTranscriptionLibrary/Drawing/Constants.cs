using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.Drawing;
using System.Windows.Media;

namespace NETScoreTranscription
{
    /// <summary>
    /// Constants for the NETScoreTranscriptionLibrary
    /// </summary>
    public static class Constants
    {
        //todo: more font types
        /// <summary>
        /// Definition of Music fonts
        /// </summary>
        public static class MusicFonts
        {
            public static FontFamily MUSICA = Fonts.GetFontFamilies(new Uri(@"pack://application:,,,/NETScoreTranscriptionLibrary;component/Musica.ttf", UriKind.Absolute)).ElementAt(0);
            public static FontFamily DEFAULT = MUSICA;
            public static double DEFAULT_SIZE = 20;
        }

        public static class Colors
        {
            public static String DEFAULT_NOTE_COLOR = "#000000";
        }

        /// <summary>
        /// Definition of Clef Unicode characters
        /// </summary>
        public static class Clefs
        {
            public static string TREBLE = char.ConvertFromUtf32(0x1D11E);
            public static string BASS = char.ConvertFromUtf32(0x1D122);
            //todo: rest of cleffs
        }

        /// <summary>
        /// Defintion of the Unicode characters for different notes
        /// </summary>
        public static class NoteCharacters
        {
            public static string WHOLE_NOTE = char.ConvertFromUtf32(0x1D15D);
            public static string HALF_NOTE = char.ConvertFromUtf32(0x1D15E);
            public static string QUARTER_NOTE = char.ConvertFromUtf32(0x1D15F);
            public static string EIGHTH_NOTE = char.ConvertFromUtf32(0x1D160);
            public static string SIXTEETH_NOTE = char.ConvertFromUtf32(0x1D161);
            public static string THIRTYSECOND_NOTE = char.ConvertFromUtf32(0x1D162);
            public static string SIXTYFOURTH_NOTE = char.ConvertFromUtf32(0x1D163);
            public static string ONETWENTYEIGHTH_NOTE = char.ConvertFromUtf32(0x1D164);
            //todo: smaller notes
        }

        /// <summary>
        /// Definition of the Unicode characters for different rests
        /// </summary>
        public static class RestCharacters
        {
            public static string WHOLE_REST = char.ConvertFromUtf32(0x1D13B);
            public static string HALF_REST = char.ConvertFromUtf32(0x1D13C);
            public static string QUARTER_REST = char.ConvertFromUtf32(0x1D13D);
            public static string EIGHTH_REST = char.ConvertFromUtf32(0x1D13E);
            public static string SIXTEETH_REST = char.ConvertFromUtf32(0x1D13F);
            public static string THIRTYSECOND_REST = char.ConvertFromUtf32(0x1D140);
            public static string SIXTYFOURTH_REST = char.ConvertFromUtf32(0x1D141);
            public static string ONETWENTYEIGHTH_REST = char.ConvertFromUtf32(0x1D142);
            //todo: smaller rests
        }

        /// <summary>
        /// Defition of unicode characters for different barlines
        /// </summary>
        public static class Barlines
        {
            public static string REGULAR = char.ConvertFromUtf32(0x1D100);
            public static string LIGHT_LIGHT = char.ConvertFromUtf32(0x1D101);
            public static string LIGHT_HEAVY = char.ConvertFromUtf32(0x1D102);
            public static string HEAVY_LIGHT = char.ConvertFromUtf32(0x1D103);
            public static string DASHED = char.ConvertFromUtf32(0x1D104);
            //todo: rest of barlines
        }
    }
}
