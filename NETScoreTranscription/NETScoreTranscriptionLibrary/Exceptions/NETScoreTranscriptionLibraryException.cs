using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETScoreTranscriptionLibrary.Exceptions
{
    public class NETScoreTranscriptionLibraryException : Exception
    {
        public NETScoreTranscriptionLibraryException(string msg) : base(msg)
        { }
    }
}
