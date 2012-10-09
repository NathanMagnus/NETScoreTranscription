using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTForward
    {
        [XmlElement("duration")]
        public Decimal Duration { get; set; }

        [XmlElement("footnote")]
        public NSTFootnote Footnote { get; set; }//todo:

        [XmlElement("level")]
        public String Level { get; set; }//todo:

        [XmlElement("voice")]
        public String Voice { get; set; }

        [XmlElement("staff")]
        public int Staff { get; set; }
    }
}
