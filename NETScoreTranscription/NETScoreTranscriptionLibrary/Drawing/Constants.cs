using System;
using System.Linq;
using System.Windows.Media;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary.Drawing
{
    /// <summary>
    /// Constants for the NETScoreTranscriptionLibrary
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Definition of Music fonts
        /// </summary>
        public static class MusicFonts
        {
            public static FontFamily MUSICA = Fonts.GetFontFamilies(new Uri(@"pack://application:,,,/NETScoreTranscriptionLibrary;component/Fonts/Musica.ttf", UriKind.Absolute)).ElementAt(0);
            public static FontFamily DEFAULT = MUSICA;
            public static double DEFAULT_SIZE = 75;
            //todo: more font types
        }

        /// <summary>
        /// Constants relating to the staff
        /// </summary>
        public static class Staff
        {
            public static double LINE_WIDTH = 2;
            public static double STAFF_PADDING = 10;
            public static double LEDGER_LINE_EXTENSION = 2;
        }

        /// <summary>
        /// Constants relating to colors.
        /// Can use any built in color by System.Windows.Media.Colors.XXX.ToString();
        /// </summary>
        public static class Colors
        {
            public static String DEFAULT_NOTE_COLOR = System.Windows.Media.Colors.Black.ToString();
            public static String RED = GetSystemColorValue(System.Windows.Media.Colors.Red);
            public static String BLACK = GetSystemColorValue(System.Windows.Media.Colors.Black);
            public static String BLUE = GetSystemColorValue(System.Windows.Media.Colors.Blue);
            public static String GREEN = GetSystemColorValue(System.Windows.Media.Colors.Green);
            public static String GOLD = GetSystemColorValue(System.Windows.Media.Colors.Gold);
            public static String ORANGE = GetSystemColorValue(System.Windows.Media.Colors.Orange);
            public static String PURPLE = GetSystemColorValue(System.Windows.Media.Colors.Purple);
            public static String AQUA = GetSystemColorValue(System.Windows.Media.Colors.Aqua);
            public static String FUCHSIA = GetSystemColorValue(System.Windows.Media.Colors.Fuchsia);
            
            // todo move into a different file
            public static String GetSystemColorValue(System.Windows.Media.Color color)
            {
                return color.ToString();
            }
            //TODO: different color values?
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
        /// Constants for anything relating to a note
        /// </summary>
        public static class Note
        {
            /// <summary>
            /// Defintion of the Unicode characters for different notes
            /// </summary>
            public static class Characters
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
            /// The rotation of the note heads for rendering
            /// </summary>
            public static class HeadRotations
            {
                public static double SOLID_NOTE = -20;
                public static double WHOLE_NOTE_HOLLOW = 7;
                public static double HALF_NOTE_HOLLOW = -25;
            }

            /// <summary>
            /// Defaults for trebel clef notes
            /// </summary>
            public static class TrebelDefaults
            {
                public static Pitch PITCH = new Pitch() { octave = "5", step = Step.G };
                public static UpDown STEM_DIRECTION = UpDown.up;

                public static Pitch BOTTOM_OF_STAFF = new Pitch() {octave = "3", step = Step.E};
                public static Pitch TOP_OF_STAFF = new Pitch() {octave = "5", step = Step.F};
            }

            //todo: bass and other clefs
            public static class BassDefaults
            {

            }

            public static double LEDGER_LINE_EXTENSION = Staff.LEDGER_LINE_EXTENSION;
            public static double STEM_X_OFFSET = 3;
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
