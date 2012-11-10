using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscription
{
    public class Clef
    {
        [XmlElement("sign")]
        public String Sign { get; set; }//todo: logic to make proper clef

        [XmlElement("line")]
        public int Line { get; set; }
    }
}
