using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Technical
    {

        private object[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("arrow", typeof(Arrow), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bend", typeof(Bend), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("double-tongue", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("down-bow", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fingering", typeof(Fingering), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fingernails", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("fret", typeof(Fret), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("hammer-on", typeof(HammeronPulloff), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("handbell", typeof(Handbell), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("harmonic", typeof(Harmonic), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("heel", typeof(HeelToe), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("hole", typeof(Hole), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("open-string", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("other-technical", typeof(PlacementText), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pluck", typeof(PlacementText), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pull-off", typeof(HammeronPulloff), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("snap-pizzicato", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("stopped", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("string", typeof(@string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("tap", typeof(PlacementText), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("thumb-position", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("toe", typeof(HeelToe), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("triple-tongue", typeof(EmptyPlacement), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("up-bow", typeof(EmptyPlacement), Order = 0)]
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
        public ItemsChoiceType3[] ItemsElementName
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Technical));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current technical object into an XML document
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
        /// Deserializes workflow markup into an technical object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output technical object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Technical obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Technical);
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

        public static bool Deserialize(string xml, out Technical obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Technical Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Technical)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current technical object into file
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
        /// Deserializes xml markup from file into an technical object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output technical object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Technical obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Technical);
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

        public static bool LoadFromFile(string fileName, out Technical obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Technical LoadFromFile(string fileName)
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
        /// Create a clone of this technical object
        /// </summary>
        public virtual Technical Clone()
        {
            return ((Technical)(MemberwiseClone()));
        }
        #endregion
    }
}