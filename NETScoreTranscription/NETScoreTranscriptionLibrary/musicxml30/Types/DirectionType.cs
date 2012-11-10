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
    [XmlType(TypeName = "direction-type")]
    [XmlRoot("direction-type", Namespace = "", IsNullable = true)]
    public class DirectionType
    {
        private static XmlSerializer serializer;
        private ItemsChoiceType7[] itemsElementNameField;
        private object[] itemsField;

        [XmlElement("accordion-registration", typeof (AccordionRegistration), Order = 0)]
        [XmlElement("bracket", typeof (Bracket), Order = 0)]
        [XmlElement("coda", typeof (EmptyPrintStyleAlign), Order = 0)]
        [XmlElement("damp", typeof (EmptyPrintStyleAlign), Order = 0)]
        [XmlElement("damp-all", typeof (EmptyPrintStyleAlign), Order = 0)]
        [XmlElement("dashes", typeof (Dashes), Order = 0)]
        [XmlElement("dynamics", typeof (Dynamics), Order = 0)]
        [XmlElement("eyeglasses", typeof (EmptyPrintStyleAlign), Order = 0)]
        [XmlElement("harp-pedals", typeof (HarpPedals), Order = 0)]
        [XmlElement("image", typeof (Image), Order = 0)]
        [XmlElement("metronome", typeof (Metronome), Order = 0)]
        [XmlElement("octave-shift", typeof (OctaveShift), Order = 0)]
        [XmlElement("other-direction", typeof (OtherDirection), Order = 0)]
        [XmlElement("pedal", typeof (Pedal), Order = 0)]
        [XmlElement("percussion", typeof (Percussion), Order = 0)]
        [XmlElement("principal-voice", typeof (PrincipalVoice), Order = 0)]
        [XmlElement("rehearsal", typeof (FormattedText), Order = 0)]
        [XmlElement("scordatura", typeof (Scordatura), Order = 0)]
        [XmlElement("segno", typeof (EmptyPrintStyleAlign), Order = 0)]
        [XmlElement("string-mute", typeof (StringMute), Order = 0)]
        [XmlElement("wedge", typeof (Wedge), Order = 0)]
        [XmlElement("words", typeof (FormattedText), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore]
        public ItemsChoiceType7[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (DirectionType));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current directiontype object into an XML document
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
        ///   Deserializes workflow markup into an directiontype object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output directiontype object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out DirectionType obj, out Exception exception)
        {
            exception = null;
            obj = default(DirectionType);
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

        public static bool Deserialize(string xml, out DirectionType obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static DirectionType Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((DirectionType)
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
        ///   Serializes current directiontype object into file
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
        ///   Deserializes xml markup from file into an directiontype object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output directiontype object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out DirectionType obj, out Exception exception)
        {
            exception = null;
            obj = default(DirectionType);
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

        public static bool LoadFromFile(string fileName, out DirectionType obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static DirectionType LoadFromFile(string fileName)
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
        ///   Create a clone of this directiontype object
        /// </summary>
        public virtual DirectionType Clone()
        {
            return ((DirectionType) (MemberwiseClone()));
        }

        #endregion
    }
}