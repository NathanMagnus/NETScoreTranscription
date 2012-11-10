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
    [XmlType(TypeName = "system-layout")]
    [XmlRoot("system-layout", Namespace = "", IsNullable = true)]
    public class SystemLayout
    {
        private static XmlSerializer serializer;
        private decimal systemDistanceField;

        private bool systemDistanceFieldSpecified;
        private SystemDividers systemDividersField;
        private SystemMargins systemMarginsField;

        private decimal topSystemDistanceField;

        private bool topSystemDistanceFieldSpecified;

        [XmlElement("system-margins", Order = 0)]
        public SystemMargins systemMargins
        {
            get { return systemMarginsField; }
            set { systemMarginsField = value; }
        }

        [XmlElement("system-distance", Order = 1)]
        public decimal systemDistance
        {
            get { return systemDistanceField; }
            set { systemDistanceField = value; }
        }

        [XmlIgnore]
        public bool systemDistanceSpecified
        {
            get { return systemDistanceFieldSpecified; }
            set { systemDistanceFieldSpecified = value; }
        }

        [XmlElement("top-system-distance", Order = 2)]
        public decimal topSystemDistance
        {
            get { return topSystemDistanceField; }
            set { topSystemDistanceField = value; }
        }

        [XmlIgnore]
        public bool topSystemDistanceSpecified
        {
            get { return topSystemDistanceFieldSpecified; }
            set { topSystemDistanceFieldSpecified = value; }
        }

        [XmlElement("system-dividers", Order = 3)]
        public SystemDividers systemDividers
        {
            get { return systemDividersField; }
            set { systemDividersField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (SystemLayout));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current systemLayout object into an XML document
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
        ///   Deserializes workflow markup into an systemLayout object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output systemLayout object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out SystemLayout obj, out Exception exception)
        {
            exception = null;
            obj = default(SystemLayout);
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

        public static bool Deserialize(string xml, out SystemLayout obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static SystemLayout Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((SystemLayout)
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
        ///   Serializes current systemLayout object into file
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
        ///   Deserializes xml markup from file into an systemLayout object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output systemLayout object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out SystemLayout obj, out Exception exception)
        {
            exception = null;
            obj = default(SystemLayout);
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

        public static bool LoadFromFile(string fileName, out SystemLayout obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static SystemLayout LoadFromFile(string fileName)
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
        ///   Create a clone of this systemLayout object
        /// </summary>
        public virtual SystemLayout Clone()
        {
            return ((SystemLayout) (MemberwiseClone()));
        }

        #endregion
    }
}