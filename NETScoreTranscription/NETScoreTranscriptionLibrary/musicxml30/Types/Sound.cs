using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Sound
    {

        private object[] itemsField;

        private Offset offsetField;

        private decimal tempoField;

        private bool tempoFieldSpecified;

        private decimal dynamicsField;

        private bool dynamicsFieldSpecified;

        private YesNo dacapoField;

        private bool dacapoFieldSpecified;

        private string segnoField;

        private string dalsegnoField;

        private string codaField;

        private string tocodaField;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private YesNo forwardRepeatField;

        private bool forwardRepeatFieldSpecified;

        private string fineField;

        private string timeOnlyField;

        private YesNo pizzicatoField;

        private bool pizzicatoFieldSpecified;

        private decimal panField;

        private bool panFieldSpecified;

        private decimal elevationField;

        private bool elevationFieldSpecified;

        private string damperPedalField;

        private string softPedalField;

        private string sostenutoPedalField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("midi-device", typeof(MidiDevice), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("midi-instrument", typeof(MidiInstrument), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("play", typeof(Play), Order = 0)]
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

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal tempo
        {
            get
            {
                return tempoField;
            }
            set
            {
                tempoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool tempoSpecified
        {
            get
            {
                return tempoFieldSpecified;
            }
            set
            {
                tempoFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal dynamics
        {
            get
            {
                return dynamicsField;
            }
            set
            {
                dynamicsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool dynamicsSpecified
        {
            get
            {
                return dynamicsFieldSpecified;
            }
            set
            {
                dynamicsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo dacapo
        {
            get
            {
                return dacapoField;
            }
            set
            {
                dacapoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool dacapoSpecified
        {
            get
            {
                return dacapoFieldSpecified;
            }
            set
            {
                dacapoFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string segno
        {
            get
            {
                return segnoField;
            }
            set
            {
                segnoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string dalsegno
        {
            get
            {
                return dalsegnoField;
            }
            set
            {
                dalsegnoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string coda
        {
            get
            {
                return codaField;
            }
            set
            {
                codaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string tocoda
        {
            get
            {
                return tocodaField;
            }
            set
            {
                tocodaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal divisions
        {
            get
            {
                return divisionsField;
            }
            set
            {
                divisionsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool divisionsSpecified
        {
            get
            {
                return divisionsFieldSpecified;
            }
            set
            {
                divisionsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("forward-repeat")]
        public YesNo forwardRepeat
        {
            get
            {
                return forwardRepeatField;
            }
            set
            {
                forwardRepeatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool forwardRepeatSpecified
        {
            get
            {
                return forwardRepeatFieldSpecified;
            }
            set
            {
                forwardRepeatFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string fine
        {
            get
            {
                return fineField;
            }
            set
            {
                fineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("time-only", DataType = "token")]
        public string timeOnly
        {
            get
            {
                return timeOnlyField;
            }
            set
            {
                timeOnlyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo pizzicato
        {
            get
            {
                return pizzicatoField;
            }
            set
            {
                pizzicatoField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool pizzicatoSpecified
        {
            get
            {
                return pizzicatoFieldSpecified;
            }
            set
            {
                pizzicatoFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
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

        [System.Xml.Serialization.XmlAttributeAttribute]
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

        [System.Xml.Serialization.XmlAttributeAttribute("damper-pedal")]
        public string damperPedal
        {
            get
            {
                return damperPedalField;
            }
            set
            {
                damperPedalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("soft-pedal")]
        public string softPedal
        {
            get
            {
                return softPedalField;
            }
            set
            {
                softPedalField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("sostenuto-pedal")]
        public string sostenutoPedal
        {
            get
            {
                return sostenutoPedalField;
            }
            set
            {
                sostenutoPedalField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Sound));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current sound object into an XML document
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
        /// Deserializes workflow markup into an sound object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output sound object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Sound obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Sound);
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

        public static bool Deserialize(string xml, out Sound obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Sound Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Sound)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current sound object into file
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
        /// Deserializes xml markup from file into an sound object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output sound object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Sound obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Sound);
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

        public static bool LoadFromFile(string fileName, out Sound obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Sound LoadFromFile(string fileName)
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
        /// Create a clone of this sound object
        /// </summary>
        public virtual Sound Clone()
        {
            return ((Sound)(MemberwiseClone()));
        }
        #endregion
    }
}