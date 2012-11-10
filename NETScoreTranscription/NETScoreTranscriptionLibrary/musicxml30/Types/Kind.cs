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
    public class Kind
    {
        private static XmlSerializer serializer;
        private YesNo bracketDegreesField;

        private bool bracketdegreesFieldSpecified;

        private LeftCenterRight halignField;

        private bool halignFieldSpecified;
        private YesNo parenthesesDegreesField;

        private bool parenthesesDegreesFieldSpecified;
        private YesNo stackDegreesField;

        private bool stackDegreesFieldSpecified;
        private string textField;
        private YesNo useSymbolsField;

        private bool useSymbolsFieldSpecified;

        private Valign valignField;

        private bool valignFieldSpecified;

        private KindValue valueField;

        [XmlAttribute("use-symbols")]
        public YesNo useSymbols
        {
            get { return useSymbolsField; }
            set { useSymbolsField = value; }
        }

        [XmlIgnore]
        public bool useSymbolsSpecified
        {
            get { return useSymbolsFieldSpecified; }
            set { useSymbolsFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string text
        {
            get { return textField; }
            set { textField = value; }
        }

        [XmlAttribute("stack-degrees")]
        public YesNo stackDegrees
        {
            get { return stackDegreesField; }
            set { stackDegreesField = value; }
        }

        [XmlIgnore]
        public bool stackDegreesSpecified
        {
            get { return stackDegreesFieldSpecified; }
            set { stackDegreesFieldSpecified = value; }
        }

        [XmlAttribute("parentheses-degrees")]
        public YesNo parenthesesDegrees
        {
            get { return parenthesesDegreesField; }
            set { parenthesesDegreesField = value; }
        }

        [XmlIgnore]
        public bool parenthesesDegreesSpecified
        {
            get { return parenthesesDegreesFieldSpecified; }
            set { parenthesesDegreesFieldSpecified = value; }
        }

        [XmlAttribute("bracket-degrees")]
        public YesNo bracketDegrees
        {
            get { return bracketDegreesField; }
            set { bracketDegreesField = value; }
        }

        [XmlIgnore]
        public bool bracketDegreesSpecified
        {
            get { return bracketdegreesFieldSpecified; }
            set { bracketdegreesFieldSpecified = value; }
        }

        [XmlAttribute]
        public LeftCenterRight halign
        {
            get { return halignField; }
            set { halignField = value; }
        }

        [XmlIgnore]
        public bool halignSpecified
        {
            get { return halignFieldSpecified; }
            set { halignFieldSpecified = value; }
        }

        [XmlAttribute]
        public Valign valign
        {
            get { return valignField; }
            set { valignField = value; }
        }

        [XmlIgnore]
        public bool valignSpecified
        {
            get { return valignFieldSpecified; }
            set { valignFieldSpecified = value; }
        }

        [XmlText]
        public KindValue Value
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
                    serializer = new XmlSerializer(typeof (Kind));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current kind object into an XML document
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
        ///   Deserializes workflow markup into an kind object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output kind object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Kind obj, out Exception exception)
        {
            exception = null;
            obj = default(Kind);
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

        public static bool Deserialize(string xml, out Kind obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Kind Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Kind)
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
        ///   Serializes current kind object into file
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
        ///   Deserializes xml markup from file into an kind object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output kind object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Kind obj, out Exception exception)
        {
            exception = null;
            obj = default(Kind);
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

        public static bool LoadFromFile(string fileName, out Kind obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Kind LoadFromFile(string fileName)
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
        ///   Create a clone of this kind object
        /// </summary>
        public virtual Kind Clone()
        {
            return ((Kind) (MemberwiseClone()));
        }

        #endregion
    }
}