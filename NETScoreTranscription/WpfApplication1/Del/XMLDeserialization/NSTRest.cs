using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTRest
    {
        [XmlAttribute("measure")]
        private String _measure { get; set; }

        [XmlIgnore]
        public bool Measaure
        {
            get { return _measure == "yes"; }
            set { _measure = (value) ? "yes" : "no"; }
        }

        [XmlElement("display-step")]
        public NSTStep DisplayStep { get; set; }

        [XmlElement("display-octave")]
        public NSTOctave DisplayOctave { get; set; }
    }
}
