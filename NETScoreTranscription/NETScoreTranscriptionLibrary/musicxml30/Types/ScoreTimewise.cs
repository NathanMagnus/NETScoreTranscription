using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("score-timewise", Namespace = "", IsNullable = false)]
    public class ScoreTimewise
    {

        private Work workField;

        private string movementNumberField;

        private string movementTitleField;

        private Identification identificationField;

        private Defaults defaultsField;

        private Credit[] creditField;

        private PartList partListField;

        private ScoreTimewiseMeasure[] measureField;

        private string versionField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public ScoreTimewise()
        {
            versionField = "1.0";
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Work work
        {
            get
            {
                return workField;
            }
            set
            {
                workField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("movement-number", Order = 1)]
        public string movementNumber
        {
            get
            {
                return movementNumberField;
            }
            set
            {
                movementNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("movement-title", Order = 2)]
        public string movementTitle
        {
            get
            {
                return movementTitleField;
            }
            set
            {
                movementTitleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public Defaults defaults
        {
            get
            {
                return defaultsField;
            }
            set
            {
                defaultsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("credit", Order = 5)]
        public Credit[] credit
        {
            get
            {
                return creditField;
            }
            set
            {
                creditField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-list", Order = 6)]
        public PartList partList
        {
            get
            {
                return partListField;
            }
            set
            {
                partListField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("measure", Order = 7)]
        public ScoreTimewiseMeasure[] measure
        {
            get
            {
                return measureField;
            }
            set
            {
                measureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("1.0")]
        public string version
        {
            get
            {
                return versionField;
            }
            set
            {
                versionField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ScoreTimewise));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current scoretimewise object into an XML document
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
        /// Deserializes workflow markup into an scoretimewise object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output scoretimewise object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ScoreTimewise obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewise);
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

        public static bool Deserialize(string xml, out ScoreTimewise obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ScoreTimewise Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((ScoreTimewise)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current scoretimewise object into file
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
        /// Deserializes xml markup from file into an scoretimewise object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output scoretimewise object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ScoreTimewise obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ScoreTimewise);
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

        public static bool LoadFromFile(string fileName, out ScoreTimewise obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ScoreTimewise LoadFromFile(string fileName)
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
        /// Create a clone of this scoretimewise object
        /// </summary>
        public virtual ScoreTimewise Clone()
        {
            return ((ScoreTimewise)(MemberwiseClone()));
        }
        #endregion
    }
}