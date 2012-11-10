using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "semi-pitched")]
    public enum SemiPitched
    {
        /// <remarks />
        high,

        /// <remarks />
        [XmlEnum("medium-high")] mediumhigh,

        /// <remarks />
        medium,

        /// <remarks />
        [XmlEnum("medium-low")] mediumlow,

        /// <remarks />
        low,

        /// <remarks />
        [XmlEnum("very-low")] verylow,
    }
}