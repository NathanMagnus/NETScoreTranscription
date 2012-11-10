using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Identification
    {

        private TypedText[] creatorField;

        private TypedText[] rightsField;

        private Encoding encodingField;

        private string sourceField;

        private TypedText[] relationField;

        private MiscellaneousField[] miscellaneousField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        /// <summary>
        /// The creator element is borrowed from Dublin Core. It is used for the creators of the score. The type attribute is used to distinguish different creative contributions. Thus, there can be multiple creators within an identification. Standard type values are composer, lyricist, and arranger. Other type values may be used for different types of creative roles. The type attribute should usually be used even if there is just a single creator element. The MusicXML format does not use the creator / contributor distinction from Dublin Core.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("creator", Order = 0)]
        public TypedText[] creator
        {
            get
            {
                return creatorField;
            }
            set
            {
                creatorField = value;
            }
        }

        /// <summary>
        /// The rights element is borrowed from Dublin Core. It contains copyright and other intellectual property notices. Words, music, and derivatives can have different types, so multiple rights tags with different type attributes are supported. Standard type values are music, words, and arrangement, but other types may be used. The type attribute is only needed when there are multiple rights elements.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("rights", Order = 1)]
        public TypedText[] rights
        {
            get
            {
                return rightsField;
            }
            set
            {
                rightsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public Encoding encoding
        {
            get
            {
                return encodingField;
            }
            set
            {
                encodingField = value;
            }
        }

        /// <summary>
        /// The source for the music that is encoded. This is similar to the Dublin Core source element.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string source
        {
            get
            {
                return sourceField;
            }
            set
            {
                sourceField = value;
            }
        }

        /// <summary>
        /// A related resource for the music that is encoded. This is similar to the Dublin Core relation element. Standard type values are music, words, and arrangement, but other types may be used.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("relation", Order = 4)]
        public TypedText[] relation
        {
            get
            {
                return relationField;
            }
            set
            {
                relationField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public MiscellaneousField[] miscellaneous
        {
            get
            {
                return miscellaneousField;
            }
            set
            {
                miscellaneousField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Identification));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current identification object into an XML document
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
        /// Deserializes workflow markup into an identification object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output identification object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Identification obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Identification);
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

        public static bool Deserialize(string xml, out Identification obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Identification Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Identification)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current identification object into file
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
        /// Deserializes xml markup from file into an identification object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output identification object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Identification obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Identification);
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

        public static bool LoadFromFile(string fileName, out Identification obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Identification LoadFromFile(string fileName)
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
        /// Create a clone of this identification object
        /// </summary>
        public virtual Identification Clone()
        {
            return ((Identification)(MemberwiseClone()));
        }
        #endregion
    }
}