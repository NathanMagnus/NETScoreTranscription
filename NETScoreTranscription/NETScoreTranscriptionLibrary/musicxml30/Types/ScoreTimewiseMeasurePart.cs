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
    [XmlType(AnonymousType = true)]
    public class ScoreTimewiseMeasurePart
    {
        private static XmlSerializer serializer;
        private string idField;
        private object[] itemsField;

        [XmlElement("attributes", typeof (Attributes), Order = 0)]
        [XmlElement("backup", typeof (Backup), Order = 0)]
        [XmlElement("barline", typeof (Barline), Order = 0)]
        [XmlElement("bookmark", typeof (Bookmark), Order = 0)]
        [XmlElement("direction", typeof (Direction), Order = 0)]
        [XmlElement("figured-bass", typeof (FiguredBass), Order = 0)]
        [XmlElement("forward", typeof (Forward), Order = 0)]
        [XmlElement("grouping", typeof (Grouping), Order = 0)]
        [XmlElement("harmony", typeof (Harmony), Order = 0)]
        [XmlElement("link", typeof (Link), Order = 0)]
        [XmlElement("note", typeof (Note), Order = 0)]
        [XmlElement("print", typeof (Print), Order = 0)]
        [XmlElement("sound", typeof (Sound), Order = 0)]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
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
                    serializer = new XmlSerializer(typeof (ScoreTimewiseMeasurePart));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current scoretimewiseMeasurePart object into an XML document
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
        ///   Deserializes workflow markup into an scoretimewiseMeasurePart object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output scoretimewiseMeasurePart object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScoreTimewiseMeasurePart obj, out Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewiseMeasurePart);
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

        public static bool Deserialize(string xml, out ScoreTimewiseMeasurePart obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScoreTimewiseMeasurePart Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((ScoreTimewiseMeasurePart)
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
        ///   Serializes current scoretimewiseMeasurePart object into file
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
        ///   Deserializes xml markup from file into an scoretimewiseMeasurePart object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output scoretimewiseMeasurePart object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScoreTimewiseMeasurePart obj, out Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewiseMeasurePart);
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

        public static bool LoadFromFile(string fileName, out ScoreTimewiseMeasurePart obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScoreTimewiseMeasurePart LoadFromFile(string fileName)
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
        ///   Create a clone of this scoretimewiseMeasurePart object
        /// </summary>
        public virtual ScoreTimewiseMeasurePart Clone()
        {
            return ((ScoreTimewiseMeasurePart) (MemberwiseClone()));
        }

        #endregion
    }
}