using System;
using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary
{
    public class XMLStringFetcher
    {
        public static string GetXMLFile(string file)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/MusicXMLSamples/" + file, FileMode.Open, FileAccess.Read);
            }
            catch(Exception e)
            {
                fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/MusicXMLTestSuite/" + file, FileMode.Open, FileAccess.Read);
            }

            StreamReader sr = new StreamReader(fs);
            String returnString = sr.ReadToEnd();

            return returnString;
        }
    }
}
