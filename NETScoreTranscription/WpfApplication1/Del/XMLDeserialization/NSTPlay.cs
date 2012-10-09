using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTPlay
    {
        [XmlAttribute("id")]
        public String ID { get; set; }

        [XmlElement("ipa")]
        public NSTIpa IPA { get; set; }

        [XmlElement("mute")]
        public String Mute { get; set; }//todo:

        [XmlElement("semi-pitched")]
        public String SemiPitched { get; set; }//todo:

        [XmlElement("other-play")]
        public String OtherPlay { get; set; }//todo:
    }
}
