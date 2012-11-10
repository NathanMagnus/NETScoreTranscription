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
    public class NoteHead
    {
        private static XmlSerializer serializer;
        private string colorField;
        private YesNo filledField;

        private bool filledFieldSpecified;

        private string fontFamilyField;
        private string fontSizeField;

        private FontStyle fontStyleField;

        private bool fontStyleFieldSpecified;

        private FontWeight fontWeightField;

        private bool fontWeightFieldSpecified;
        private YesNo parenthesesField;

        private bool parenthesesFieldSpecified;

        private NoteHeadValue valueField;

        [XmlAttribute]
        public YesNo filled
        {
            get { return filledField; }
            set { filledField = value; }
        }

        [XmlIgnore]
        public bool filledSpecified
        {
            get { return filledFieldSpecified; }
            set { filledFieldSpecified = value; }
        }

        [XmlAttribute]
        public YesNo parentheses
        {
            get { return parenthesesField; }
            set { parenthesesField = value; }
        }

        [XmlIgnore]
        public bool parenthesesSpecified
        {
            get { return parenthesesFieldSpecified; }
            set { parenthesesFieldSpecified = value; }
        }

        [XmlAttribute("font-family", DataType = "token")]
        public string fontFamily
        {
            get { return fontFamilyField; }
            set { fontFamilyField = value; }
        }

        [XmlAttribute("font-style")]
        public FontStyle fontStyle
        {
            get { return fontStyleField; }
            set { fontStyleField = value; }
        }

        [XmlIgnore]
        public bool fontStyleSpecified
        {
            get { return fontStyleFieldSpecified; }
            set { fontStyleFieldSpecified = value; }
        }

        [XmlAttribute("font-size")]
        public string fontSize
        {
            get { return fontSizeField; }
            set { fontSizeField = value; }
        }

        [XmlAttribute("font-weight")]
        public FontWeight fontWeight
        {
            get { return fontWeightField; }
            set { fontWeightField = value; }
        }

        [XmlIgnore]
        public bool fontWeightSpecified
        {
            get { return fontWeightFieldSpecified; }
            set { fontWeightFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlText]
        public NoteHeadValue Value
        {
            get { return valueField; }
            set { valueField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (NoteHead));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current noteHead object into an XML document
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
        ///   Deserializes workflow markup into an noteHead object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output noteHead object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out NoteHead obj, out Exception exception)
        {
            exception = null;
            obj = default(NoteHead);
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

        public static bool Deserialize(string xml, out NoteHead obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static NoteHead Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((NoteHead)
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
        ///   Serializes current noteHead object into file
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
        ///   Deserializes xml markup from file into an noteHead object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output noteHead object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out NoteHead obj, out Exception exception)
        {
            exception = null;
            obj = default(NoteHead);
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

        public static bool LoadFromFile(string fileName, out NoteHead obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static NoteHead LoadFromFile(string fileName)
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
        ///   Create a clone of this noteHead object
        /// </summary>
        public virtual NoteHead Clone()
        {
            return ((NoteHead) (MemberwiseClone()));
        }

        #endregion
    }
}