using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "direction-type")]
    [System.Xml.Serialization.XmlRootAttribute("direction-type", Namespace = "", IsNullable = true)]
    public class DirectionType
    {

        private object[] itemsField;

        private ItemsChoiceType7[] itemsElementNameField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("accordion-registration", typeof(AccordionRegistration), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("bracket", typeof(Bracket), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("coda", typeof(EmptyPrintStyleAlign), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("damp", typeof(EmptyPrintStyleAlign), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("damp-all", typeof(EmptyPrintStyleAlign), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("dashes", typeof(Dashes), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("dynamics", typeof(Dynamics), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("eyeglasses", typeof(EmptyPrintStyleAlign), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("harp-pedals", typeof(HarpPedals), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("image", typeof(Image), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("metronome", typeof(Metronome), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("octave-shift", typeof(OctaveShift), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("other-direction", typeof(OtherDirection), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("pedal", typeof(Pedal), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("percussion", typeof(Percussion), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("principal-voice", typeof(PrincipalVoice), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("rehearsal", typeof(FormattedText), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("scordatura", typeof(Scordatura), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("segno", typeof(EmptyPrintStyleAlign), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("string-mute", typeof(StringMute), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("wedge", typeof(Wedge), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("words", typeof(FormattedText), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
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

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ItemsChoiceType7[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(DirectionType));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current directiontype object into an XML document
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
        /// Deserializes workflow markup into an directiontype object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output directiontype object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out DirectionType obj, out System.Exception exception)
        {
            exception = null;
            obj = default(DirectionType);
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

        public static bool Deserialize(string xml, out DirectionType obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static DirectionType Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((DirectionType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current directiontype object into file
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
        /// Deserializes xml markup from file into an directiontype object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output directiontype object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out DirectionType obj, out System.Exception exception)
        {
            exception = null;
            obj = default(DirectionType);
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

        public static bool LoadFromFile(string fileName, out DirectionType obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static DirectionType LoadFromFile(string fileName)
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
        /// Create a clone of this directiontype object
        /// </summary>
        public virtual DirectionType Clone()
        {
            return ((DirectionType)(MemberwiseClone()));
        }
        #endregion
    }
}