using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    public enum Mute
    {
        /// <remarks />
        on,

        /// <remarks />
        off,

        /// <remarks />
        straight,

        /// <remarks />
        cup,

        /// <remarks />
        [XmlEnum("harmon-no-stem")] harmonnostem,

        /// <remarks />
        [XmlEnum("harmon-stem")] harmonstem,

        /// <remarks />
        bucket,

        /// <remarks />
        plunger,

        /// <remarks />
        hat,

        /// <remarks />
        solotone,

        /// <remarks />
        practice,

        /// <remarks />
        [XmlEnum("stop-mute")] stopmute,

        /// <remarks />
        [XmlEnum("stop-hand")] stophand,

        /// <remarks />
        echo,

        /// <remarks />
        palm,
    }
}