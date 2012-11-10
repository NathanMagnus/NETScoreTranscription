using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "handbell-value")]
    public enum handbellvalue
    {
        /// <remarks />
        damp,

        /// <remarks />
        echo,

        /// <remarks />
        gyro,

        /// <remarks />
        [XmlEnum("hand martellato")] handmartellato,

        /// <remarks />
        [XmlEnum("mallet lift")] malletlift,

        /// <remarks />
        [XmlEnum("mallet table")] mallettable,

        /// <remarks />
        martellato,

        /// <remarks />
        [XmlEnum("martellato lift")] martellatolift,

        /// <remarks />
        [XmlEnum("muted martellato")] mutedmartellato,

        /// <remarks />
        [XmlEnum("pluck lift")] plucklift,

        /// <remarks />
        swing,
    }
}