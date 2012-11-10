using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Harmony
    {

        private object[] itemsField;

        private Frame frameField;

        private Offset offsetField;

        private FormattedText footnoteField;

        private Level levelField;

        private string staffField;

        private HarmonyType typeField;

        private bool typeFieldSpecified;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;

        private YesNo printFrameField;

        private bool printframeFieldSpecified;

        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("bass", typeof(Bass), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("degree", typeof(Degree), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("function", typeof(StyleText), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("inversion", typeof(Inversion), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("kind", typeof(Kind), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("root", typeof(Root), Order = 0)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Frame frame
        {
            get
            {
                return frameField;
            }
            set
            {
                frameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public Offset offset
        {
            get
            {
                return offsetField;
            }
            set
            {
                offsetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public FormattedText footnote
        {
            get
            {
                return footnoteField;
            }
            set
            {
                footnoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Level level
        {
            get
            {
                return levelField;
            }
            set
            {
                levelField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger", Order = 5)]
        public string staff
        {
            get
            {
                return staffField;
            }
            set
            {
                staffField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public HarmonyType type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool typeSpecified
        {
            get
            {
                return typeFieldSpecified;
            }
            set
            {
                typeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public YesNo printObject
        {
            get
            {
                return printObjectField;
            }
            set
            {
                printObjectField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printObjectSpecified
        {
            get
            {
                return printObjectFieldSpecified;
            }
            set
            {
                printObjectFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-frame")]
        public YesNo printFrame
        {
            get
            {
                return printFrameField;
            }
            set
            {
                printFrameField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printFrameSpecified
        {
            get
            {
                return printframeFieldSpecified;
            }
            set
            {
                printframeFieldSpecified = value;
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Harmony));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current harmony object into an XML document
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
        /// Deserializes workflow markup into an harmony object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output harmony object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Harmony obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Harmony);
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

        public static bool Deserialize(string xml, out Harmony obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Harmony Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Harmony)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current harmony object into file
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
        /// Deserializes xml markup from file into an harmony object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output harmony object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Harmony obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Harmony);
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

        public static bool LoadFromFile(string fileName, out Harmony obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Harmony LoadFromFile(string fileName)
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
        /// Create a clone of this harmony object
        /// </summary>
        public virtual Harmony Clone()
        {
            return ((Harmony)(MemberwiseClone()));
        }
        #endregion
    }
}