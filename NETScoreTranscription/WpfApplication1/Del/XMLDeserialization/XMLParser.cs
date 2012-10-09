using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.DataTypes;
using NETScoreTranscription;
using System.Xml;
using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.Interfaces;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    using Divisions = Decimal;
    using FontSize = Decimal;

    public class XMLParser : IParser
    {
        Range<int> beamLevel = new Range<int>(Constants.BeamLevel.MIN, Constants.BeamLevel.MAX);
        Range<int> midi16 = new Range<int>(Constants.MIDI16.MIN, Constants.MIDI16.MAX);
        Range<int> midi128 = new Range<int>(Constants.MIDI128.MIN, Constants.MIDI128.MAX);
        Range<int> midi16384 = new Range<int>(Constants.MIDI16384.MIN, Constants.MIDI16384.MAX);
        Range<decimal> nonNegativeDecimal = new Range<decimal>(0, decimal.MaxValue);
        Range<decimal> positiveDecimal = new Range<decimal>(0, decimal.MaxValue);
        Range<Divisions> positiveDivisions = new Range<Divisions>(0, Divisions.MaxValue);
        Range<Decimal> rotationDegrees = new Range<Decimal>(Constants.RotationDegrees.MIN, Constants.RotationDegrees.MAX);
        Range<int> positiveInteger = new Range<int>(0, int.MaxValue);
        Range<Decimal> tenths = new Range<Decimal>(Decimal.MinValue, Decimal.MaxValue);
        Range<Decimal> trillBeats = new Range<Decimal>(Constants.TrillBeats.MIN, Decimal.MaxValue);

        Range<int> numberLevel = new Range<int>(Constants.NumberLevel.MIN, Constants.NumberLevel.MAX);
        Range<int> numberOfLines = new Range<int>(Constants.NumberOfLines.MIN, Constants.NumberOfLines.MAX);
        Range<decimal> percent = new Range<decimal>(0, 100);

        NumberOrNormal normalOrNumber = new NumberOrNormal();

        MusicXMLString xmlColor = new MusicXMLString(5, 9);
        Divisions divisions;
        FontSize fontSize;
        //todo: time only, comma separated list

        ScoreObject root;

        public NSTScorePartwise ParseFile(string fileName)
        {
            //todo: load file
            //todo: parse string
            throw new NotImplementedException();
        }

        public void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            // todo: handle XML error here
            throw new Exception(args.Message);
            
        }


        public NSTScorePartwise ParseString(string dataString)
        {
            //todo: parse string
            IList<NSTPart> partList = new List<NSTPart>();
            XmlTextReader textReader = new XmlTextReader(new FileStream("C:\\NM\\ScoreTranscription\\NETScoreTranscription\\NETScoreTranscriptionLibrary\\OtherDocs\\musicXML.xsd", System.IO.FileMode.Open)); //todo: pass stream in instead of absolute location for unit testing
            XmlSchemaCollection schemaCollection = new XmlSchemaCollection();
            schemaCollection.Add(null, textReader);
            
            NSTScorePartwise score;
             
            using (XmlValidatingReader reader = new XmlValidatingReader(XmlReader.Create(new StringReader(dataString), new XmlReaderSettings() { DtdProcessing = DtdProcessing.Parse }))) //todo: make unobsolete
            {
                reader.Schemas.Add(schemaCollection);
                reader.ValidationType = ValidationType.Schema;
                reader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(ValidationEventHandler);

                XmlSerializer serializer = new XmlSerializer(typeof(NSTScorePartwise), new XmlRootAttribute("score-partwise"));
                score = (NSTScorePartwise)serializer.Deserialize(reader);



                /*
                while (reader.Read())
                {
                    if (reader.IsEmptyElement)
                        throw new Exception(reader.Value); //todo: test

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name.ToLower())
                            {
                                case "part-list":
                                    break;
                                case "score-partwise":
                                    break;
                                case "part-name":
                                    throw new Exception("pn");
                                    break;
                            }
                            break;
                        case XmlNodeType.Text:

                            break;
                        case XmlNodeType.XmlDeclaration:
                        case XmlNodeType.ProcessingInstruction:

                            break;
                        case XmlNodeType.Comment:

                            break;
                        case XmlNodeType.EndElement:

                            break;
                    }
                }*/
            }


            return score;
        }
    }
}
