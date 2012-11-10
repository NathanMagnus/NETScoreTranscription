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
    [XmlRoot("score-timewise", Namespace = "", IsNullable = false)]
    public class ScoreTimewise
    {
        private static XmlSerializer serializer;
        private Credit[] creditField;
        private Defaults defaultsField;
        private Identification identificationField;
        private ScoreTimewiseMeasure[] measureField;
        private string movementNumberField;

        private string movementTitleField;

        private PartList partListField;

        private string versionField;
        private Work workField;

        public ScoreTimewise()
        {
            versionField = "1.0";
        }

        [XmlElement(Order = 0)]
        public Work work
        {
            get { return workField; }
            set { workField = value; }
        }

        [XmlElement("movement-number", Order = 1)]
        public string movementNumber
        {
            get { return movementNumberField; }
            set { movementNumberField = value; }
        }

        [XmlElement("movement-title", Order = 2)]
        public string movementTitle
        {
            get { return movementTitleField; }
            set { movementTitleField = value; }
        }

        [XmlElement(Order = 3)]
        public Identification identification
        {
            get { return identificationField; }
            set { identificationField = value; }
        }

        [XmlElement(Order = 4)]
        public Defaults defaults
        {
            get { return defaultsField; }
            set { defaultsField = value; }
        }

        [XmlElement("credit", Order = 5)]
        public Credit[] credit
        {
            get { return creditField; }
            set { creditField = value; }
        }

        [XmlElement("part-list", Order = 6)]
        public PartList partList
        {
            get { return partListField; }
            set { partListField = value; }
        }

        [XmlElement("measure", Order = 7)]
        public ScoreTimewiseMeasure[] measure
        {
            get { return measureField; }
            set { measureField = value; }
        }

        [XmlAttribute(DataType = "token")]
        [DefaultValue("1.0")]
        public string version
        {
            get { return versionField; }
            set { versionField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (ScoreTimewise));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current scoretimewise object into an XML document
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
        ///   Deserializes workflow markup into an scoretimewise object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output scoretimewise object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScoreTimewise obj, out Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewise);
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

        public static bool Deserialize(string xml, out ScoreTimewise obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScoreTimewise Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((ScoreTimewise)
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
        ///   Serializes current scoretimewise object into file
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
        ///   Deserializes xml markup from file into an scoretimewise object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output scoretimewise object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScoreTimewise obj, out Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewise);
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

        public static bool LoadFromFile(string fileName, out ScoreTimewise obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScoreTimewise LoadFromFile(string fileName)
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
        ///   Create a clone of this scoretimewise object
        /// </summary>
        public virtual ScoreTimewise Clone()
        {
            return ((ScoreTimewise) (MemberwiseClone()));
        }

        #endregion
    }
}