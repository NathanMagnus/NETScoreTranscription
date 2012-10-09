using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscription;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTMeasure
    {
        [XmlAttribute("number")]
        public int Number { get; set; }

        [XmlAttribute("implicit")]
        private String _implicit { get; set; }

        [XmlIgnore]
        public bool Implicit
        {
            get { return (_implicit == "yes"); }
            set
            {
                if (value) { _implicit = "yes"; }
                else
                {
                    _implicit = "no";
                }
            }
        }

        [XmlAttribute("non-controlling")]
        private String _nonControlling { get; set; }

        [XmlIgnore]
        public bool NonControlling
        {
            get { return (_nonControlling == "yes"); }
            set
            {
                if (value) { _nonControlling = "yes"; }
                else
                {
                    _nonControlling = "no";
                }
            }
        }
            

        [XmlAttribute("width")]
        public String Width { get; set; } //todo: change to tenths

        [XmlElement("note")]
        public List<NSTNote> Notes { get; set; }

        [XmlElement("backup")]
        public NSTBackup Backup { get; set; }

        [XmlElement("forward")]
        public NSTForward Forward { get; set; }

        [XmlElement("direction")]
        public NSTDirection Direction { get; set; }

        [XmlElement("attributes")]
        public NSTAttributes Attributes { get; set; }

        /*
        [XmlElement("attributes")]
        [XmlElement("harmony")]
        [XmlElement("figured-bass")]
        [XmlElement("print")]
        [XmlElement("sound")]
        [XmlElement("barline")]
        [XmlElement("grouping")]
        */

        [XmlElement("link")]
        public NSTLink Link { get; set; }//todo:

        [XmlElement("bookmark")]
        public NSTBookmark Bookmark { get; set; }

        public NSTMeasure()
        {
            Notes = new List<NSTNote>();
        }
    }
}
