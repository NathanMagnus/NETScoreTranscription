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
    public class Lyric
    {
        private static XmlSerializer serializer;
        private string colorField;
        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;
        private Empty endLineField;

        private Empty endParagraphField;

        private FormattedText footnoteField;
        private ItemsChoiceType6[] itemsElementNameField;
        private object[] itemsField;

        private LeftCenterRight justifyField;

        private bool justifyFieldSpecified;
        private Level levelField;
        private string nameField;
        private string numberField;

        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;
        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;

        [XmlElement("elision", typeof (TextFontColor), Order = 0)]
        [XmlElement("extend", typeof (Extend), Order = 0)]
        [XmlElement("humming", typeof (Empty), Order = 0)]
        [XmlElement("laughing", typeof (Empty), Order = 0)]
        [XmlElement("syllabic", typeof (Syllabic), Order = 0)]
        [XmlElement("text", typeof (TextElementData), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore]
        public ItemsChoiceType6[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }

        [XmlElement("end-line", Order = 2)]
        public Empty endLine
        {
            get { return endLineField; }
            set { endLineField = value; }
        }

        [XmlElement("end-paragraph", Order = 3)]
        public Empty endParagraph
        {
            get { return endParagraphField; }
            set { endParagraphField = value; }
        }

        [XmlElement(Order = 4)]
        public FormattedText footnote
        {
            get { return footnoteField; }
            set { footnoteField = value; }
        }

        [XmlElement(Order = 5)]
        public Level level
        {
            get { return levelField; }
            set { levelField = value; }
        }

        [XmlAttribute(DataType = "NMTOKEN")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string name
        {
            get { return nameField; }
            set { nameField = value; }
        }

        [XmlAttribute]
        public LeftCenterRight justify
        {
            get { return justifyField; }
            set { justifyField = value; }
        }

        [XmlIgnore]
        public bool justifySpecified
        {
            get { return justifyFieldSpecified; }
            set { justifyFieldSpecified = value; }
        }

        [XmlAttribute("default-x")]
        public decimal defaultX
        {
            get { return defaultXField; }
            set { defaultXField = value; }
        }

        [XmlIgnore]
        public bool defaultXSpecified
        {
            get { return defaultXFieldSpecified; }
            set { defaultXFieldSpecified = value; }
        }

        [XmlAttribute("default-y")]
        public decimal defaultY
        {
            get { return defaultYField; }
            set { defaultYField = value; }
        }

        [XmlIgnore]
        public bool defaultYSpecified
        {
            get { return defaultYFieldSpecified; }
            set { defaultYFieldSpecified = value; }
        }

        [XmlAttribute("relative-x")]
        public decimal relativeX
        {
            get { return relativeXField; }
            set { relativeXField = value; }
        }

        [XmlIgnore]
        public bool relativeXSpecified
        {
            get { return relativeXFieldSpecified; }
            set { relativeXFieldSpecified = value; }
        }

        [XmlAttribute("relative-y")]
        public decimal relativeY
        {
            get { return relativeYField; }
            set { relativeYField = value; }
        }

        [XmlIgnore]
        public bool relativeYSpecified
        {
            get { return relativeYFieldSpecified; }
            set { relativeYFieldSpecified = value; }
        }

        [XmlAttribute]
        public AboveBelow placement
        {
            get { return placementField; }
            set { placementField = value; }
        }

        [XmlIgnore]
        public bool placementSpecified
        {
            get { return placementFieldSpecified; }
            set { placementFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute("print-object")]
        public YesNo printObject
        {
            get { return printObjectField; }
            set { printObjectField = value; }
        }

        [XmlIgnore]
        public bool printObjectSpecified
        {
            get { return printObjectFieldSpecified; }
            set { printObjectFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Lyric));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current lyric object into an XML document
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
        ///   Deserializes workflow markup into an lyric object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output lyric object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Lyric obj, out Exception exception)
        {
            exception = null;
            obj = default(Lyric);
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

        public static bool Deserialize(string xml, out Lyric obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Lyric Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Lyric)
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
        ///   Serializes current lyric object into file
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
        ///   Deserializes xml markup from file into an lyric object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output lyric object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Lyric obj, out Exception exception)
        {
            exception = null;
            obj = default(Lyric);
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

        public static bool LoadFromFile(string fileName, out Lyric obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Lyric LoadFromFile(string fileName)
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
        ///   Create a clone of this lyric object
        /// </summary>
        public virtual Lyric Clone()
        {
            return ((Lyric) (MemberwiseClone()));
        }

        #endregion
    }
}