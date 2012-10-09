using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTPartInfo
    {
        [XmlElement("part-group")]
        public String PartGroup { get; set; }//todo: nst t ype?

        [XmlElement("score-part")]
        public List<NSTScorePart> ScorePartInformation { get; set; }

        public override string ToString()
        {
            int startDepth = PropertyGenerator.depth;
            String x = "";
            Type myType = (typeof(NSTPartInfo));

            x += PropertyGenerator.GeneratePropertiesString(myType, this);
            if (startDepth != PropertyGenerator.depth)
                throw new Exception(String.Format("Start {0}, End {1}", startDepth, PropertyGenerator.depth)); //todo: give this a exepction type
            return x;
        }
    }
}
