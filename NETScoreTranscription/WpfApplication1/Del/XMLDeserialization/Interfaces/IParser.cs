using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscription;

namespace NETScoreTranscriptionLibrary.XMLDeserialization.Interfaces
{
    public interface IParser
    {
        NSTScorePartwise ParseFile(String fileName);
        NSTScorePartwise ParseString(String dataString);
    }
}
