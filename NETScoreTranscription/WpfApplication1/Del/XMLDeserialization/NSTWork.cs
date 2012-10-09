using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTWork
    {
        [XmlElement("work-number")]
        public String WorkNumber { get; set; }

        [XmlElement("work-title")]
        public String WorkTitle { get; set; }

        [XmlElement("opus")]
        public NSTOpus Opus { get; set; }
    }
}
