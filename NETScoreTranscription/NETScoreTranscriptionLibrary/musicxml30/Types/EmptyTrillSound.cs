using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [XmlInclude(typeof (Mordent))]
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(TypeName = "empty-trill-sound")]
    [XmlRoot("empty-trill-sound", Namespace = "", IsNullable = true)]
    public class EmptyTrillSound
    {
        private static XmlSerializer serializer;
        private YesNo accelerateField;

        private bool accelerateFieldSpecified;

        private decimal beatsField;

        private bool beatsFieldSpecified;
        private decimal lastBeatField;

        private bool lastBeatFieldSpecified;
        private AboveBelow placementField;

        private bool placementFieldSpecified;
        private decimal secondBeatField;

        private bool secondBeatFieldSpecified;

        private StartNote startNoteField;

        private bool startNoteFieldSpecified;

        private TrillStep trillStepField;

        private bool trillStepFieldSpecified;

        private TwoNoteTurn twoNoteTurnField;

        private bool twoNoteTurnFieldSpecified;

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

        [XmlAttribute("start-note")]
        public StartNote startNote
        {
            get { return startNoteField; }
            set { startNoteField = value; }
        }

        [XmlIgnore]
        public bool startNoteSpecified
        {
            get { return startNoteFieldSpecified; }
            set { startNoteFieldSpecified = value; }
        }

        [XmlAttribute("trill-step")]
        public TrillStep trillStep
        {
            get { return trillStepField; }
            set { trillStepField = value; }
        }

        [XmlIgnore]
        public bool trillStepSpecified
        {
            get { return trillStepFieldSpecified; }
            set { trillStepFieldSpecified = value; }
        }

        [XmlAttribute("two-note-turn")]
        public TwoNoteTurn twoNoteTurn
        {
            get { return twoNoteTurnField; }
            set { twoNoteTurnField = value; }
        }

        [XmlIgnore]
        public bool twoNoteTurnSpecified
        {
            get { return twoNoteTurnFieldSpecified; }
            set { twoNoteTurnFieldSpecified = value; }
        }

        [XmlAttribute]
        public YesNo accelerate
        {
            get { return accelerateField; }
            set { accelerateField = value; }
        }

        [XmlIgnore]
        public bool accelerateSpecified
        {
            get { return accelerateFieldSpecified; }
            set { accelerateFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal beats
        {
            get { return beatsField; }
            set { beatsField = value; }
        }

        [XmlIgnore]
        public bool beatsSpecified
        {
            get { return beatsFieldSpecified; }
            set { beatsFieldSpecified = value; }
        }

        [XmlAttribute("second-beat")]
        public decimal secondBeat
        {
            get { return secondBeatField; }
            set { secondBeatField = value; }
        }

        [XmlIgnore]
        public bool secondBeatSpecified
        {
            get { return secondBeatFieldSpecified; }
            set { secondBeatFieldSpecified = value; }
        }

        [XmlAttribute("last-beat")]
        public decimal lastBeat
        {
            get { return lastBeatField; }
            set { lastBeatField = value; }
        }

        [XmlIgnore]
        public bool lastBeatSpecified
        {
            get { return lastBeatFieldSpecified; }
            set { lastBeatFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (EmptyTrillSound));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current emptytrillsound object into an XML document
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
        ///   Deserializes workflow markup into an emptytrillsound object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output emptytrillsound object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out EmptyTrillSound obj, out Exception exception)
        {
            exception = null;
            obj = default(EmptyTrillSound);
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

        public static bool Deserialize(string xml, out EmptyTrillSound obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static EmptyTrillSound Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((EmptyTrillSound)
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
        ///   Serializes current emptytrillsound object into file
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
        ///   Deserializes xml markup from file into an emptytrillsound object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output emptytrillsound object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out EmptyTrillSound obj, out Exception exception)
        {
            exception = null;
            obj = default(EmptyTrillSound);
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

        public static bool LoadFromFile(string fileName, out EmptyTrillSound obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static EmptyTrillSound LoadFromFile(string fileName)
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
        ///   Create a clone of this emptytrillsound object
        /// </summary>
        public virtual EmptyTrillSound Clone()
        {
            return ((EmptyTrillSound) (MemberwiseClone()));
        }

        #endregion
    }
}