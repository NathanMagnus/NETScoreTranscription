using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTTimeSignature
    {
        [XmlElement("beats")]
        public int Beats { get; set; }//todo: nst type?

        [XmlElement("beat-type")]
        public int BeatType { get; set; }//todo: decide if should do additional logic to assign it better at this point
    }
}
