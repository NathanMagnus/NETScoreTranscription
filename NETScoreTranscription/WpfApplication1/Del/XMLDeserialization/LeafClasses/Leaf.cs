using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class Leaf<T>
    {
        [XmlText]
        virtual public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
