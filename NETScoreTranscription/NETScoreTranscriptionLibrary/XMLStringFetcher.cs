using System;
using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary
{
    public class XMLStringFetcher
    {
        /// <summary>
        /// Get the contents of a MusicXML file
        /// </summary>
        /// <param name="fileName">The name of the file to get the contents of</param>
        /// <returns>A string of the contents of a MusicXML file</returns>
        public static string GetXMLFile(string fileName)
        {
            FileStream fs = GetFileStream(fileName);

            StreamReader sr = new StreamReader(fs);
            String returnString = sr.ReadToEnd();

            return returnString;
        }
        /// <summary>
        /// Get the FileStream for a faile
        /// </summary>
        /// <param name="fileName">The filename to get the stream for</param>
        /// <returns>FileStream of fileName</returns>
        public static FileStream GetFileStream(string fileName)
        {
            try
            {
                return new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/MusicXMLSamples/" + fileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception e)
            {
                return new FileStream(AppDomain.CurrentDomain.BaseDirectory + "/MusicXMLTestSuite/" + fileName, FileMode.Open, FileAccess.Read);
            }
        }
    }
}
