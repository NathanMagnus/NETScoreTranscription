using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DesignerCategory("code")]
    [XmlRoot(Namespace = "", IsNullable = true)]
    public class Defaults
    {
        private static XmlSerializer serializer;
        private Appearance appearanceField;

        private LyricFont[] lyricFontField;

        private LyricLanguage[] lyricLanguageField;
        private EmptyFont musicFontField;
        private PageLayout pageLayoutField;
        private Scaling scalingField;
        private StaffLayout[] staffLayoutField;
        private SystemLayout systemLayoutField;
        private EmptyFont wordFontField;

        [XmlElement(Order = 0)]
        public Scaling scaling
        {
            get { return scalingField; }
            set { scalingField = value; }
        }

        [XmlElement("page-layout", Order = 1)]
        public PageLayout pageLayout
        {
            get { return pageLayoutField; }
            set { pageLayoutField = value; }
        }

        [XmlElement("system-layout", Order = 2)]
        public SystemLayout systemLayout
        {
            get { return systemLayoutField; }
            set { systemLayoutField = value; }
        }

        [XmlElement("staff-layout", Order = 3)]
        public StaffLayout[] staffLayout
        {
            get { return staffLayoutField; }
            set { staffLayoutField = value; }
        }

        [XmlElement(Order = 4)]
        public Appearance appearance
        {
            get { return appearanceField; }
            set { appearanceField = value; }
        }

        [XmlElement("music-font", Order = 5)]
        public EmptyFont musicFont
        {
            get { return musicFontField; }
            set { musicFontField = value; }
        }

        [XmlElement("word-font", Order = 6)]
        public EmptyFont wordFont
        {
            get { return wordFontField; }
            set { wordFontField = value; }
        }

        [XmlElement("lyric-font", Order = 7)]
        public LyricFont[] lyricFont
        {
            get { return lyricFontField; }
            set { lyricFontField = value; }
        }

        [XmlElement("lyric-language", Order = 8)]
        public LyricLanguage[] lyricLanguage
        {
            get { return lyricLanguageField; }
            set { lyricLanguageField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Defaults));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current defaults object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        ///   Deserializes workflow markup into an defaults object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output defaults object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Defaults obj, out Exception exception)
        {
            exception = null;
            obj = default(Defaults);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out Defaults obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Defaults Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Defaults)
                     (Serializer.Deserialize(XmlReader.Create(stringReader,
                                                              new XmlReaderSettings
                                                                  {DtdProcessing = DtdProcessing.Parse}))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        ///   Serializes current defaults object into file
        /// </summary>
        /// <param name = "fileName">full path of outupt xml file</param>
        /// <param name = "exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        ///   Deserializes xml markup from file into an defaults object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output defaults object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Defaults obj, out Exception exception)
        {
            exception = null;
            obj = default(Defaults);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out Defaults obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Defaults LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }

        #endregion

        #region Clone method

        /// <summary>
        ///   Create a clone of this defaults object
        /// </summary>
        public virtual Defaults Clone()
        {
            return ((Defaults) (MemberwiseClone()));
        }

        #endregion
    }
}