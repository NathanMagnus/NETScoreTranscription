using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Dynamics
    {

        private object[] itemsField;

        private ItemsChoiceType5[] itemsElementNameField;

        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private string underlineField;

        private string overlineField;

        private string lineThroughField;

        private EnclosureShape enclosureField;

        private bool enclosureFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("f", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ff", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fff", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ffff", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fffff", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ffffff", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fz", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mf", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("mp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("other-dynamics", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ppp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pppp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ppppp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pppppp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("rf", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("rfz", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sf", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sffz", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sfp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sfpp", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sfz", typeof(Empty), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ItemsChoiceType5[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public AboveBelow placement
        {
            get
            {
                return placementField;
            }
            set
            {
                placementField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool placementSpecified
        {
            get
            {
                return placementFieldSpecified;
            }
            set
            {
                placementFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string underline
        {
            get
            {
                return underlineField;
            }
            set
            {
                underlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string overline
        {
            get
            {
                return overlineField;
            }
            set
            {
                overlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("line-through", DataType = "nonNegativeInteger")]
        public string lineThrough
        {
            get
            {
                return lineThroughField;
            }
            set
            {
                lineThroughField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public EnclosureShape enclosure
        {
            get
            {
                return enclosureField;
            }
            set
            {
                enclosureField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool enclosureSpecified
        {
            get
            {
                return enclosureFieldSpecified;
            }
            set
            {
                enclosureFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Dynamics));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current dynamics object into an XML document
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
        /// Deserializes workflow markup into an dynamics object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output dynamics object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Dynamics obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Dynamics);
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

        public static bool Deserialize(string xml, out Dynamics obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Dynamics Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Dynamics)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current dynamics object into file
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
        /// Deserializes xml markup from file into an dynamics object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output dynamics object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Dynamics obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Dynamics);
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

        public static bool LoadFromFile(string fileName, out Dynamics obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Dynamics LoadFromFile(string fileName)
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
        /// Create a clone of this dynamics object
        /// </summary>
        public virtual Dynamics Clone()
        {
            return ((Dynamics)(MemberwiseClone()));
        }
        #endregion
    }
}