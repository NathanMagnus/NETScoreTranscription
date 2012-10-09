using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.ParentClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTLink : NSTTextAttributes
    {
        [XmlAttribute("href")]
        public String Href { get; set; }//todo

        [XmlAttribute("type")]
        public String Type { get; set; }//todo

        [XmlAttribute("role")]
        public String Role { get; set; }//todo

        [XmlAttribute("title")]
        public String Title { get; set; }//todo

        [XmlAttribute("show")]
        public String Show { get; set; }//todo

        [XmlAttribute("actuate")]
        public String Actuate { get; set; }//todo

        [XmlAttribute("name")]
        public String Name { get; set; }//todo

        [XmlAttribute("element")]
        public String Element { get; set; }//todo

        [XmlAttribute("position")]
        public String Position { get; set; }//todo

        [XmlAttribute("default-x")]
        public String DefaultX { get; set; }//todo

        [XmlAttribute("default-y")]
        public String DefaultY { get; set; }//todo

        [XmlAttribute("relative-x")]
        public String RelativeX { get; set; }//todo

        [XmlAttribute("relative-y")]
        public String RelativeY { get; set; }//todo
    }
}
