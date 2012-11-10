using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {
        /// <remarks />
        accent,

        /// <remarks />
        [XmlEnum("breath-mark")] breathmark,

        /// <remarks />
        caesura,

        /// <remarks />
        [XmlEnum("detached-legato")] detachedlegato,

        /// <remarks />
        doit,

        /// <remarks />
        falloff,

        /// <remarks />
        [XmlEnum("other-articulation")] otherarticulation,

        /// <remarks />
        plop,

        /// <remarks />
        scoop,

        /// <remarks />
        spiccato,

        /// <remarks />
        staccatissimo,

        /// <remarks />
        staccato,

        /// <remarks />
        stress,

        /// <remarks />
        [XmlEnum("strong-accent")] strongaccent,

        /// <remarks />
        tenuto,

        /// <remarks />
        unstress,
    }
}