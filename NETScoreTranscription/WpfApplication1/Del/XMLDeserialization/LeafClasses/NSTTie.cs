using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTTie : Leaf<String>
    {
        [XmlAttribute("type")]
        public String Type { get; set; }//todo

        [XmlAttribute("time-only")]
        public String TimeOnly { get; set; }//todo
    }
}
