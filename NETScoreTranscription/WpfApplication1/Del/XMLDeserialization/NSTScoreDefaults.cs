using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.XMLDeserialization
{
    public class NSTScoreDefaults
    {
        [XmlElement("scaling")]
        public String Scaling { get; set; }//todo:

        [XmlElement("page-layout")]
        public String PageLayout { get; set; }//todo:

        [XmlElement("system-layout")]
        public String SystemLayout { get; set; }//todo:

        [XmlElement("appearance")]
        public String Appearance { get; set; }//todo:

        [XmlElement("music-font")]
        public String MusicFont { get; set; }//todo:

        [XmlElement("word-font")]
        public String WordFont { get; set; }//todo:

        [XmlElement("lyric-font")]
        public String LyricFont { get; set; }//todo:

        [XmlElement("lyric-language")]
        public String LyricLanguage { get; set; }//todo:
    }
}
