﻿using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using NETScoreTranscriptionLibrary;
using NETScoreTranscriptionLibrary.Drawing;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                String testString1 = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n" +
                                    "<!DOCTYPE score-partwise PUBLIC\n" +
                                    "\"-//Recordare//DTD MusicXML 3.0 Partwise//EN\"\n" +
                                    "\"http://www.musicxml.org/dtds/partwise.dtd\">\n" +
                                    "<score-partwise version=\"3.0\">\n" +
                                    "<part-list><score-part id=\"P1\"><part-name>Music</part-name></score-part></part-list>" +
                                    "<part id=\"P1\"><measure number=\"1\">" +
                                    "<note><pitch><step>C</step><octave>4</octave></pitch><duration>4</duration><type>whole</type><stem>up</stem></note>" +
                                    "<attributes><divisions>1</divisions><key>" +
                                    "<fifths>0</fifths></key><time><beats>4</beats><beat-type>4</beat-type></time>" +
                                    "<clef><sign>G</sign><line>2</line></clef></attributes>" +
                                    "</measure></part></score-partwise>";

                bool onlyRenderOne = true; //todo: remove for regular debugging

                ScorePartwise sp = ScorePartwise.Deserialize(XMLStringFetcher.GetXMLFile("00-BasicPitches.xml"));
                Note v = sp.part[0].measure[0].Items[1] as Note;
                
                //ScorePartwise sp = ScorePartwise.Deserialize(XMLStringFetcher.GetXMLFile("BrahWiMeSample.xml"));
                //ScorePartwise sp = ScorePartwise.Deserialize(XMLStringFetcher.GetXMLFile("01a-Pitches-Pitches.xml"));
                //ScorePartwise sp = ScorePartwise.LoadFromFile(@"C:\Users\nathan\Documents\GitHub\NETScoreTranscription\NETScoreTranscription\NETScoreTranscriptionLibrary\MusicXMLSamples\BrahWiMeSample.xml");
                //ScorePartwise sp = ScorePartwise.LoadFromFile("");
                //ScorePartwise sp = ScorePartwise.Deserialize(testString1);

                WPFRendering wpfmrLarge = new WPFRendering(sp, new Size(400, 900), 100);
                FrameworkElement largeGrid = wpfmrLarge.RenderMeasure(sp.part[0].measure[0]);
                v.color = "#00FF00"; //todo: remove
                largeGrid = wpfmrLarge.RenderLine();
                //todo: figure out how to refresh without having to redraw everything
                WPFRendering wpfmrBase;
                WPFRendering wpfmrSmall;
                WPFRendering wpfmrSmallest;

                FrameworkElement baseGrid = new FrameworkElement();
                FrameworkElement smallGrid = new FrameworkElement();
                FrameworkElement smallestGrid = new FrameworkElement();
                if (!onlyRenderOne)
                {
                    wpfmrBase = new WPFRendering(sp, Constants.MusicFonts.DEFAULT_SIZE);
                    baseGrid = wpfmrBase.RenderLine();

                    wpfmrSmall = new WPFRendering(sp, 50);
                    smallGrid = wpfmrSmall.RenderLine();

                    wpfmrSmallest = new WPFRendering(sp, 25);
                    smallestGrid = wpfmrSmallest.RenderLine();
                }
                // put content on screen and into a grid
                Grid contentGrid = new Grid();
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());

                Grid.SetRow(largeGrid, 0);
                if (!onlyRenderOne)
                {
                    Grid.SetRow(baseGrid, 1);
                    Grid.SetRow(smallGrid, 2);
                    Grid.SetRow(smallestGrid, 3);
                }
                contentGrid.Children.Add(largeGrid);

                if (!onlyRenderOne)
                {
                    contentGrid.Children.Add(baseGrid);
                    contentGrid.Children.Add(smallGrid);
                    contentGrid.Children.Add(smallestGrid);
                }
                
                //set window stuff
                this.Content = contentGrid;
                this.Height = 900;
                this.Left = 0;
                this.Top = 0;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.ToString());
            }
        }
    }
}
