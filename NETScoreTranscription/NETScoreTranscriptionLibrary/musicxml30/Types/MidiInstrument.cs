using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "midi-instrument")]
    [System.Xml.Serialization.XmlRootAttribute("midi-instrument", Namespace = "", IsNullable = true)]
    public class MidiInstrument
    {

        private string midiChannelField;

        private string midiNameField;

        private string midiBankField;

        private string midiProgramField;

        private string midiUnpitchedField;

        private decimal volumeField;

        private bool volumeFieldSpecified;

        private decimal panField;

        private bool panFieldSpecified;

        private decimal elevationField;

        private bool elevationFieldSpecified;

        private string idField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("midi-channel", DataType = "positiveInteger", Order = 0)]
        public string midiChannel
        {
            get
            {
                return midiChannelField;
            }
            set
            {
                midiChannelField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("midi-name", Order = 1)]
        public string midiName
        {
            get
            {
                return midiNameField;
            }
            set
            {
                midiNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("midi-bank", DataType = "positiveInteger", Order = 2)]
        public string midiBank
        {
            get
            {
                return midiBankField;
            }
            set
            {
                midiBankField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("midi-program", DataType = "positiveInteger", Order = 3)]
        public string midiProgram
        {
            get
            {
                return midiProgramField;
            }
            set
            {
                midiProgramField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("midi-unpitched", DataType = "positiveInteger", Order = 4)]
        public string midiUnpitched
        {
            get
            {
                return midiUnpitchedField;
            }
            set
            {
                midiUnpitchedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public decimal volume
        {
            get
            {
                return volumeField;
            }
            set
            {
                volumeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool volumeSpecified
        {
            get
            {
                return volumeFieldSpecified;
            }
            set
            {
                volumeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public decimal pan
        {
            get
            {
                return panField;
            }
            set
            {
                panField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool panSpecified
        {
            get
            {
                return panFieldSpecified;
            }
            set
            {
                panFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public decimal elevation
        {
            get
            {
                return elevationField;
            }
            set
            {
                elevationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool elevationSpecified
        {
            get
            {
                return elevationFieldSpecified;
            }
            set
            {
                elevationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(MidiInstrument));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current midiinstrument object into an XML document
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
        /// Deserializes workflow markup into an midiinstrument object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output midiinstrument object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out MidiInstrument obj, out System.Exception exception)
        {
            exception = null;
            obj = default(MidiInstrument);
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

        public static bool Deserialize(string xml, out MidiInstrument obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static MidiInstrument Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((MidiInstrument)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current midiinstrument object into file
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
        /// Deserializes xml markup from file into an midiinstrument object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output midiinstrument object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out MidiInstrument obj, out System.Exception exception)
        {
            exception = null;
            obj = default(MidiInstrument);
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

        public static bool LoadFromFile(string fileName, out MidiInstrument obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static MidiInstrument LoadFromFile(string fileName)
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
        /// Create a clone of this midiinstrument object
        /// </summary>
        public virtual MidiInstrument Clone()
        {
            return ((MidiInstrument)(MemberwiseClone()));
        }
        #endregion
    }
}