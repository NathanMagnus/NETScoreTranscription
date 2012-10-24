using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Schema;
using System.Xml.Serialization;
using NETScoreTranscription;
using NETScoreTranscriptionLibrary;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;
using NETScoreTranscriptionLibrary.Drawing;

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

                //ScorePartwise sp = ScorePartwise.Deserialize(testString1);
                ScorePartwise sp = ScorePartwise.LoadFromFile(@"C:\NM\NETScoreTranscription\MusicXMLSamples\BrahWiMeSample.xml");

                WPFRendering wpfmrLarge = new WPFRendering(100);
                FrameworkElement largeGrid = wpfmrLarge.RenderMeasure(sp.part[0].measure[0]);

                WPFRendering wpfmrBase = new WPFRendering(Constants.MusicFonts.DEFAULT_SIZE);
                FrameworkElement baseGrid = wpfmrBase.RenderMeasure(sp.part[0].measure[0]);

                WPFRendering wpfmrSmall = new WPFRendering(50);
                FrameworkElement smallGrid = wpfmrSmall.RenderMeasure(sp.part[0].measure[0]);

                WPFRendering wpfmrSmallest = new WPFRendering(25);
                FrameworkElement smallestGrid = wpfmrSmallest.RenderMeasure(sp.part[0].measure[0]);

                // put content on screen and into a grid
                Grid contentGrid = new Grid();
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());
                contentGrid.RowDefinitions.Add(new RowDefinition());

                Grid.SetRow(largeGrid, 0);
                Grid.SetRow(baseGrid, 1);
                Grid.SetRow(smallGrid, 2);
                Grid.SetRow(smallestGrid, 3);
                contentGrid.Children.Add(largeGrid);
                contentGrid.Children.Add(baseGrid);
                contentGrid.Children.Add(smallGrid);
                contentGrid.Children.Add(smallestGrid);

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
