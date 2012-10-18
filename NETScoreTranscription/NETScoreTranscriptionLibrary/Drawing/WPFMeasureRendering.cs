using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using NETScoreTranscriptionLibrary.MusicXML30;
using NETScoreTranscription;
using System.Windows;
using System.Windows.Media;
using NETScoreTranscriptionLibrary.Drawing.Interfaces;
using NETScoreTranscriptionLibrary.Exceptions.Drawing;
using System.Windows.Shapes;

namespace NETScoreTranscriptionLibrary.Drawing
{
    //todo: use defaults if defined.

    /// <summary>
    /// WPF Rendering functions for a measure.
    /// </summary>
    public static class WPFMeasureRendering
    {
        //todo: put note rendering into its own class
        /// <summary>
        /// Parse the contents of a note and prepare the basic label
        /// </summary>
        /// <param name="note">The note to parse and create a label for</param>
        /// <returns>A label with the note in it</returns>
        public static Panel RenderNoteOrRest(Note note)
        {
            //todo: Render appropriate connectors
            //todo: render barline
            //todo: tuplets, triplets, beams

            //todo: likely remove this whole function because will need to draw own notes due to stem when beaming
            String noteChar = Constants.NoteCharacters.WHOLE_NOTE;
            Panel grid = WPFRendering.CreateAutoSizingGrid();
            
            

            //todo: if it has a rest, then parse as rest, otherwise parse as note
            bool isRest = false;
            try
            {
                note.Items.Single(i => i.GetType() == typeof(Rest));
                isRest = true;
            }
            catch { }

            if (!isRest)
            {
                FrameworkElement noteHead = RenderNoteHead(note);
                //noteHead.Margin = new Thickness(noteHead.Margin.Left, noteHead.Margin.Top + 30, 0, 0); //todo: stem offset

                grid.Children.Add(noteHead);

                //todo: stems when beamed... This will likely require stems to be drawn after the note heads of the beaming
                //      however, beaming is not supposed to go over measures so this will save some of the problems that this could have

                //todo: use stemvalue to do up or down
                // add the stem
                System.Windows.Shapes.Line noteStem = new System.Windows.Shapes.Line()
                    {
                        X1 = noteHead.ActualWidth - 2, //todo: need to adjust according to size of note
                        X2 = noteHead.ActualWidth - 2, //todo: need to adjust according to size of note
                        Y1 = noteHead.ActualHeight / 2,
                        Y2 = noteHead.ActualHeight / 2 - 30, //todo: stem offset
                        StrokeThickness = 2, //todo: thickness same as staff
                        Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(note.stem.color))
                    };
                grid.Children.Add(noteStem);

                //todo: accidentals
                //todo: clef change on note
                //todo: other notes?
                
                //todo: if is above half of the staff, rotate so everything points down
                // rotate head
                /*
                RotateTransform rt = new RotateTransform(180);
                rt.CenterX = noteHead.ActualWidth / 2;
                rt.CenterY = 10 * 3 / 4; //todo: use note height calculation from render notehead
                grid.RenderTransform = rt;
                */
            }
            else
            {
                FrameworkElement restElement = RenderRest(note);
                grid.Children.Add(restElement);
            }

            grid.VerticalAlignment = VerticalAlignment.Center;
            WPFRendering.RecalculateSize(grid);
            return grid;
        }

        /// <summary>
        /// Render a note.
        /// </summary>
        /// <param name="note">Information for the note to render</param>
        /// <returns>A note rendered on a Fraemwork Element</returns>
        private static FrameworkElement RenderNoteHead(Note note)
        {
            //todo: chords
            //todo: different shapes of note heads
            String noteChar = "";
            Panel noteHeadGrid = WPFRendering.CreateAutoSizingGrid();
            FrameworkElement noteHead = new Label();
            FrameworkElement noteHeadInside = new Label();

            if (string.IsNullOrEmpty(note.color))
                note.color = Constants.Colors.DEFAULT_NOTE_COLOR;
            Brush noteBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(note.color));

            RotateTransform hollowRT = new RotateTransform();

            bool rotateHead = false;
            bool hollow = false;

