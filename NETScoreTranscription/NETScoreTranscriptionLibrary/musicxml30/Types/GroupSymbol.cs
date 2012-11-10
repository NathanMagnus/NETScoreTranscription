using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "group-symbol")]
    [System.Xml.Serialization.XmlRootAttribute("group-symbol", Namespace = "", IsNullable = true)]
    public class GroupSymbol
    {

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;

        private string colorField;

        private GroupSymbolValue valueField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultX
        {
            get
            {
                return defaultXField;
            }
            set
            {
                defaultXField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool defaultXSpecified
        {
            get
            {
                return defaultXFieldSpecified;
            }
            set
            {
                defaultXFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaultY
        {
            get
            {
                return defaultYField;
            }
            set
            {
                defaultYField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool defaultYSpecified
        {
            get
            {
                return defaultYFieldSpecified;
            }
            set
            {
                defaultYFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativeX
        {
            get
            {
                return relativeXField;
            }
            set
            {
                relativeXField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool relativeXSpecified
        {
            get
            {
                return relativeXFieldSpecified;
            }
            set
            {
                relativeXFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativeY
        {
            get
            {
                return relativeYField;
            }
            set
            {
                relativeYField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool relativeYSpecified
        {
            get
            {
                return relativeYFieldSpecified;
            }
            set
            {
                relativeYFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color
        {
            get
            {
                return colorField;
            }
            set
            {
                colorField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute]
        public GroupSymbolValue Value
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(GroupSymbol));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current groupSymbol object into an XML document
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
        /// Deserializes workflow markup into an groupSymbol object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output groupSymbol object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out GroupSymbol obj, out System.Exception exception)
        {
            exception = null;
            obj = default(GroupSymbol);
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

        public static bool Deserialize(string xml, out GroupSymbol obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static GroupSymbol Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((GroupSymbol)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current groupSymbol object into file
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
        /// Deserializes xml markup from file into an groupSymbol object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output groupSymbol object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out GroupSymbol obj, out System.Exception exception)
        {
            exception = null;
            obj = default(GroupSymbol);
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

        public static bool LoadFromFile(string fileName, out GroupSymbol obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static GroupSymbol LoadFromFile(string fileName)
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
        /// Create a clone of this groupSymbol object
        /// </summary>
        public virtual GroupSymbol Clone()
        {
            return ((GroupSymbol)(MemberwiseClone()));
        }
        #endregion
    }
}