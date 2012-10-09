using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary;
using NETScoreTranscriptionLibrary.XMLDeserialization;
using NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTNote
    {
        [XmlAttribute("default-x")]
        public int DefaultX { get; set; } //todo: proper tenths for many of these

        [XmlAttribute("default-y")]
        public int DefaultY { get; set; }

        [XmlAttribute("relative-x")]
        public int RelativeX { get; set; }

        [XmlAttribute("relative-y")]
        public int RelativeY { get; set; }

        [XmlAttribute("font-family")]
        public String FontFamily { get; set; }//todo: comma sep text

        [XmlAttribute("font-style")]
        public String FontStyle { get; set; }//todo: font style

        [XmlAttribute("font-size")]
        public String FontSize { get; set; }

        [XmlAttribute("font-weight")]
        public String FontWeight { get; set; }

        [XmlAttribute("color")]
        public String Color { get; set; } //todo: color

        [XmlAttribute("print-object")]
        public String PrintObject { get; set; }//todo: yes-no

        [XmlAttribute("print-dot")]
        public String PrintDot { get; set; }//todo: yes-no

        [XmlAttribute("print-spacing")]
        public String PrintSpacing { get; set; }//todo: yes-no

        [XmlAttribute("print-lyrics")]
        public String PrintLyrics { get; set; }//todo: yes-no

        [XmlAttribute("dynamics")]
        public int Dynamics { get; set; }//todo: non neg int

        [XmlAttribute("end-dynamics")]
        public int EndDynamics { get; set; }//todo: non neg int

        [XmlAttribute("attack")]
        public int Attack { get; set; }//todo: divisions

        [XmlAttribute("time-only")]
        public int TimeOnly { get; set; }//todo: time only

        [XmlAttribute("release")]
        public int Release { get; set; }//todo: non neg int

        [XmlAttribute("pizzicato")]
        private String _pizzicato { get; set; }

        [XmlIgnore]
        public bool Pizzicato
        {
            get { return _pizzicato == "yes"; }
            set { _pizzicato = (value) ? "yes" : "no"; }
        }

        [XmlElement("grace")]
        public String Grace { get; set; }//todo: grace enum type

        [XmlElement("chord")]
        public String Chord { get; set; }//todo: chord type

        [XmlElement("pitch")]
        public NSTPitch Pitch { get; set; }

        [XmlElement("unpitched")]
        public String Unpitched { get; set; }//todo: unpitched class (same as rest)

        [XmlElement("rest")]
        public NSTRest Rest { get; set; }//todo: unpitched class (same as unpitched)

        [XmlElement("tie")]
        public List<NSTTie> Tie { get; set; }//todo: tie enum and ensure not more than 2

        [XmlElement("cue")]
        public String Cut { get; set; }//todo: cue enum

        [XmlElement("duration")]
        public int Duration { get; set; }

        [XmlElement("type")]
        public String Type { get; set; } //todo: logic to make proper type of note

        [XmlElement("dot")]
        public String Dot { get; set; }//todo: dot

        [XmlElement("accidental")]
        public String Accidental { get; set; }//todo:

        [XmlElement("time-modification")]
        public String TimeModification { get; set; }//todo:

        //todo: note types

        [XmlElement("stem")]
        public string _stemDirection
        {
            get
            {
                if (StemDirection == DataTypes.UpDown.UP)
                    return "up";
                return "down";
            }
            set
            {
                if (value == "up")
                    StemDirection = DataTypes.UpDown.UP;
                else
                    StemDirection = DataTypes.UpDown.DOWN;
            }
        }

        [XmlIgnore]
        public NETScoreTranscriptionLibrary.DataTypes.UpDown StemDirection
        {
            get;
            set;
        }

        [XmlElement("notehead")]
        public String NoteHead { get; set; }//todo:

        //[XmlElement("time-modification")]
        //public String TimeModification { get; set; }//todo:type

        //[XmlElement("notehead-text")]
        //public int NoteheadText { get; set; }//todo: type

        [XmlElement("staff")]
        public NSTStaff Staff { get; set; }

        [XmlElement("beam")]
        public String Beam { get; set; }//todo:

        /*[XmlElement("notations")]
        public String Notations { get; set; }//todo: notations type*/

        /*[XmlElement("lyric")]
        public String Lyric { get; set; }//todo:lyric type */

        /*[XmlElement("play")]
        public String Play { get; set; }//todo: play type*/

        public NSTNote()
        {
            Tie = new List<NSTTie>();
        }
    }
}
