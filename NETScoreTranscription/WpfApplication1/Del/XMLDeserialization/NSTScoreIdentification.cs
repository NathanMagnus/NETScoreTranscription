using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTScoreIdentification
    {
        [XmlElement("creator")]
        public String Creator { get; set; } //todo:

        [XmlElement("rights")]
        public String Rights { get; set; } //todo:

        [XmlElement("encoding")]
        public String Encoding { get; set; }//todo:

        [XmlElement("source")]
        public String Source { get; set; }

        [XmlElement("relation")]
        public String Relation { get; set; }

        [XmlElement("miscellaneous")]
        public String Miscellaneous { get; set; }//todo:
    }
}
