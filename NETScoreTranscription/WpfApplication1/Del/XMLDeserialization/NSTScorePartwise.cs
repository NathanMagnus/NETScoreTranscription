using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;
using System.Collections;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTScorePartwise
    {
        [XmlAttribute("version")]
        public String Version { get; set; }

        [XmlElement("work")]
        public NSTWork Work { get; set; }//todo:

        [XmlElement("movement-number")]
        public String MovementNumber { get; set; }

        [XmlElement("movement-title")]
        public String MovementTitle { get; set; }

        [XmlElement("identification")]
        public NSTScoreIdentification Identification { get; set; }

        [XmlElement("defaults")]
        public NSTScoreDefaults Defaults { get; set; }

        [XmlElement("credit")]
        public NSTScoreCredit Credit { get; set; }

        [XmlElement("part-list")]
        public List<NSTPartInfo> partListInfo { get; set; }

        [XmlElement("part")]
        public List<NSTPart> partList { get; set; }

        public NSTScorePartwise()
        {
            partList = new List<NSTPart>();
            partListInfo = new List<NSTPartInfo>();
        }

        public override string ToString()
        {
            int startDepth = PropertyGenerator.depth;
            String x = "Score Partwise";
            Type myType = (typeof(NSTScorePartwise));

            x += PropertyGenerator.GeneratePropertiesString(myType, this);
            if (startDepth != PropertyGenerator.depth)
                throw new Exception(String.Format("{0} - Start {1}, End {2}", this.GetType(), startDepth, PropertyGenerator.depth)); //todo: give this a exepction type
            return x;
        }


        private bool HasValue(string s)
        {
            s = s.Trim();
            return (s != null && s != "");
        }
    }
}
