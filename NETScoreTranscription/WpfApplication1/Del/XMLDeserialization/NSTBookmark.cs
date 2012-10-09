using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTBookmark
    {
        [XmlAttribute("id")]
        public String ID { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("element")]
        public String Element { get; set; }

        [XmlAttribute("position")]
        public int Position { get; set; }//todo: position nst?
    }
}
