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
        public static FrameworkElement ParseNote(Note note)
        {
            //todo: likely remove this whole function because will need to draw own notes due to stem when beaming
            Console.Out.WriteLine("Note");
            String noteChar = Constants.NoteCharacters.WHOLE_NOTE; //todo: decide on default
            FrameworkElement noteHead = null;
            
            //todo: if it has a rest, then parse as rest, otherwise parse as note

            if (string.IsNullOrEmpty(note.color))
                note.color = Constants.Colors.DEFAULT_NOTE_COLOR;
            Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(note.color));

            switch (note.type.Value)
            {
                case NoteTypeValue.whole:
                    noteChar = Constants.NoteCharacters.WHOLE_NOTE;
                    break;
                case NoteTypeValue.half:
                    noteChar = Constants.NoteCharacters.HALF_NOTE;
                    break;
                case NoteTypeValue.quarter:
                    noteHead = new Ellipse() { Fill = brush }; //todo: size properly
                    noteChar = Constants.NoteCharacters.QUARTER_NOTE;
                    break;
                case NoteTypeValue.eighth:
                    noteChar = Constants.NoteCharacters.EIGHTH_NOTE;
                    break;
                case NoteTypeValue.Item16th:
                    noteChar = Constants.NoteCharacters.SIXTEETH_NOTE;
                    break;
                case NoteTypeValue.Item32nd:
                    noteChar = Constants.NoteCharacters.THIRTYSECOND_NOTE;
                    break;
                case NoteTypeValue.Item64th:
                    noteChar = Constants.NoteCharacters.SIXTYFOURTH_NOTE;
                    break;
                case NoteTypeValue.Item128th:
                    noteChar = Constants.NoteCharacters.ONETWENTYEIGHTH_NOTE;
                    break;
                case NoteTypeValue.Item256th:
                    noteChar = "!";
                    break;
                case NoteTypeValue.Item512th:
                    noteChar = "!";
                    break;
            }

            //Label noteLabel = WPFRendering.GetMusicalLabel(noteChar);
            noteHead.Height = 10;
            noteHead.Width = noteHead.Height * 3 / 2;

            WPFRendering.RecalculateSize(noteHead);
            return noteHead;
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
            return barlineLabel;
        }

        /// <summary>
        /// Render a measure onto a canvas
        /// </summary>
        /// <param name="measure">The measure to render</param>
        /// <returns>A canvas with the measure rendered onto it</returns>
        public static Canvas RenderMeasure(ScorePartwisePartMeasure measure) //todo: not return canvas
        {
            //todo: stack/queue for tie
            //todo: stack/queue for slur
            //todo: stack/queue for beam

            ICollection<object> itemList = measure.Items;
            Canvas c = new Canvas(); //todo: remove canvas
            double left = 90; //todo: padding/margin
            double top = 50; //todo: padding/margin

            //todo: render staff

            //todo: render each item
            for (int i = 0; i < itemList.Count; i++)
            {
                object obj = itemList.ElementAt(i);
                Type type = obj.GetType();
                FrameworkElement element = null;

                if (type == typeof(Attributes))
                {
                    Attributes attributes = (Attributes)obj;

                    element = RenderAttributes(attributes);
                }
                else if (type == typeof(Note))
                {
                    Note note = (Note)obj;
                    element = ParseNote(note);

                    //todo: figure out if should be rotated and rotate appropriately
                    //(element as Label).Background = Brushes.Aqua;
                    RotateTransform rt = new RotateTransform();
                    rt.Angle = -20;
                    element.LayoutTransform = rt;
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
                    c.Children.Add(element);
                    left += element.ActualWidth + 0; //todo: margin
                }
                else
                {
                    throw new NullMeasureElementException("Null element: " + obj.GetType() + "\n");
                }
            }

            WPFRendering.RecalculateSize(c);
            return c;
        }


        /// <summary>
        /// Render the attributes of a measure
        /// </summary>
        /// <param name="attributes">The attributes object to render</param>
        /// <param name="c">The canvas to render onto</param>
        /// <returns>A canvas with the attributes of a measure rendered onto it</returns>
        private static Canvas RenderAttributes(Attributes attributes)
        {
            Canvas c = new Canvas();

            // lef and right for elements within
            double left = 0;
            double top = 0;

            //todo: render multiple clefs because of multi-line parts
            Label clefLabel = ParseClef(attributes.clef[0]);
            clefLabel.Background = Brushes.Orange;
            clefLabel.Margin = new Thickness(left, top, 0, 0);
            c.Children.Add(clefLabel);

            //todo: render time signature


            //todo: render key signature


            WPFRendering.RecalculateSize(c);
            return c;
        }

        public static void RenderKeySignature()
        {
            //todo: draw based on line
        }

        public static void RenderTimeSignature()
        {

        }

        /// <summary>
        /// Get a label for a clef
        /// </summary>
        /// <param name="clef">The clef to get the label for</param>
        /// <returns>A label of a clef</returns>
        public static Label ParseClef(Clef clef)
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

        public static void RenderNote()
        {
            //todo: Render the note
            //todo: Render modifiers
            //todo: Render appropriate connectors
            //todo: render barline
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
