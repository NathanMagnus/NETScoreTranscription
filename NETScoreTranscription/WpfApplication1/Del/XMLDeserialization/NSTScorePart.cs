using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTScorePart
    {
        [XmlAttribute("id")]
        public String ID { get; set; }

        [XmlElement("identification")]
        public String Identification { get; set; }//todo: nst type?

        [XmlElement("part-name")]
        public String PartName { get; set; }//todo: nst type?

        [XmlElement("part-name-display")]
        public String PartNameDisplay { get; set; }//todo: nst type?

        [XmlElement("part-abbreviation")]
        public String PartAbbreviation { get; set; }//todo: nst type?

        [XmlElement("part-abbreviation-display")]
        public String PartAbbreviationDisplay { get; set; }//todo: nst type?

        [XmlElement("group")]
        public String Group { get; set; }//todo: nst type?

        [XmlElement("score-instrument")]
        public String ScoreInstrument { get; set; }//todo: nst type?

        [XmlElement("midi-device")]
        public String MIDIDevice { get; set; }//todo: nst type?

        [XmlElement("midi-instrument")]
        public String MIDIInstrument { get; set; }//todo: nst type?

        public override string ToString()
        {
            int startDepth = PropertyGenerator.depth;
            String x = "";
            Type myType = (typeof(NSTScorePart));

            x += PropertyGenerator.GeneratePropertiesString(myType, this);
            if (startDepth != PropertyGenerator.depth)
                throw new Exception(String.Format("{0} - Start {1}, End {2}", this.GetType(), startDepth, PropertyGenerator.depth)); //todo: give this a exepction type
            return x;
        }
    }
}
