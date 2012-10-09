using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTMidiInstrument
    {
        [XmlAttribute("id")]
        public String ID { get; set; }


    }
}
