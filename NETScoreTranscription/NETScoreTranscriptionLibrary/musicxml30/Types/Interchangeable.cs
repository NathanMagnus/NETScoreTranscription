using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Interchangeable
    {

        private TimeRelation timeRelationField;

        private bool timeRelationFieldSpecified;

        private string[] itemsField;

        private ItemsChoiceType9[] itemsElementNameField;

        private TimeSymbol symbolField;

        private bool symbolFieldSpecified;

        private TimeSeparator separatorField;

        private bool separatorFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("time-relation", Order = 0)]
        public TimeRelation timeRelation
        {
            get
            {
                return timeRelationField;
            }
            set
            {
                timeRelationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool timeRelationSpecified
        {
            get
            {
                return timeRelationFieldSpecified;
            }
            set
            {
                timeRelationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("beat-type", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("beats", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
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

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ItemsChoiceType9[] ItemsElementName
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
        public TimeSymbol symbol
        {
            get
            {
                return symbolField;
            }
            set
            {
                symbolField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool symbolSpecified
        {
            get
            {
                return symbolFieldSpecified;
            }
            set
            {
                symbolFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public TimeSeparator separator
        {
            get
            {
                return separatorField;
            }
            set
            {
                separatorField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool separatorSpecified
        {
            get
            {
                return separatorFieldSpecified;
            }
            set
            {
                separatorFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Interchangeable));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current interchangeable object into an XML document
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
        /// Deserializes workflow markup into an interchangeable object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output interchangeable object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Interchangeable obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Interchangeable);
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

        public static bool Deserialize(string xml, out Interchangeable obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Interchangeable Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Interchangeable)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current interchangeable object into file
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
        /// Deserializes xml markup from file into an interchangeable object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output interchangeable object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Interchangeable obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Interchangeable);
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

        public static bool LoadFromFile(string fileName, out Interchangeable obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Interchangeable LoadFromFile(string fileName)
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
        /// Create a clone of this interchangeable object
        /// </summary>
        public virtual Interchangeable Clone()
        {
            return ((Interchangeable)(MemberwiseClone()));
        }
        #endregion
    }
}