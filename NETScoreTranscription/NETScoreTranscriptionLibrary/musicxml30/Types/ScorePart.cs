using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "score-part")]
    [System.Xml.Serialization.XmlRootAttribute("score-part", Namespace = "", IsNullable = true)]
    public class ScorePart
    {

        private Identification identificationField;

        private PartName partNameField;

        private NameDisplay partNamedisplayField;

        private PartName partAbbreviationField;

        private NameDisplay partAbbreviationdisplayField;

        private string[] groupField;

        private ScoreInstrument[] scoreinstrumentField;

        private object[] itemsField;

        private string idField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Identification identification
        {
            get
            {
                return identificationField;
            }
            set
            {
                identificationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-name", Order = 1)]
        public PartName partName
        {
            get
            {
                return partNameField;
            }
            set
            {
                partNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-name-display", Order = 2)]
        public NameDisplay partNamedisplay
        {
            get
            {
                return partNamedisplayField;
            }
            set
            {
                partNamedisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation", Order = 3)]
        public PartName partAbbreviation
        {
            get
            {
                return partAbbreviationField;
            }
            set
            {
                partAbbreviationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display", Order = 4)]
        public NameDisplay partAbbreviationdisplay
        {
            get
            {
                return partAbbreviationdisplayField;
            }
            set
            {
                partAbbreviationdisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group", Order = 5)]
        public string[] group
        {
            get
            {
                return groupField;
            }
            set
            {
                groupField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("score-instrument", Order = 6)]
        public ScoreInstrument[] scoreinstrument
        {
            get
            {
                return scoreinstrumentField;
            }
            set
            {
                scoreinstrumentField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("midi-device", typeof(MidiDevice), Order = 7)]
        [System.Xml.Serialization.XmlElementAttribute("midi-instrument", typeof(MidiInstrument), Order = 7)]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ScorePart));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current scorepart object into an XML document
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
        /// Deserializes workflow markup into an scorepart object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output scorepart object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScorePart obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScorePart);
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

        public static bool Deserialize(string xml, out ScorePart obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScorePart Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((ScorePart)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current scorepart object into file
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
        /// Deserializes xml markup from file into an scorepart object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output scorepart object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScorePart obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScorePart);
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

        public static bool LoadFromFile(string fileName, out ScorePart obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScorePart LoadFromFile(string fileName)
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
        /// Create a clone of this scorepart object
        /// </summary>
        public virtual ScorePart Clone()
        {
            return ((ScorePart)(MemberwiseClone()));
        }
        #endregion
    }
}