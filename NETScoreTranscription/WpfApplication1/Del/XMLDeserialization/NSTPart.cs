using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscription;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTPart
    {
        [XmlAttribute("id")]
        public String ID { get; set; }

        [XmlElement("measure")]
        public List<NSTMeasure> Measures { get; set; }

        public NSTPart()
        {
            Measures = new List<NSTMeasure>();
        }

        public override string ToString()
        {
            int startDepth = PropertyGenerator.depth;
            String x = "";
            Type myType = (typeof(NSTPart));

            x += PropertyGenerator.GeneratePropertiesString(myType, this);
            if (startDepth != PropertyGenerator.depth)
                throw new Exception(String.Format("{0} - Start {1}, End {2}", this.GetType(), startDepth, PropertyGenerator.depth)); //todo: give this a exepction type
            return x;
        }
    }
}
