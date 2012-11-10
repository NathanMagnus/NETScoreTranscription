using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "note-type-value")]
    public enum NoteTypeValue
    {
        /// <remarks />
        [XmlEnum("1024th")] Item1024th,

        /// <remarks />
        [XmlEnum("512th")] Item512th,

        /// <remarks />
        [XmlEnum("256th")] Item256th,

        /// <remarks />
        [XmlEnum("128th")] Item128th,

        /// <remarks />
        [XmlEnum("64th")] Item64th,

        /// <remarks />
        [XmlEnum("32nd")] Item32nd,

        /// <remarks />
        [XmlEnum("16th")] Item16th,

        /// <remarks />
        eighth,

        /// <remarks />
        quarter,

        /// <remarks />
        half,

        /// <remarks />
        whole,

        /// <remarks />
        breve,

        /// <remarks />
        @long,

        /// <remarks />
        maxima,
    }
}