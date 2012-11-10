using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {
        /// <remarks />
        [XmlEnum("accidental-mark")] accidentalmark,

        /// <remarks />
        [XmlEnum("delayed-inverted-turn")] delayedinvertedturn,

        /// <remarks />
        [XmlEnum("delayed-turn")] delayedturn,

        /// <remarks />
        [XmlEnum("inverted-mordent")] invertedmordent,

        /// <remarks />
        [XmlEnum("inverted-turn")] invertedturn,

        /// <remarks />
        mordent,

        /// <remarks />
        [XmlEnum("other-ornament")] otherornament,

        /// <remarks />
        schleifer,

        /// <remarks />
        shake,

        /// <remarks />
        tremolo,

        /// <remarks />
        [XmlEnum("trill-mark")] trillmark,

        /// <remarks />
        turn,

        /// <remarks />
        [XmlEnum("vertical-turn")] verticalturn,

        /// <remarks />
        [XmlEnum("wavy-line")] wavyline,
    }
}