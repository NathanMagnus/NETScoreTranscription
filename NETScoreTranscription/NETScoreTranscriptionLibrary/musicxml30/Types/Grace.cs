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
    public class Grace
    {
        private static XmlSerializer serializer;
        private decimal makeTimeField;

        private bool makeTimeFieldSpecified;

        private YesNo slashField;

        private bool slashFieldSpecified;
        private decimal stealTimeFollowingField;

        private bool stealTimeFollowingFieldSpecified;
        private decimal stealTimePreviousField;

        private bool stealTimePreviousFieldSpecified;

        [XmlAttribute("steal-time-previous")]
        public decimal stealTimePrevious
        {
            get { return stealTimePreviousField; }
            set { stealTimePreviousField = value; }
        }

        [XmlIgnore]
        public bool stealTimePreviousSpecified
        {
            get { return stealTimePreviousFieldSpecified; }
            set { stealTimePreviousFieldSpecified = value; }
        }

        [XmlAttribute("steal-time-following")]
        public decimal stealTimeFollowing
        {
            get { return stealTimeFollowingField; }
            set { stealTimeFollowingField = value; }
        }

        [XmlIgnore]
        public bool stealTimeFollowingSpecified
        {
            get { return stealTimeFollowingFieldSpecified; }
            set { stealTimeFollowingFieldSpecified = value; }
        }

        [XmlAttribute("make-time")]
        public decimal makeTime
        {
            get { return makeTimeField; }
            set { makeTimeField = value; }
        }

        [XmlIgnore]
        public bool makeTimeSpecified
        {
            get { return makeTimeFieldSpecified; }
            set { makeTimeFieldSpecified = value; }
        }

        [XmlAttribute]
        public YesNo slash
        {
            get { return slashField; }
            set { slashField = value; }
        }

        [XmlIgnore]
        public bool slashSpecified
        {
            get { return slashFieldSpecified; }
            set { slashFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Grace));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current grace object into an XML document
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
        ///   Deserializes workflow markup into an grace object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output grace object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Grace obj, out Exception exception)
        {
            exception = null;
            obj = default(Grace);
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

        public static bool Deserialize(string xml, out Grace obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Grace Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Grace)
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
        ///   Serializes current grace object into file
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
        ///   Deserializes xml markup from file into an grace object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output grace object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Grace obj, out Exception exception)
        {
            exception = null;
            obj = default(Grace);
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

        public static bool LoadFromFile(string fileName, out Grace obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Grace LoadFromFile(string fileName)
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
        ///   Create a clone of this grace object
        /// </summary>
        public virtual Grace Clone()
        {
            return ((Grace) (MemberwiseClone()));
        }

        #endregion
    }
}