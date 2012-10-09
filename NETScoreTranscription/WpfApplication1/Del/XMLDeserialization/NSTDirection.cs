using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;
using NETScoreTranscriptionLibrary.DataTypes;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTDirection
    {
        [XmlAttribute("placement")]
        private String _placement { get; set; }

        [XmlIgnore]
        public AboveBelow Placement
        {
            get { return (_placement.ToLower() == "above") ? AboveBelow.ABOVE : AboveBelow.BELOW; }
            set { _placement = (value == AboveBelow.ABOVE) ? "above" : "below"; }
        }

        [XmlAttribute("directive")]
        public String _directive { get; set; }

        [XmlIgnore]
        public Boolean Directive
        {
            get { return (_directive == "yes"); }
            set { _directive = (value) ? "yes" : "no"; }
        }

        [XmlElement("direction-type")]
        public NSTDirectionType DirectionType { get; set; }

        [XmlElement("offset")]
        public String Offset { get; set; }//todo:

        [XmlElement("footnote")]
        public NSTFootnote Footnote { get; set; }

        [XmlElement("level")]
        public NSTLevel Level { get; set; }

        [XmlElement("voice")]
        public NSTVoice Voice { get; set; }

        [XmlElement("staff")]
        public NSTStaff Staff { get; set; }

        [XmlElement("sound")]
        public NSTSound Sound { get; set; }//todo:
    }
}
