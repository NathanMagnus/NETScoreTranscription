using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscription;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTAttributes
    {
        [XmlElement("divisions")]
        public NSTDivisions Divisions { get; set; }

        [XmlElement("key")]
        public NSTKeySignature Key { get; set; }

        [XmlElement("time")]
        public NSTTimeSignature Time { get; set; }

        [XmlElement("clef")]
        public Clef Clef { get; set; }//todo: clef?
    }
}
