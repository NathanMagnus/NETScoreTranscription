using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "kind-value")]
    public enum KindValue
    {
        /// <remarks />
        major,

        /// <remarks />
        minor,

        /// <remarks />
        augmented,

        /// <remarks />
        diminished,

        /// <remarks />
        dominant,

        /// <remarks />
        [XmlEnum("major-seventh")] majorseventh,

        /// <remarks />
        [XmlEnum("minor-seventh")] minorseventh,

        /// <remarks />
        [XmlEnum("diminished-seventh")] diminishedseventh,

        /// <remarks />
        [XmlEnum("augmented-seventh")] augmentedseventh,

        /// <remarks />
        [XmlEnum("half-diminished")] halfdiminished,

        /// <remarks />
        [XmlEnum("major-minor")] majorminor,

        /// <remarks />
        [XmlEnum("major-sixth")] majorsixth,

        /// <remarks />
        [XmlEnum("minor-sixth")] minorsixth,

        /// <remarks />
        [XmlEnum("dominant-ninth")] dominantninth,

        /// <remarks />
        [XmlEnum("major-ninth")] majorninth,

        /// <remarks />
        [XmlEnum("minor-ninth")] minorninth,

        /// <remarks />
        [XmlEnum("dominant-11th")] dominant11th,

        /// <remarks />
        [XmlEnum("major-11th")] major11th,

        /// <remarks />
        [XmlEnum("minor-11th")] minor11th,

        /// <remarks />
        [XmlEnum("dominant-13th")] dominant13th,

        /// <remarks />
        [XmlEnum("major-13th")] major13th,

        /// <remarks />
        [XmlEnum("minor-13th")] minor13th,

        /// <remarks />
        [XmlEnum("suspended-second")] suspendedsecond,

        /// <remarks />
        [XmlEnum("suspended-fourth")] suspendedfourth,

        /// <remarks />
        Neapolitan,

        /// <remarks />
        Italian,

        /// <remarks />
        French,

        /// <remarks />
        German,

        /// <remarks />
        pedal,

        /// <remarks />
        power,

        /// <remarks />
        Tristan,

        /// <remarks />
        other,

        /// <remarks />
        none,
    }
}