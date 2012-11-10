using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Defaults
    {

        private Scaling scalingField;

        private PageLayout pageLayoutField;

        private SystemLayout systemLayoutField;

        private StaffLayout[] staffLayoutField;

        private Appearance appearanceField;

        private EmptyFont musicFontField;

        private EmptyFont wordFontField;

        private LyricFont[] lyricFontField;

        private LyricLanguage[] lyricLanguageField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Scaling scaling
        {
            get
            {
                return scalingField;
            }
            set
            {
                scalingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("page-layout", Order = 1)]
        public PageLayout pageLayout
        {
            get
            {
                return pageLayoutField;
            }
            set
            {
                pageLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("system-layout", Order = 2)]
        public SystemLayout systemLayout
        {
            get
            {
                return systemLayoutField;
            }
            set
            {
                systemLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-layout", Order = 3)]
        public StaffLayout[] staffLayout
        {
            get
            {
                return staffLayoutField;
            }
            set
            {
                staffLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Appearance appearance
        {
            get
            {
                return appearanceField;
            }
            set
            {
                appearanceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("music-font", Order = 5)]
        public EmptyFont musicFont
        {
            get
            {
                return musicFontField;
            }
            set
            {
                musicFontField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("word-font", Order = 6)]
        public EmptyFont wordFont
        {
            get
            {
                return wordFontField;
            }
            set
            {
                wordFontField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lyric-font", Order = 7)]
        public LyricFont[] lyricFont
        {
            get
            {
                return lyricFontField;
            }
            set
            {
                lyricFontField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lyric-language", Order = 8)]
        public LyricLanguage[] lyricLanguage
        {
            get
            {
                return lyricLanguageField;
            }
            set
            {
                lyricLanguageField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Defaults));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current defaults object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
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
        /// Deserializes workflow markup into an defaults object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output defaults object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Defaults obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Defaults);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out Defaults obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Defaults Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Defaults)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current defaults object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
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
        /// Deserializes xml markup from file into an defaults object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output defaults object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Defaults obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Defaults);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out Defaults obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Defaults LoadFromFile(string fileName)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
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
        /// Create a clone of this defaults object
        /// </summary>
        public virtual Defaults Clone()
        {
            return ((Defaults)(MemberwiseClone()));
        }
        #endregion
    }
}