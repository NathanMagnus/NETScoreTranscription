using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETScoreTranscriptionLibrary.Exceptions.Drawing
{
    public class NullElementException : NETScoreTranscriptionLibraryException
    {
        public NullElementException(String message) : base(message)
        {
        }
    }
}
