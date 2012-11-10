using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ScorePartwisePartMeasure
    {

        private object[] itemsField;

        private string numberField;

        private YesNo implicitField;

        private bool implicitFieldSpecified;

        private YesNo noncontrollingField;

        private bool noncontrollingFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("attributes", typeof(Attributes), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("backup", typeof(Backup), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("barline", typeof(Barline), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bookmark", typeof(Bookmark), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(Direction), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("figured-bass", typeof(FiguredBass), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("forward", typeof(Forward), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("grouping", typeof(Grouping), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("harmony", typeof(Harmony), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("link", typeof(Link), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("note", typeof(Note), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("print", typeof(Print), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("sound", typeof(Sound), Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string number
        {
            get
            {
                return numberField;
            }
            set
            {
                numberField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo @implicit
        {
            get
            {
                return implicitField;
            }
            set
            {
                implicitField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool implicitSpecified
        {
            get
            {
                return implicitFieldSpecified;
            }
            set
            {
                implicitFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("non-controlling")]
        public YesNo noncontrolling
        {
            get
            {
                return noncontrollingField;
            }
            set
            {
                noncontrollingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool noncontrollingSpecified
        {
            get
            {
                return noncontrollingFieldSpecified;
            }
            set
            {
                noncontrollingFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal width
        {
            get
            {
                return widthField;
            }
            set
            {
                widthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool widthSpecified
        {
            get
            {
                return widthFieldSpecified;
            }
            set
            {
                widthFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ScorePartwisePartMeasure));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current scorepartwisePartMeasure object into an XML document
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
        /// Deserializes workflow markup into an scorepartwisePartMeasure object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output scorepartwisePartMeasure object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScorePartwisePartMeasure obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScorePartwisePartMeasure);
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

        public static bool Deserialize(string xml, out ScorePartwisePartMeasure obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScorePartwisePartMeasure Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((ScorePartwisePartMeasure)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current scorepartwisePartMeasure object into file
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
        /// Deserializes xml markup from file into an scorepartwisePartMeasure object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output scorepartwisePartMeasure object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScorePartwisePartMeasure obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScorePartwisePartMeasure);
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

        public static bool LoadFromFile(string fileName, out ScorePartwisePartMeasure obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScorePartwisePartMeasure LoadFromFile(string fileName)
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
        /// Create a clone of this scorepartwisePartMeasure object
        /// </summary>
        public virtual ScorePartwisePartMeasure Clone()
        {
            return ((ScorePartwisePartMeasure)(MemberwiseClone()));
        }
        #endregion
    }
}