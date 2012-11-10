using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Print
    {

        private PageLayout pageLayoutField;

        private SystemLayout systemLayoutField;

        private StaffLayout[] staffLayoutField;

        private MeasureLayout measureLayoutField;

        private MeasureNumbering measureNumberingField;

        private NameDisplay partNameDisplayField;

        private NameDisplay partAbbreviationDisplayField;

        private decimal staffSpacingField;

        private bool staffSpacingFieldSpecified;

        private YesNo newSystemField;

        private bool newSystemFieldSpecified;

        private YesNo newPageField;

        private bool newPageFieldSpecified;

        private string blankPageField;

        private string pageNumberField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("page-layout", Order = 0)]
        public PageLayout pageLayout
        {
            get
            {
                return pageLayoutField;
            }
            set
            {
                pageLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("system-layout", Order = 1)]
        public SystemLayout systemLayout
        {
            get
            {
                return systemLayoutField;
            }
            set
            {
                systemLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-layout", Order = 2)]
        public StaffLayout[] staffLayout
        {
            get
            {
                return staffLayoutField;
            }
            set
            {
                staffLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("measure-layout", Order = 3)]
        public MeasureLayout measureLayout
        {
            get
            {
                return measureLayoutField;
            }
            set
            {
                measureLayoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("measure-numbering", Order = 4)]
        public MeasureNumbering measureNumbering
        {
            get
            {
                return measureNumberingField;
            }
            set
            {
                measureNumberingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-name-display", Order = 5)]
        public NameDisplay partNameDisplay
        {
            get
            {
                return partNameDisplayField;
            }
            set
            {
                partNameDisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-abbreviation-display", Order = 6)]
        public NameDisplay partAbbreviationDisplay
        {
            get
            {
                return partAbbreviationDisplayField;
            }
            set
            {
                partAbbreviationDisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("staff-spacing")]
        public decimal staffSpacing
        {
            get
            {
                return staffSpacingField;
            }
            set
            {
                staffSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool staffSpacingSpecified
        {
            get
            {
                return staffSpacingFieldSpecified;
            }
            set
            {
                staffSpacingFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("new-system")]
        public YesNo newSystem
        {
            get
            {
                return newSystemField;
            }
            set
            {
                newSystemField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool newSystemSpecified
        {
            get
            {
                return newSystemFieldSpecified;
            }
            set
            {
                newSystemFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("new-page")]
        public YesNo newPage
        {
            get
            {
                return newPageField;
            }
            set
            {
                newPageField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool newPageSpecified
        {
            get
            {
                return newPageFieldSpecified;
            }
            set
            {
                newPageFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("blank-page", DataType = "positiveInteger")]
        public string blankPage
        {
            get
            {
                return blankPageField;
            }
            set
            {
                blankPageField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("page-number", DataType = "token")]
        public string pageNumber
        {
            get
            {
                return pageNumberField;
            }
            set
            {
                pageNumberField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Print));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current print object into an XML document
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
        /// Deserializes workflow markup into an print object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output print object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Print obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Print);
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

        public static bool Deserialize(string xml, out Print obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Print Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Print)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current print object into file
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
        /// Deserializes xml markup from file into an print object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output print object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Print obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Print);
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

        public static bool LoadFromFile(string fileName, out Print obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Print LoadFromFile(string fileName)
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
        /// Create a clone of this print object
        /// </summary>
        public virtual Print Clone()
        {
            return ((Print)(MemberwiseClone()));
        }
        #endregion
    }
}