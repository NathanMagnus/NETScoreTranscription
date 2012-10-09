using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTSound
    {
        [XmlAttribute("tempo")]
        public String Tempo { get; set; }//todo

        [XmlAttribute("dynamics")]
        public String Dynamics { get; set; }//todo

        [XmlAttribute("dacapo")]
        public String Dacapo { get; set; }//todo

        [XmlAttribute("segno")]
        public String Segno { get; set; }//todo

        [XmlAttribute("dalsegno")]
        public String Dalsegno { get; set; }//todo

        [XmlAttribute("coda")]
        public String Coda { get; set; }//todo

        [XmlAttribute("tocoda")]
        public String ToCoda { get; set; }//todo

        [XmlAttribute("divisions")]
        public String Divions { get; set; }//todo

        [XmlAttribute("forward-repeat")]
        public String ForwardRepeat { get; set; }//todo

        [XmlAttribute("fine")]
        public String Fine { get; set; }//todo

        [XmlAttribute("time-only")]
        public String TimeOnly { get; set; }//todo

        [XmlAttribute("pizzicato")]
        public String Pizzicato { get; set; }//todo

        [XmlAttribute("pan")]
        public String Pan { get; set; }//todo

        [XmlAttribute("elevation")]
        public String Elevation { get; set; }//todo

        [XmlAttribute("damper-pedal")]
        public String DamperPedal { get; set; }//todo

        [XmlAttribute("soft-pedal")]
        public String SoftPedal { get; set; }//todo

        [XmlAttribute("sostenuto-pedal")]
        public String SostenutoPedal { get; set; }//todo

        [XmlElement("midi-device")]
        public String MidiDevice { get; set; }//todo

        [XmlElement("midi-instrument")]
        public NSTMidiInstrument MidiInstrument { get; set; }//todo

        [XmlElement("play")]
        public NSTPlay Play { get; set; }

        [XmlElement("offset")]
        public String Offset { get; set; }//todo
    }
}
