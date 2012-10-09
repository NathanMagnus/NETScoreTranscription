using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTDirective : Leaf<Boolean>
    {
        [XmlIgnore]
        public String Directive
        {
            get { return (Value) ? "yes" : "no"; }
            set { Value = (value == "yes") ? true : false; }
        }
    }
}
