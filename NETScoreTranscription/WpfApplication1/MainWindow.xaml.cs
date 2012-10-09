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

                WPFRendering wpfmr = new WPFRendering();
                Canvas c = wpfmr.RenderMeasure(sp.part[0].measure[0]);
                Console.Out.WriteLine(c.Width);
                Console.Out.WriteLine(c.ActualWidth);
                this.Content = c;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.ToString());
            }
        }

        public void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            // todo: handle XML error here
            throw new Exception(args.Message);

        }
    }
}
