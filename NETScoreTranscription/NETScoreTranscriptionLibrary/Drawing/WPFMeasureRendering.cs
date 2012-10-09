﻿using System;
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
        public static FrameworkElement RenderNoteOrRest(Note note)
        {
            //todo: Render appropriate connectors
            //todo: render barline

            //todo: likely remove this whole function because will need to draw own notes due to stem when beaming
            Console.Out.WriteLine("Note");
            String noteChar = Constants.NoteCharacters.WHOLE_NOTE; //todo: decide on default
            Grid grid = new Grid(); //todo: put this on a canvas so can put stem and modifiers onto same canvas
            FrameworkElement noteHead = null;

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
                Grid noteGrid = new Grid();
                noteHead = RenderNote(note);

                noteGrid.Children.Add(noteHead);
                noteGrid.Children.Add(new System.Windows.Shapes.Line()
                    { 
                        X1 = noteHead.ActualWidth,
                        X2 = noteHead.ActualWidth,
                        Y1 = noteHead.ActualHeight / 2,
                        Y2 = noteHead.ActualHeight / 2 - 30,
                        StrokeThickness = 2, //todo: thickness same as staff
                        Stroke = new SolidColorBrush((Color)ColorConverter.ConvertFromString(note.color))
                    });
                
                //todo: if is above half of the staff, rotate so everything points down
                // rotate head
                //RotateTransform rt = new RotateTransform();
                //rt.Angle = 180;
                //noteGrid.LayoutTransform = rt;


                WPFRendering.RecalculateSize(noteGrid);
                grid.Children.Add(noteGrid);
            }
            else
            {
                noteHead = RenderRest(note);
                grid.Children.Add(noteHead);
            }

            WPFRendering.RecalculateSize(grid);
            return grid;
        }

        /// <summary>
        /// Render a note.
        /// </summary>
        /// <param name="note">Information for the note to render</param>
        /// <returns>A note rendered on a Fraemwork Element</returns>
        private static FrameworkElement RenderNote(Note note)
        {
            String noteChar = "";
            FrameworkElement noteHead = new Grid();

            if (string.IsNullOrEmpty(note.color))
                note.color = Constants.Colors.DEFAULT_NOTE_COLOR;
            Brush brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString(note.color));

            switch (note.type.Value)
            {
                //todo: size note heads using width expected for font
                case NoteTypeValue.whole:
                    noteChar = Constants.NoteCharacters.WHOLE_NOTE;
                    break;
                case NoteTypeValue.half:
                    noteChar = Constants.NoteCharacters.HALF_NOTE;
                    break;
                case NoteTypeValue.quarter:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 };
                    noteChar = Constants.NoteCharacters.QUARTER_NOTE;
                    break;
                case NoteTypeValue.eighth:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 }; //todo: vars for vals
                    noteChar = Constants.NoteCharacters.EIGHTH_NOTE;
                    break;
                case NoteTypeValue.Item16th:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 };
                    noteChar = Constants.NoteCharacters.SIXTEETH_NOTE;
                    break;
                case NoteTypeValue.Item32nd:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 };
                    noteChar = Constants.NoteCharacters.THIRTYSECOND_NOTE;
                    break;
                case NoteTypeValue.Item64th:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 };
                    noteChar = Constants.NoteCharacters.SIXTYFOURTH_NOTE;
                    break;
                case NoteTypeValue.Item128th:
                    noteHead = new Ellipse() { Fill = brush, Height = 10, Width = 10 * 3 / 2 };
                    noteChar = Constants.NoteCharacters.ONETWENTYEIGHTH_NOTE;
                    break;
                case NoteTypeValue.Item256th:
                    noteChar = "!";
                    break;
                case NoteTypeValue.Item512th:
                    noteChar = "!";
                    break;
            }

            //todo: figure out how to slant note heads just a bit
            // rotate head
            //RotateTransform rt = new RotateTransform();
            //rt.Angle = -20;
            //noteHead.LayoutTransform = rt;

            WPFRendering.RecalculateSize(noteHead);
            //todo: Render modifiers

            return noteHead;
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
            return barlineLabel;
        }

        /// <summary>
        /// Render a measure onto a canvas
        /// </summary>
        /// <param name="measure">The measure to render</param>
        /// <returns>A Framework Element with the measure rendered onto it</returns>
        public static Grid RenderMeasure(ScorePartwisePartMeasure measure) //todo: not return canvas
        {
            //todo: stack/queue for tie
            //todo: stack/queue for slur
            //todo: stack/queue for beam

            ICollection<object> itemList = measure.Items;
            Grid grid = new Grid();

            double left = 90; //todo: padding/margin
            double top = 50; //todo: padding/margin

            //todo: render staff
            grid = RenderStaff(grid);

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

            WPFRendering.RecalculateSize(grid);
            return grid;
        }

        private static Grid RenderStaff(Grid grid)
        {
            //todo: implement
            //get the height of the staff for the font and use that to draw the lines.


            return grid;
        }


        /// <summary>
        /// Render the attributes of a measure
        /// </summary>
        /// <param name="attributes">The attributes object to render</param>
        /// <param name="c">The canvas to render onto</param>
        /// <returns>A canvas with the attributes of a measure rendered onto it</returns>
        private static Grid RenderAttributes(Attributes attributes)
        {
            Grid grid = new Grid();

            // lef and right for elements within
            double left = 0;
            double top = 0;

            //todo: render multiple clefs because of multi-line parts
            Label clefLabel = ParseClef(attributes.clef[0]);
            clefLabel.Margin = new Thickness(left, top, 0, 0);
            grid.Children.Add(clefLabel);

            //todo: render time signature


            //todo: render key signature


            WPFRendering.RecalculateSize(grid);
            return grid;
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
