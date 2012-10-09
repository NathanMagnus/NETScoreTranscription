using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.DataTypes;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTPitch
    {
        [XmlElement("step")]
        public NSTStep Step { get; set; }

        [XmlElement("octave")]
        public NSTOctave Octave { get; set; }
    }
}
