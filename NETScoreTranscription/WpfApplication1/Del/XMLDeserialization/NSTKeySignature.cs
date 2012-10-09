using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTKeySignature
    {
        [XmlElement("fifths")]
        public int Fifths { get; set; }//todo: nst class?
    }
}
