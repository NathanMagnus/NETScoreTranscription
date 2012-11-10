using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Kind
    {

        private YesNo useSymbolsField;

        private bool useSymbolsFieldSpecified;

        private string textField;

        private YesNo stackDegreesField;

        private bool stackDegreesFieldSpecified;

        private YesNo parenthesesDegreesField;

        private bool parenthesesDegreesFieldSpecified;

        private YesNo bracketDegreesField;

        private bool bracketdegreesFieldSpecified;

        private LeftCenterRight halignField;

        private bool halignFieldSpecified;

        private Valign valignField;

        private bool valignFieldSpecified;

        private KindValue valueField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
        public YesNo useSymbols
        {
            get
            {
                return useSymbolsField;
            }
            set
            {
                useSymbolsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool useSymbolsSpecified
        {
            get
            {
                return useSymbolsFieldSpecified;
            }
            set
            {
                useSymbolsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string text
        {
            get
            {
                return textField;
            }
            set
            {
                textField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("stack-degrees")]
        public YesNo stackDegrees
        {
            get
            {
                return stackDegreesField;
            }
            set
            {
                stackDegreesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool stackDegreesSpecified
        {
            get
            {
                return stackDegreesFieldSpecified;
            }
            set
            {
                stackDegreesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("parentheses-degrees")]
        public YesNo parenthesesDegrees
        {
            get
            {
                return parenthesesDegreesField;
            }
            set
            {
                parenthesesDegreesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool parenthesesDegreesSpecified
        {
            get
            {
                return parenthesesDegreesFieldSpecified;
            }
            set
            {
                parenthesesDegreesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bracket-degrees")]
        public YesNo bracketDegrees
        {
            get
            {
                return bracketDegreesField;
            }
            set
            {
                bracketDegreesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bracketDegreesSpecified
        {
            get
            {
                return bracketdegreesFieldSpecified;
            }
            set
            {
                bracketdegreesFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public LeftCenterRight halign
        {
            get
            {
                return halignField;
            }
            set
            {
                halignField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool halignSpecified
        {
            get
            {
                return halignFieldSpecified;
            }
            set
            {
                halignFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public Valign valign
        {
            get
            {
                return valignField;
            }
            set
            {
                valignField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool valignSpecified
        {
            get
            {
                return valignFieldSpecified;
            }
            set
            {
                valignFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute]
        public KindValue Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Kind));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current kind object into an XML document
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
        /// Deserializes workflow markup into an kind object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output kind object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Kind obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Kind);
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

        public static bool Deserialize(string xml, out Kind obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Kind Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Kind)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current kind object into file
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
        /// Deserializes xml markup from file into an kind object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output kind object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Kind obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Kind);
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

        public static bool LoadFromFile(string fileName, out Kind obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Kind LoadFromFile(string fileName)
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
        /// Create a clone of this kind object
        /// </summary>
        public virtual Kind Clone()
        {
            return ((Kind)(MemberwiseClone()));
        }
        #endregion
    }
}