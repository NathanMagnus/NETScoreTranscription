using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTBackup
    {
        [XmlElement("duration")]
        public NSTDuration Duration { get; set; }

        [XmlElement("footnote")]
        public NSTFootnote Footnote { get; set; }

        [XmlElement("level")]
        public NSTLevel Level { get; set; }//todo:
    }
}
