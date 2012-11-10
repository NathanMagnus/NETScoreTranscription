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
    public class Print
    {
        private static XmlSerializer serializer;
        private string blankPageField;
        private MeasureLayout measureLayoutField;

        private MeasureNumbering measureNumberingField;

        private YesNo newPageField;

        private bool newPageFieldSpecified;
        private YesNo newSystemField;

        private bool newSystemFieldSpecified;
        private PageLayout pageLayoutField;

        private string pageNumberField;
        private NameDisplay partAbbreviationDisplayField;
        private NameDisplay partNameDisplayField;
        private StaffLayout[] staffLayoutField;
        private decimal staffSpacingField;

        private bool staffSpacingFieldSpecified;
        private SystemLayout systemLayoutField;

        [XmlElement("page-layout", Order = 0)]
        public PageLayout pageLayout
        {
            get { return pageLayoutField; }
            set { pageLayoutField = value; }
        }

        [XmlElement("system-layout", Order = 1)]
        public SystemLayout systemLayout
        {
            get { return systemLayoutField; }
            set { systemLayoutField = value; }
        }

        [XmlElement("staff-layout", Order = 2)]
        public StaffLayout[] staffLayout
        {
            get { return staffLayoutField; }
            set { staffLayoutField = value; }
        }

        [XmlElement("measure-layout", Order = 3)]
        public MeasureLayout measureLayout
        {
            get { return measureLayoutField; }
            set { measureLayoutField = value; }
        }

        [XmlElement("measure-numbering", Order = 4)]
        public MeasureNumbering measureNumbering
        {
            get { return measureNumberingField; }
            set { measureNumberingField = value; }
        }

        [XmlElement("part-name-display", Order = 5)]
        public NameDisplay partNameDisplay
        {
            get { return partNameDisplayField; }
            set { partNameDisplayField = value; }
        }

        [XmlElement("part-abbreviation-display", Order = 6)]
        public NameDisplay partAbbreviationDisplay
        {
            get { return partAbbreviationDisplayField; }
            set { partAbbreviationDisplayField = value; }
        }

        [XmlAttribute("staff-spacing")]
        public decimal staffSpacing
        {
            get { return staffSpacingField; }
            set { staffSpacingField = value; }
        }

        [XmlIgnore]
        public bool staffSpacingSpecified
        {
            get { return staffSpacingFieldSpecified; }
            set { staffSpacingFieldSpecified = value; }
        }

        [XmlAttribute("new-system")]
        public YesNo newSystem
        {
            get { return newSystemField; }
            set { newSystemField = value; }
        }

        [XmlIgnore]
        public bool newSystemSpecified
        {
            get { return newSystemFieldSpecified; }
            set { newSystemFieldSpecified = value; }
        }

        [XmlAttribute("new-page")]
        public YesNo newPage
        {
            get { return newPageField; }
            set { newPageField = value; }
        }

        [XmlIgnore]
        public bool newPageSpecified
        {
            get { return newPageFieldSpecified; }
            set { newPageFieldSpecified = value; }
        }

        [XmlAttribute("blank-page", DataType = "positiveInteger")]
        public string blankPage
        {
            get { return blankPageField; }
            set { blankPageField = value; }
        }

        [XmlAttribute("page-number", DataType = "token")]
        public string pageNumber
        {
            get { return pageNumberField; }
            set { pageNumberField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Print));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current print object into an XML document
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
        ///   Deserializes workflow markup into an print object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output print object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Print obj, out Exception exception)
        {
            exception = null;
            obj = default(Print);
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

        public static bool Deserialize(string xml, out Print obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Print Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Print)
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
        ///   Serializes current print object into file
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
        ///   Deserializes xml markup from file into an print object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output print object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Print obj, out Exception exception)
        {
            exception = null;
            obj = default(Print);
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

        public static bool LoadFromFile(string fileName, out Print obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Print LoadFromFile(string fileName)
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
        ///   Create a clone of this print object
        /// </summary>
        public virtual Print Clone()
        {
            return ((Print) (MemberwiseClone()));
        }

        #endregion
    }
}