using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.XMLDeserialization.ParentClasses;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTDirectionType
    {
        [XmlElement("rehersal")]
        public String Rehersal { get; set; }//todo

        [XmlElement("sengo")]
        public String Sengo { get; set; }//todo

        [XmlElement("words")]
        public String Words { get; set; }//todo

        [XmlElement("coda")]
        public String Coda { get; set; }//todo

        [XmlElement("wedge")]
        public String Wedge { get; set; }//todo

        [XmlElement("dynamics")]
        public String Dynamics { get; set; }//todo

        [XmlElement("dashes")]
        public String Dashes { get; set; }//todo

        [XmlElement("bracket")]
        public String Bracket { get; set; }//todo

        [XmlElement("pedal")]
        public String Pedal { get; set; }//todo

        [XmlElement("metronome")]
        public String Metronome { get; set; }//todo

        [XmlElement("octave-shift")]
        public String OctaveShift { get; set; }//todo

        [XmlElement("harp-pedals")]
        public String HarpPedals { get; set; }//todo

        [XmlElement("damp")]
        public String Damp { get; set; }//todo

        [XmlElement("damp-all")]
        public String DampAll { get; set; }//todo

        [XmlElement("eyeglasses")]
        public String Eyeglasses { get; set; }//todo

        [XmlElement("string-mute")]
        public String StringMute { get; set; }//todo

        [XmlElement("scordatura")]
        public String Scordatura { get; set; }//todo

        [XmlElement("image")]
        public String Image { get; set; }//todo

        [XmlElement("principal-voice")]
        public String PrincipalVoice { get; set; }//todo

        [XmlElement("accordion-registration")]
        public String AccordionRegistration { get; set; }//todo

        [XmlElement("percussion")]
        public String Percussion { get; set; }//todo

        [XmlElement("other-direction")]
        public String OtherDirection { get; set; }//todo
    }
}
