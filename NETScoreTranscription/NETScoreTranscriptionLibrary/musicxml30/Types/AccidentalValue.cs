using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "accidental-value")]
    public enum AccidentalValue
    {
        /// <remarks />
        sharp,

        /// <remarks />
        natural,

        /// <remarks />
        flat,

        /// <remarks />
        [XmlEnum("double-sharp")] doublesharp,

        /// <remarks />
        [XmlEnum("sharp-sharp")] sharpsharp,

        /// <remarks />
        [XmlEnum("flat-flat")] flatflat,

        /// <remarks />
        [XmlEnum("natural-sharp")] naturalsharp,

        /// <remarks />
        [XmlEnum("natural-flat")] naturalflat,

        /// <remarks />
        [XmlEnum("quarter-flat")] quarterflat,

        /// <remarks />
        [XmlEnum("quarter-sharp")] quartersharp,

        /// <remarks />
        [XmlEnum("three-quarters-flat")] threequartersflat,

        /// <remarks />
        [XmlEnum("three-quarters-sharp")] threequarterssharp,

        /// <remarks />
        [XmlEnum("sharp-down")] sharpdown,

        /// <remarks />
        [XmlEnum("sharp-up")] sharpup,

        /// <remarks />
        [XmlEnum("natural-down")] naturaldown,

        /// <remarks />
        [XmlEnum("natural-up")] naturalup,

        /// <remarks />
        [XmlEnum("flat-down")] flatdown,

        /// <remarks />
        [XmlEnum("flat-up")] flatup,

        /// <remarks />
        [XmlEnum("triple-sharp")] triplesharp,

        /// <remarks />
        [XmlEnum("triple-flat")] tripleflat,

        /// <remarks />
        [XmlEnum("slash-quarter-sharp")] slashquartersharp,

        /// <remarks />
        [XmlEnum("slash-sharp")] slashsharp,

        /// <remarks />
        [XmlEnum("slash-flat")] slashflat,

        /// <remarks />
        [XmlEnum("double-slash-flat")] doubleslashflat,

        /// <remarks />
        [XmlEnum("sharp-1")] sharp1,

        /// <remarks />
        [XmlEnum("sharp-2")] sharp2,

        /// <remarks />
        [XmlEnum("sharp-3")] sharp3,

        /// <remarks />
        [XmlEnum("sharp-5")] sharp5,

        /// <remarks />
        [XmlEnum("flat-1")] flat1,

        /// <remarks />
        [XmlEnum("flat-2")] flat2,

        /// <remarks />
        [XmlEnum("flat-3")] flat3,

        /// <remarks />
        [XmlEnum("flat-4")] flat4,

        /// <remarks />
        sori,

        /// <remarks />
        koron,
    }
}