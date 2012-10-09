using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTScoreCredit
    {
        [XmlAttribute("justify")]
        public String Justify { get; set; }//todo

        [XmlAttribute("default-x")]
        public String DefaultX { get; set; }//todo

        [XmlAttribute("default-y")]
        public String DefaultY { get; set; }//todo

        [XmlAttribute("relative-x")]
        public String RelativeX { get; set; }//todo

        [XmlAttribute("relative-y")]
        public String RelativeY { get; set; }//todo

        [XmlAttribute("font-family")]
        public String FontFamily { get; set; }//todo

        [XmlAttribute("font-style")]
        public String FontStyle { get; set; }//todo

        [XmlAttribute("font-size")]
        public String FontSize { get; set; }//todo

        [XmlAttribute("font-weight")]
        public String FontWeight { get; set; }//todo

        [XmlAttribute("color")]
        public String Color { get; set; }//todo

        [XmlAttribute("halign")]
        public String HorizontalAlignment { get; set; }//todo

        [XmlAttribute("valign")]
        public String VerticalAlignment { get; set; }//todo

        [XmlAttribute("underline")]
        public String Underline { get; set; }//todo

        [XmlAttribute("overline")]
        public String Overline { get; set; }//todo

        [XmlAttribute("line-through")]
        public String LineThrough { get; set; }//todo

        [XmlAttribute("rotation")]
        public String Rotation { get; set; }//todo

        [XmlAttribute("letter-spacing")]
        public String LetterSpacing { get; set; }//todo

        [XmlAttribute("line-height")]
        public String LineHeight { get; set; }//todo

        [XmlAttribute("dir")]
        public String Direction { get; set; }//todo

        [XmlAttribute("enclosure")]
        public String Enclosure { get; set; }//todo
    }
}
