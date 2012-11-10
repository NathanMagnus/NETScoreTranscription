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
    public class Technical
    {
        private static XmlSerializer serializer;
        private ItemsChoiceType3[] itemsElementNameField;
        private object[] itemsField;

        [XmlElement("arrow", typeof (Arrow), Order = 0)]
        [XmlElement("bend", typeof (Bend), Order = 0)]
        [XmlElement("double-tongue", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("down-bow", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("fingering", typeof (Fingering), Order = 0)]
        [XmlElement("fingernails", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("fret", typeof (Fret), Order = 0)]
        [XmlElement("hammer-on", typeof (HammeronPulloff), Order = 0)]
        [XmlElement("handbell", typeof (Handbell), Order = 0)]
        [XmlElement("harmonic", typeof (Harmonic), Order = 0)]
        [XmlElement("heel", typeof (HeelToe), Order = 0)]
        [XmlElement("hole", typeof (Hole), Order = 0)]
        [XmlElement("open-string", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("other-technical", typeof (PlacementText), Order = 0)]
        [XmlElement("pluck", typeof (PlacementText), Order = 0)]
        [XmlElement("pull-off", typeof (HammeronPulloff), Order = 0)]
        [XmlElement("snap-pizzicato", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("stopped", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("string", typeof (@string), Order = 0)]
        [XmlElement("tap", typeof (PlacementText), Order = 0)]
        [XmlElement("thumb-position", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("toe", typeof (HeelToe), Order = 0)]
        [XmlElement("triple-tongue", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("up-bow", typeof (EmptyPlacement), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore]
        public ItemsChoiceType3[] ItemsElementName
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
                    serializer = new XmlSerializer(typeof (Technical));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current technical object into an XML document
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
        ///   Deserializes workflow markup into an technical object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output technical object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Technical obj, out Exception exception)
        {
            exception = null;
            obj = default(Technical);
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

        public static bool Deserialize(string xml, out Technical obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Technical Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Technical)
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
        ///   Serializes current technical object into file
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
        ///   Deserializes xml markup from file into an technical object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output technical object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Technical obj, out Exception exception)
        {
            exception = null;
            obj = default(Technical);
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

        public static bool LoadFromFile(string fileName, out Technical obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Technical LoadFromFile(string fileName)
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
        ///   Create a clone of this technical object
        /// </summary>
        public virtual Technical Clone()
        {
            return ((Technical) (MemberwiseClone()));
        }

        #endregion
    }
}