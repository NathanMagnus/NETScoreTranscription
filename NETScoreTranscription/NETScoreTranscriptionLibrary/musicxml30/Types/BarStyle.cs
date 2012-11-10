using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "bar-style")]
    public enum BarStyle
    {
        /// <remarks />
        regular,

        /// <remarks />
        dotted,

        /// <remarks />
        dashed,

        /// <remarks />
        heavy,

        /// <remarks />
        [XmlEnum("light-light")] lightlight,

        /// <remarks />
        [XmlEnum("light-heavy")] lightheavy,

        /// <remarks />
        [XmlEnum("heavy-light")] heavylight,

        /// <remarks />
        [XmlEnum("heavy-heavy")] heavyheavy,

        /// <remarks />
        tick,

        /// <remarks />
        @short,

        /// <remarks />
        none,
    }
}