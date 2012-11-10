using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    public enum Winged
    {
        /// <remarks />
        none,

        /// <remarks />
        straight,

        /// <remarks />
        curved,

        /// <remarks />
        [XmlEnum("double-straight")] doublestraight,

        /// <remarks />
        [XmlEnum("double-curved")] doublecurved,
    }
}