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
    [XmlType(TypeName = "midi-instrument")]
    [XmlRoot("midi-instrument", Namespace = "", IsNullable = true)]
    public class MidiInstrument
    {
        private static XmlSerializer serializer;
        private decimal elevationField;

        private bool elevationFieldSpecified;

        private string idField;
        private string midiBankField;
        private string midiChannelField;

        private string midiNameField;

        private string midiProgramField;

        private string midiUnpitchedField;

        private decimal panField;

        private bool panFieldSpecified;
        private decimal volumeField;

        private bool volumeFieldSpecified;

        [XmlElement("midi-channel", DataType = "positiveInteger", Order = 0)]
        public string midiChannel
        {
            get { return midiChannelField; }
            set { midiChannelField = value; }
        }

        [XmlElement("midi-name", Order = 1)]
        public string midiName
        {
            get { return midiNameField; }
            set { midiNameField = value; }
        }

        [XmlElement("midi-bank", DataType = "positiveInteger", Order = 2)]
        public string midiBank
        {
            get { return midiBankField; }
            set { midiBankField = value; }
        }

        [XmlElement("midi-program", DataType = "positiveInteger", Order = 3)]
        public string midiProgram
        {
            get { return midiProgramField; }
            set { midiProgramField = value; }
        }

        [XmlElement("midi-unpitched", DataType = "positiveInteger", Order = 4)]
        public string midiUnpitched
        {
            get { return midiUnpitchedField; }
            set { midiUnpitchedField = value; }
        }

        [XmlElement(Order = 5)]
        public decimal volume
        {
            get { return volumeField; }
            set { volumeField = value; }
        }

        [XmlIgnore]
        public bool volumeSpecified
        {
            get { return volumeFieldSpecified; }
            set { volumeFieldSpecified = value; }
        }

        [XmlElement(Order = 6)]
        public decimal pan
        {
            get { return panField; }
            set { panField = value; }
        }

        [XmlIgnore]
        public bool panSpecified
        {
            get { return panFieldSpecified; }
            set { panFieldSpecified = value; }
        }

        [XmlElement(Order = 7)]
        public decimal elevation
        {
            get { return elevationField; }
            set { elevationField = value; }
        }

        [XmlIgnore]
        public bool elevationSpecified
        {
            get { return elevationFieldSpecified; }
            set { elevationFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "IDREF")]
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
                    serializer = new XmlSerializer(typeof (MidiInstrument));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current midiinstrument object into an XML document
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
        ///   Deserializes workflow markup into an midiinstrument object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output midiinstrument object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out MidiInstrument obj, out Exception exception)
        {
            exception = null;
            obj = default(MidiInstrument);
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

        public static bool Deserialize(string xml, out MidiInstrument obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static MidiInstrument Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((MidiInstrument)
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
        ///   Serializes current midiinstrument object into file
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
        ///   Deserializes xml markup from file into an midiinstrument object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output midiinstrument object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out MidiInstrument obj, out Exception exception)
        {
            exception = null;
            obj = default(MidiInstrument);
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

        public static bool LoadFromFile(string fileName, out MidiInstrument obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static MidiInstrument LoadFromFile(string fileName)
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
        ///   Create a clone of this midiinstrument object
        /// </summary>
        public virtual MidiInstrument Clone()
        {
            return ((MidiInstrument) (MemberwiseClone()));
        }

        #endregion
    }
}