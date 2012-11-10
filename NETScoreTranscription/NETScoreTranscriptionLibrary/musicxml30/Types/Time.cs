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
    public class Time
    {
        private static XmlSerializer serializer;
        private ItemsChoiceType10[] itemsElementNameField;
        private object[] itemsField;

        private string numberField;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;
        private TimeSeparator separatorField;

        private bool separatorFieldSpecified;
        private TimeSymbol symbolField;

        private bool symbolFieldSpecified;

        [XmlElement("beat-type", typeof (string))]
        public string BeatType { get; set; }

        [XmlElement("beats", typeof (string))]
        public string Beats { get; set; }

        [XmlElement("interchangeable", typeof (Interchangeable))]
        public Interchangeable Interchangeable { get; set; }

        [XmlElement("senza-misura", typeof (string))]
        public string SenzaMisura { get; set; }

        /*
        [System.Xml.Serialization.XmlElementAttribute("beats", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("beat-type", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("interchangeable", typeof(Interchangeable), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("senza-misura", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        */

        [XmlElement("ItemsElementName", Order = 2)]
        [XmlIgnore]
        public ItemsChoiceType10[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }

        [XmlAttribute(DataType = "positiveInteger")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        [XmlAttribute]
        public TimeSymbol symbol
        {
            get { return symbolField; }
            set { symbolField = value; }
        }

        [XmlIgnore]
        public bool symbolSpecified
        {
            get { return symbolFieldSpecified; }
            set { symbolFieldSpecified = value; }
        }

        [XmlAttribute]
        public TimeSeparator separator
        {
            get { return separatorField; }
            set { separatorField = value; }
        }

        [XmlIgnore]
        public bool separatorSpecified
        {
            get { return separatorFieldSpecified; }
            set { separatorFieldSpecified = value; }
        }

        [XmlAttribute("print-object")]
        public YesNo printObject
        {
            get { return printObjectField; }
            set { printObjectField = value; }
        }

        [XmlIgnore]
        public bool printObjectSpecified
        {
            get { return printObjectFieldSpecified; }
            set { printObjectFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Time));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current time object into an XML document
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
        ///   Deserializes workflow markup into an time object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output time object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Time obj, out Exception exception)
        {
            exception = null;
            obj = default(Time);
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

        public static bool Deserialize(string xml, out Time obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Time Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Time)
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
        ///   Serializes current time object into file
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
        ///   Deserializes xml markup from file into an time object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output time object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Time obj, out Exception exception)
        {
            exception = null;
            obj = default(Time);
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

        public static bool LoadFromFile(string fileName, out Time obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Time LoadFromFile(string fileName)
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
        ///   Create a clone of this time object
        /// </summary>
        public virtual Time Clone()
        {
            return ((Time) (MemberwiseClone()));
        }

        #endregion
    }
}