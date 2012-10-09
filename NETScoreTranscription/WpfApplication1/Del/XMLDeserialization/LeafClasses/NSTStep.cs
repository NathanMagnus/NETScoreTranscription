using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using NETScoreTranscriptionLibrary.DataTypes;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.LeafClasses
{
    public class NSTStep : Leaf<String>
    {
        [XmlIgnore]
        public NoteLetters Step
        {
            get
            {
                NoteLetters returnVal;
                switch (Value.ToLower())
                {
                    case "a":
                        returnVal = NoteLetters.A;
                        break;
                    case "b":
                        returnVal = NoteLetters.B;
                        break;
                    case "c":
                        returnVal = NoteLetters.C;
                        break;
                    case "d":
                        returnVal = NoteLetters.D;
                        break;
                    case "e":
                        returnVal = NoteLetters.E;
                        break;
                    case "f":
                        returnVal = NoteLetters.F;
                        break;
                    case "g":
                        returnVal = NoteLetters.G;
                        break;
                    default: // make C the default just because I can
                        returnVal = NoteLetters.C;
                        break;
                }
                return returnVal;
            }
            set
            {
                switch (value)
                {
                    case NoteLetters.A:
                        Value = "a";
                        break;
                    case NoteLetters.B:
                        Value = "b";
                        break;
                    case NoteLetters.C:
                        Value = "c";
                        break;
                    case NoteLetters.D:
                        Value = "d";
                        break;
                    case NoteLetters.E:
                        Value = "e";
                        break;
                    case NoteLetters.F:
                        Value = "f";
                        break;
                    case NoteLetters.G:
                        Value = "g";
                        break;
                }
            }
        }
    }
}
