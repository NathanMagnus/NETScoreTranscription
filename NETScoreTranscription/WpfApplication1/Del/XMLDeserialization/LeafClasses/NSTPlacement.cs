using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.DataTypes;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTPlacement : Leaf<string>
    {
        /*[XmlIgnore]
        public AboveBelow Placement
        {
            get { return (Value.ToLower() == "above") ? AboveBelow.ABOVE : AboveBelow.BELOW; }
            set { Value = (value == AboveBelow.ABOVE) ? "above" : "below"; }
        }*/
    }
}