            switch (note.type.Value)
            {
                //todo: size note heads using width expected for font
                case NoteTypeValue.whole:
                    noteChar = Constants.NoteCharacters.WHOLE_NOTE;
                    // make outside
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    hollow = true;
                    // make hole
                    noteHeadInside = new Ellipse() { Fill = new SolidColorBrush(Colors.White), Height = 6, Width = 5 * 3 / 2 };
                    hollowRT.Angle = Constants.NoteHeadRotations.WHOLE_NOTE_HOLLOW; //todo: make this rotation a constant, note same as head rotation
                    break;
                case NoteTypeValue.half:
                    noteChar = Constants.NoteCharacters.HALF_NOTE;
                    // make outside
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    rotateHead = true;
                    hollow = true;
                    // make hole
                    noteHeadInside = new Ellipse() { Fill = new SolidColorBrush(Colors.White), Height = 7, Width = 8 * 3 / 2 };
                    hollowRT.Angle = Constants.NoteHeadRotations.HALF_NOTE_HOLLOW; //todo: make this rotation a constant, note same as head rotation
                    break;
                case NoteTypeValue.quarter:
                    noteChar = Constants.NoteCharacters.QUARTER_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 }; //todo: vars for vals
                    rotateHead = true;
                    break;
                case NoteTypeValue.eighth:
                    noteChar = Constants.NoteCharacters.EIGHTH_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 }; //todo: vars for vals
                    rotateHead = true;
                    break;
                case NoteTypeValue.Item16th:
                    noteChar = Constants.NoteCharacters.SIXTEETH_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    rotateHead = true;
                    break;
                case NoteTypeValue.Item32nd:
                    noteChar = Constants.NoteCharacters.THIRTYSECOND_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    rotateHead = true;
                    break;
                case NoteTypeValue.Item64th:
                    noteChar = Constants.NoteCharacters.SIXTYFOURTH_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    rotateHead = true;
                    break;
                case NoteTypeValue.Item128th:
                    noteChar = Constants.NoteCharacters.ONETWENTYEIGHTH_NOTE;
                    noteHead = new Ellipse() { Fill = noteBrush, Height = 10, Width = 10 * 3 / 2 };
                    rotateHead = true;
                    break;
                case NoteTypeValue.Item256th:
                    rotateHead = true;
                    noteChar = "!";
                    break;
                case NoteTypeValue.Item512th:
                    rotateHead = true;
                    noteChar = "!";
                    break;
            }

            if (rotateHead)
            {
                // rotate head
                RotateTransform rt = new RotateTransform();
                rt.Angle = Constants.NoteHeadRotations.SOLID_NOTE;
                noteHead.LayoutTransform = rt;
            }

            noteHeadGrid.Children.Add(noteHead);

            if (hollow)
            {
                noteHeadInside.LayoutTransform = hollowRT;
                noteHeadGrid.Children.Add(noteHeadInside);
            }

            WPFRendering.RecalculateSize(noteHead);
            WPFRendering.RecalculateSize(noteHeadGrid);
            //todo: Render modifiers

            return noteHeadGrid;
        }

        /// <summary>
        /// Render a rest
        /// </summary>
        /// <param name="note">Representation of the rest to render</param>
        /// <returns>The rest rendered on a Framework Element</returns>
        private static FrameworkElement RenderRest(Note note)
        {
            string restChar = "";
            switch (note.type.Value)
            {
                case NoteTypeValue.whole:
                    restChar = Constants.RestCharacters.WHOLE_REST;
                    break;
                case NoteTypeValue.half:
                    restChar = Constants.RestCharacters.HALF_REST;
                    break;
                case NoteTypeValue.quarter:
                    restChar = Constants.RestCharacters.QUARTER_REST;
                    break;
                case NoteTypeValue.eighth:
                    restChar = Constants.RestCharacters.EIGHTH_REST;
                    break;
                case NoteTypeValue.Item16th:
                    restChar = Constants.RestCharacters.SIXTEETH_REST;
                    break;
                case NoteTypeValue.Item32nd:
                    restChar = Constants.RestCharacters.THIRTYSECOND_REST;
                    break;
                case NoteTypeValue.Item64th:
                    restChar = Constants.RestCharacters.SIXTYFOURTH_REST;
                    break;
                case NoteTypeValue.Item128th:
                    restChar = Constants.RestCharacters.ONETWENTYEIGHTH_REST;
                    break;
                case NoteTypeValue.Item256th:
                    restChar = "!";
                    break;
                case NoteTypeValue.Item512th:
                    restChar = "!";
                    break;
            }
            //todo: it is a rest
            FrameworkElement restLabel = WPFRendering.GetMusicalLabel(restChar);

            WPFRendering.RecalculateSize(restLabel);
            return restLabel;
        }

        /// <summary>
        /// Parse the barline information given and create an appropriate label that can be put onto a canvas.
        /// </summary>
        /// <param name="barline">The Barline information to parse</param>
        /// <returns>Label that holds the barline</returns>
        public static Label ParseBarline(Barline barline)
        {
            string barlineChar;
            switch (barline.barStyle.Value)
            {
                case BarStyle.regular:
                    barlineChar = Constants.Barlines.REGULAR;
                    break;
                case BarStyle.lightlight:
                    barlineChar = Constants.Barlines.LIGHT_LIGHT;
                    break;
                case BarStyle.lightheavy:
                    barlineChar = Constants.Barlines.LIGHT_HEAVY;
                    break;
                case BarStyle.heavylight:
                    barlineChar = Constants.Barlines.HEAVY_LIGHT;
                    break;
                case BarStyle.dashed:
                    barlineChar = Constants.Barlines.DASHED;
                    break;
                default:
                    barlineChar = Constants.Barlines.REGULAR;
                    break;
                //todo: rest of barlines
            }

            Label barlineLabel = WPFRendering.GetMusicalLabel(barlineChar);
            WPFRendering.RecalculateSize(barlineLabel);
            return barlineLabel;
        }

        /// <summary>
        /// Render a measure onto a canvas
        /// </summary>
        /// <param name="measure">The measure to render</param>
        /// <param name="staff">The staff being rendered for</param>
        /// <returns>A Framework Element with the measure rendered onto it</returns>
        public static Panel RenderMeasure(ScorePartwisePartMeasure measure, int staff, double fontSize) //todo: not return canvas
        {
            //todo: stack/queue for tie
            //todo: stack/queue for slur
            //todo: stack/queue for beam

            //todo: maybe approach this by doing all staves in render measure?

            double left = 0; //todo: padding/margin
            double top = 0; //todo: padding/margin

            ICollection<object> itemList = measure.Items;
            FrameworkElement element = null;
            Panel grid = WPFRendering.CreateAutoSizingGrid();
            grid.Margin = new Thickness(50, 50, 0, 0); //todo: proper margin

            //todo: render multiple staves for multi-part instruments etc
            //      This should be as simple as rendering a second staff then putting the note onto that staff as required
            //      Then joining those two staves via a wrapper container
            
            //todo: render each item
            for (int i = 0; i < itemList.Count; i++)
            {
                object obj = itemList.ElementAt(i);
                Type type = obj.GetType();
                

                if (type == typeof(Attributes))
                {
                    Attributes attributes = (Attributes)obj;
                    element = RenderAttributes(attributes, staff, fontSize);
                }
                else if (type == typeof(Note))
                {
                    //todo: may need to use attributes from previous measure to figure out where to render
                    Note note = (Note)obj;
                    element = RenderNoteOrRest(note);
                }
                else if (type == typeof(Barline))
                {
                    Barline barline = (Barline)obj;
                    element = ParseBarline(barline);
                }
                else if (type == typeof(Print))
                {
                    //todo: complete this section
                    element = new Label();
                }
                else if (type == typeof(Direction))
                {
                    //todo: complete this section
                    element = new Label();
                }

                if (element != null)
                {
                    element.Margin = new Thickness(left, top, 0, 0);
                    grid.Children.Add(element);
                    left += element.ActualWidth + 0; //todo: margin
                }
                else
                {
                    throw new NullMeasureElementException("Null element: " + obj.GetType() + "\n");
                }
            }

            //todo: render staff
            element = RenderStaff(Constants.Colors.DEFAULT_NOTE_COLOR, left, fontSize);
            grid.Children.Add(element);

            WPFRendering.RecalculateSize(grid);
            return grid;
        }

        private static Panel RenderStaff(String colorString, double left, double fontSize)
        {
            //todo: implement
            Grid grid = WPFRendering.CreateAutoSizingGrid();
            //get the height of the staff for the font and use that to draw the lines.
            double height = WPFRendering.GetFontHeight(fontSize, Constants.MusicFonts.MUSICA);
            double lineWidth = 2; //todo: calculate line width properly

            int numLines = 5; //todo: different numbers of lines
            height -= numLines * lineWidth;
            double spacing = height / numLines;
            for (int i = 0; i < numLines; i++)
            {
                System.Windows.Shapes.Line staffLine = new System.Windows.Shapes.Line()
                {
                    X1 = 0,
                    X2 = left + 10, //todo: proper padding after line
                    Y1 = i * spacing,
                    Y2 = i * spacing,
                    StrokeThickness = lineWidth,
                    Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorString))
                };
                WPFRendering.RecalculateSize(staffLine);
                grid.Children.Add(staffLine);
            }
            grid.VerticalAlignment = VerticalAlignment.Center;
            WPFRendering.RecalculateSize(grid);
            return grid;
        }

        //TODO: Need to use "last attribute" somehow for measures without attributes set
        /// <summary>
        /// Render the attributes of a measure
        /// </summary>
        /// <param name="attributes">The attributes object to render</param>
        /// <param name="c">The canvas to render onto</param>
        /// <param name="staff">The staff being rendered for</param>
        /// <returns>A canvas with the attributes of a measure rendered onto it</returns>
        private static Panel RenderAttributes(Attributes attributes, int staff, double fontSize)
        {
            FrameworkElement element;
            Panel grid = WPFRendering.CreateAutoSizingGrid();
            double left = 0;

            //todo: render multiple clefs because of multi-line parts
            element = RenderClef(attributes.clef[0]);
            element.VerticalAlignment = VerticalAlignment.Center;
            element.Margin = new Thickness(fontSize * 2 / 3, 0, 0, 0);
            grid.Children.Add(element);
            left += fontSize * 2 / 3;

            //todo: render key signature
            element = RenderKeySignature();
            element.Margin = new Thickness(left, 0, 0, 0);
            grid.Children.Add(element);
            left += element.ActualWidth;

            //todo: render time signature
            element = RenderTimeSignature(attributes.time[staff], fontSize);
            element.VerticalAlignment = VerticalAlignment.Center;
            element.Margin = new Thickness(left, 0, 0, 0);
            grid.Children.Add(element);
            left += element.ActualWidth;

            WPFRendering.RecalculateSize(grid);
            return grid;
        }


        public static FrameworkElement RenderKeySignature()
        {
            //todo: render key signature properly
            return new Label();
        }

        /// <summary>
        /// Render the time signature to a Grid
        /// </summary>
        /// <param name="time">The time signature to render</param>
        /// <returns>Time signature on a grid</returns>
        public static FrameworkElement RenderTimeSignature(Time time, double fontSize)
        {
            double halfFont = fontSize / 2;
            //todo: make proper time signature label
            //todo: measure font size stuff properly
            Panel grid = WPFRendering.CreateAutoSizingGrid();
            grid.Children.Add(WPFRendering.GetMusicalLabel(time.Beats, halfFont));

            Label beatType = WPFRendering.GetMusicalLabel(time.BeatType, halfFont);
            beatType.Margin = new Thickness(0, WPFRendering.GetFontHeight(fontSize / 3, Constants.MusicFonts.MUSICA), 0, 0); //todo: font size and type properly
            grid.Children.Add(beatType);

            //todo: interchangable and other type of time signature, see definition of Time to hunt it down
            return grid;
        }

        /// <summary>
        /// Get a label for a clef
        /// </summary>
        /// <param name="clef">The clef to get the label for</param>
        /// <returns>A label of a clef</returns>
        public static Label RenderClef(Clef clef)
        {
            string symbol;
            switch (clef.sign)
            {
                case ClefSign.G:
                    symbol = Constants.Clefs.TREBLE;
                    break;
                case ClefSign.C:
                    symbol = Constants.Clefs.BASS;
                    break;
                    //todo: rest of clefs
                default:
                    symbol = "";
                    break;
            }

            Label clefLabel = WPFRendering.GetMusicalLabel(symbol); //todo: get the clef from getmusic label
            return clefLabel;
        }

        public static void RenderNoteModifier()
        {

        }

        public static void RenderNoteConnection()
        {

        }

        public static void RenderBarline()
        {

        }
    }
}
