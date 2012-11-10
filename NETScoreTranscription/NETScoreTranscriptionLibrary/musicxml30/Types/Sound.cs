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
    public class Sound
    {
        private static XmlSerializer serializer;
        private string codaField;
        private YesNo dacapoField;

        private bool dacapoFieldSpecified;

        private string dalsegnoField;
        private string damperPedalField;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;
        private decimal dynamicsField;

        private bool dynamicsFieldSpecified;
        private decimal elevationField;

        private bool elevationFieldSpecified;
        private string fineField;

        private YesNo forwardRepeatField;

        private bool forwardRepeatFieldSpecified;
        private object[] itemsField;

        private Offset offsetField;

        private decimal panField;

        private bool panFieldSpecified;
        private YesNo pizzicatoField;

        private bool pizzicatoFieldSpecified;
        private string segnoField;

        private string softPedalField;

        private string sostenutoPedalField;
        private decimal tempoField;

        private bool tempoFieldSpecified;
        private string timeOnlyField;
        private string tocodaField;

        [XmlElement("midi-device", typeof (MidiDevice), Order = 0)]
        [XmlElement("midi-instrument", typeof (MidiInstrument), Order = 0)]
        [XmlElement("play", typeof (Play), Order = 0)]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement(Order = 1)]
        public Offset offset
        {
            get { return offsetField; }
            set { offsetField = value; }
        }

        [XmlAttribute]
        public decimal tempo
        {
            get { return tempoField; }
            set { tempoField = value; }
        }

        [XmlIgnore]
        public bool tempoSpecified
        {
            get { return tempoFieldSpecified; }
            set { tempoFieldSpecified = value; }
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

        [XmlAttribute]
        public YesNo dacapo
        {
            get { return dacapoField; }
            set { dacapoField = value; }
        }

        [XmlIgnore]
        public bool dacapoSpecified
        {
            get { return dacapoFieldSpecified; }
            set { dacapoFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string segno
        {
            get { return segnoField; }
            set { segnoField = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string dalsegno
        {
            get { return dalsegnoField; }
            set { dalsegnoField = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string coda
        {
            get { return codaField; }
            set { codaField = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string tocoda
        {
            get { return tocodaField; }
            set { tocodaField = value; }
        }

        [XmlAttribute]
        public decimal divisions
        {
            get { return divisionsField; }
            set { divisionsField = value; }
        }

        [XmlIgnore]
        public bool divisionsSpecified
        {
            get { return divisionsFieldSpecified; }
            set { divisionsFieldSpecified = value; }
        }

        [XmlAttribute("forward-repeat")]
        public YesNo forwardRepeat
        {
            get { return forwardRepeatField; }
            set { forwardRepeatField = value; }
        }

        [XmlIgnore]
        public bool forwardRepeatSpecified
        {
            get { return forwardRepeatFieldSpecified; }
            set { forwardRepeatFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string fine
        {
            get { return fineField; }
            set { fineField = value; }
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

        [XmlAttribute]
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

        [XmlAttribute]
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

        [XmlAttribute("damper-pedal")]
        public string damperPedal
        {
            get { return damperPedalField; }
            set { damperPedalField = value; }
        }

        [XmlAttribute("soft-pedal")]
        public string softPedal
        {
            get { return softPedalField; }
            set { softPedalField = value; }
        }

        [XmlAttribute("sostenuto-pedal")]
        public string sostenutoPedal
        {
            get { return sostenutoPedalField; }
            set { sostenutoPedalField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Sound));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current sound object into an XML document
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
        ///   Deserializes workflow markup into an sound object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output sound object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Sound obj, out Exception exception)
        {
            exception = null;
            obj = default(Sound);
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

        public static bool Deserialize(string xml, out Sound obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Sound Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Sound)
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
        ///   Serializes current sound object into file
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
        ///   Deserializes xml markup from file into an sound object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output sound object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Sound obj, out Exception exception)
        {
            exception = null;
            obj = default(Sound);
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

        public static bool LoadFromFile(string fileName, out Sound obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Sound LoadFromFile(string fileName)
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
        ///   Create a clone of this sound object
        /// </summary>
        public virtual Sound Clone()
        {
            return ((Sound) (MemberwiseClone()));
        }

        #endregion
    }
}