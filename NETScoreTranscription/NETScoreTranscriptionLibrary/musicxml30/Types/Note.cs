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
    public class Note
    {
        private static XmlSerializer serializer;
        private Accidental accidentalField;
        private decimal attackField;

        private bool attackFieldSpecified;

        private Beam[] beamField;
        private string colorField;

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;
        private EmptyPlacement[] dotField;
        private decimal dynamicsField;

        private bool dynamicsFieldSpecified;

        private decimal endDymaicsField;

        private bool endDymaicsFieldSpecified;

        private string fontFamilyField;
        private string fontSizeField;

        private FontStyle fontStyleField;

        private bool fontStyleFieldSpecified;

        private FontWeight fontWeightField;

        private bool fontWeightFieldSpecified;
        private FormattedText footnoteField;
        private Instrument instrumentField;
        private ItemsChoiceType1[] itemsElementNameField;
        private object[] itemsField;
        private Level levelField;
        private Lyric[] lyricField;
        private Notations[] notationsField;
        private NoteHead noteHeadField;

        private NoteHeadText noteHeadtextField;
        private YesNo pizzicatoField;

        private bool pizzicatoFieldSpecified;
        private Play playField;

        private YesNo printDotField;

        private bool printDotFieldSpecified;

        private YesNo printLyricField;

        private bool printLyricFieldSpecified;
        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;

        private decimal releaseField;

        private bool releaseFieldSpecified;
        private string staffField;
        private Stem stemField;
        private TimeModification timeModificationField;

        private string timeOnlyField;
        private NoteType typeField;
        private string voiceField;

        [XmlElement("chord", typeof (Empty), Order = 0)]
        [XmlElement("cue", typeof (Empty), Order = 0)]
        [XmlElement("duration", typeof (decimal), Order = 0)]
        [XmlElement("grace", typeof (Grace), Order = 0)]
        [XmlElement("pitch", typeof (Pitch), Order = 0)]
        [XmlElement("rest", typeof (Rest), Order = 0)]
        [XmlElement("tie", typeof (Tie), Order = 0)]
        [XmlElement("unpitched", typeof (Unpitched), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore]
        public ItemsChoiceType1[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }

        [XmlElement(Order = 2)]
        public Instrument instrument
        {
            get { return instrumentField; }
            set { instrumentField = value; }
        }

        [XmlElement(Order = 3)]
        public FormattedText footnote
        {
            get { return footnoteField; }
            set { footnoteField = value; }
        }

        [XmlElement(Order = 4)]
        public Level level
        {
            get { return levelField; }
            set { levelField = value; }
        }

        [XmlElement(Order = 5)]
        public string voice
        {
            get { return voiceField; }
            set { voiceField = value; }
        }

        [XmlElement(Order = 6)]
        public NoteType type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlElement("dot", Order = 7)]
        public EmptyPlacement[] dot
        {
            get { return dotField; }
            set { dotField = value; }
        }

        [XmlElement(Order = 8)]
        public Accidental accidental
        {
            get { return accidentalField; }
            set { accidentalField = value; }
        }

        [XmlElement("time-modification", Order = 9)]
        public TimeModification timeModification
        {
            get { return timeModificationField; }
            set { timeModificationField = value; }
        }

        [XmlElement(Order = 10)]
        public Stem stem
        {
            get { return stemField; }
            set { stemField = value; }
        }

        [XmlElement(Order = 11)]
        public NoteHead noteHead
        {
            get { return noteHeadField; }
            set { noteHeadField = value; }
        }

        [XmlElement("noteHead-text", Order = 12)]
        public NoteHeadText noteHeadtext
        {
            get { return noteHeadtextField; }
            set { noteHeadtextField = value; }
        }

        [XmlElement(DataType = "positiveInteger", Order = 13)]
        public string staff
        {
            get { return staffField; }
            set { staffField = value; }
        }

        [XmlElement("beam", Order = 14)]
        public Beam[] beam
        {
            get { return beamField; }
            set { beamField = value; }
        }

        [XmlElement("notations", Order = 15)]
        public Notations[] notations
        {
            get { return notationsField; }
            set { notationsField = value; }
        }

        [XmlElement("lyric", Order = 16)]
        public Lyric[] lyric
        {
            get { return lyricField; }
            set { lyricField = value; }
        }

        [XmlElement(Order = 17)]
        public Play play
        {
            get { return playField; }
            set { playField = value; }
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

        [XmlAttribute("font-family", DataType = "token")]
        public string fontFamily
        {
            get { return fontFamilyField; }
            set { fontFamilyField = value; }
        }

        [XmlAttribute("font-style")]
        public FontStyle fontStyle
        {
            get { return fontStyleField; }
            set { fontStyleField = value; }
        }

        [XmlIgnore]
        public bool fontStyleSpecified
        {
            get { return fontStyleFieldSpecified; }
            set { fontStyleFieldSpecified = value; }
        }

        [XmlAttribute("font-size")]
        public string fontSize
        {
            get { return fontSizeField; }
            set { fontSizeField = value; }
        }

        [XmlAttribute("font-weight")]
        public FontWeight fontWeight
        {
            get { return fontWeightField; }
            set { fontWeightField = value; }
        }

        [XmlIgnore]
        public bool fontWeightSpecified
        {
            get { return fontWeightFieldSpecified; }
            set { fontWeightFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute("print-dot")]
        public YesNo printDot
        {
            get { return printDotField; }
            set { printDotField = value; }
        }

        [XmlIgnore]
        public bool printDotSpecified
        {
            get { return printDotFieldSpecified; }
            set { printDotFieldSpecified = value; }
        }

        [XmlAttribute("print-lyric")]
        public YesNo printLyric
        {
            get { return printLyricField; }
            set { printLyricField = value; }
        }

        [XmlIgnore]
        public bool printLyricSpecified
        {
            get { return printLyricFieldSpecified; }
            set { printLyricFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal dynamics
        {
            get { return dynamicsField; }
            set { dynamicsField = value; }
        }

        [XmlIgnore]
        public bool dynamicsSpecified
        {
            get { return dynamicsFieldSpecified; }
            set { dynamicsFieldSpecified = value; }
        }

        [XmlAttribute("end-dynamics")]
        public decimal endDymaics
        {
            get { return endDymaicsField; }
            set { endDymaicsField = value; }
        }

        [XmlIgnore]
        public bool endDymaicsSpecified
        {
            get { return endDymaicsFieldSpecified; }
            set { endDymaicsFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal attack
        {
            get { return attackField; }
            set { attackField = value; }
        }

        [XmlIgnore]
        public bool attackSpecified
        {
            get { return attackFieldSpecified; }
            set { attackFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal release
        {
            get { return releaseField; }
            set { releaseField = value; }
        }

        [XmlIgnore]
        public bool releaseSpecified
        {
            get { return releaseFieldSpecified; }
            set { releaseFieldSpecified = value; }
        }

        [XmlAttribute("time-only", DataType = "token")]
        public string timeOnly
        {
            get { return timeOnlyField; }
            set { timeOnlyField = value; }
        }

        [XmlAttribute]
        public YesNo pizzicato
        {
            get { return pizzicatoField; }
            set { pizzicatoField = value; }
        }

        [XmlIgnore]
        public bool pizzicatoSpecified
        {
            get { return pizzicatoFieldSpecified; }
            set { pizzicatoFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Note));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current note object into an XML document
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
        ///   Deserializes workflow markup into an note object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output note object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Note obj, out Exception exception)
        {
            exception = null;
            obj = default(Note);
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

        public static bool Deserialize(string xml, out Note obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Note Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Note)
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
        ///   Serializes current note object into file
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
        ///   Deserializes xml markup from file into an note object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output note object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Note obj, out Exception exception)
        {
            exception = null;
            obj = default(Note);
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

        public static bool LoadFromFile(string fileName, out Note obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Note LoadFromFile(string fileName)
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
        ///   Create a clone of this note object
        /// </summary>
        public virtual Note Clone()
        {
            return ((Note) (MemberwiseClone()));
        }

        #endregion
    }
}