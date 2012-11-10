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
    public class Accidental
    {
        private static XmlSerializer serializer;
        private YesNo bracketField;

        private bool bracketFieldSpecified;
        private YesNo cautionaryField;

        private bool cautionaryFieldSpecified;

        private YesNo editorialField;

        private bool editorialFieldSpecified;

        private YesNo parenthesesField;

        private bool parenthesesFieldSpecified;

        private SymbolSize sizeField;

        private bool sizeFieldSpecified;

        private AccidentalValue valueField;

        [XmlAttribute]
        public YesNo cautionary
        {
            get { return cautionaryField; }
            set { cautionaryField = value; }
        }

        [XmlIgnore]
        public bool cautionarySpecified
        {
            get { return cautionaryFieldSpecified; }
            set { cautionaryFieldSpecified = value; }
        }

        [XmlAttribute]
        public YesNo editorial
        {
            get { return editorialField; }
            set { editorialField = value; }
        }

        [XmlIgnore]
        public bool editorialSpecified
        {
            get { return editorialFieldSpecified; }
            set { editorialFieldSpecified = value; }
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

        [XmlAttribute]
        public YesNo bracket
        {
            get { return bracketField; }
            set { bracketField = value; }
        }

        [XmlIgnore]
        public bool bracketSpecified
        {
            get { return bracketFieldSpecified; }
            set { bracketFieldSpecified = value; }
        }

        [XmlAttribute]
        public SymbolSize size
        {
            get { return sizeField; }
            set { sizeField = value; }
        }

        [XmlIgnore]
        public bool sizeSpecified
        {
            get { return sizeFieldSpecified; }
            set { sizeFieldSpecified = value; }
        }

        [XmlText]
        public AccidentalValue Value
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
                    serializer = new XmlSerializer(typeof (Accidental));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current accidental object into an XML document
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
        ///   Deserializes workflow markup into an accidental object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output accidental object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Accidental obj, out Exception exception)
        {
            exception = null;
            obj = default(Accidental);
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

        public static bool Deserialize(string xml, out Accidental obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Accidental Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Accidental)
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
        ///   Serializes current accidental object into file
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
        ///   Deserializes xml markup from file into an accidental object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output accidental object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Accidental obj, out Exception exception)
        {
            exception = null;
            obj = default(Accidental);
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

        public static bool LoadFromFile(string fileName, out Accidental obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Accidental LoadFromFile(string fileName)
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
        ///   Create a clone of this accidental object
        /// </summary>
        public virtual Accidental Clone()
        {
            return ((Accidental) (MemberwiseClone()));
        }

        #endregion
    }
}