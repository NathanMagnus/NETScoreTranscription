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
    [XmlType(TypeName = "score-part")]
    [XmlRoot("score-part", Namespace = "", IsNullable = true)]
    public class ScorePart
    {
        private static XmlSerializer serializer;
        private string[] groupField;
        private string idField;
        private Identification identificationField;
        private object[] itemsField;

        private PartName partAbbreviationField;

        private NameDisplay partAbbreviationdisplayField;
        private PartName partNameField;

        private NameDisplay partNamedisplayField;

        private ScoreInstrument[] scoreinstrumentField;

        [XmlElement(Order = 0)]
        public Identification identification
        {
            get { return identificationField; }
            set { identificationField = value; }
        }

        [XmlElement("part-name", Order = 1)]
        public PartName partName
        {
            get { return partNameField; }
            set { partNameField = value; }
        }

        [XmlElement("part-name-display", Order = 2)]
        public NameDisplay partNamedisplay
        {
            get { return partNamedisplayField; }
            set { partNamedisplayField = value; }
        }

        [XmlElement("part-abbreviation", Order = 3)]
        public PartName partAbbreviation
        {
            get { return partAbbreviationField; }
            set { partAbbreviationField = value; }
        }

        [XmlElement("part-abbreviation-display", Order = 4)]
        public NameDisplay partAbbreviationdisplay
        {
            get { return partAbbreviationdisplayField; }
            set { partAbbreviationdisplayField = value; }
        }

        [XmlElement("group", Order = 5)]
        public string[] group
        {
            get { return groupField; }
            set { groupField = value; }
        }

        [XmlElement("score-instrument", Order = 6)]
        public ScoreInstrument[] scoreinstrument
        {
            get { return scoreinstrumentField; }
            set { scoreinstrumentField = value; }
        }

        [XmlElement("midi-device", typeof (MidiDevice), Order = 7)]
        [XmlElement("midi-instrument", typeof (MidiInstrument), Order = 7)]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlAttribute(DataType = "ID")]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (ScorePart));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current scorepart object into an XML document
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
        ///   Deserializes workflow markup into an scorepart object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output scorepart object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScorePart obj, out Exception exception)
        {
            exception = null;
            obj = default(ScorePart);
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

        public static bool Deserialize(string xml, out ScorePart obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScorePart Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((ScorePart)
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
        ///   Serializes current scorepart object into file
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
        ///   Deserializes xml markup from file into an scorepart object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output scorepart object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScorePart obj, out Exception exception)
        {
            exception = null;
            obj = default(ScorePart);
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

        public static bool LoadFromFile(string fileName, out ScorePart obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScorePart LoadFromFile(string fileName)
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
        ///   Create a clone of this scorepart object
        /// </summary>
        public virtual ScorePart Clone()
        {
            return ((ScorePart) (MemberwiseClone()));
        }

        #endregion
    }
}