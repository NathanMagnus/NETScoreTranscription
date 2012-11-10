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
    public class Attributes
    {
        private static XmlSerializer serializer;
        private Clef[] clefField;
        private AttributesDirective[] directiveField;
        private decimal divisionsField;

        private bool divisionsFieldSpecified;
        private FormattedText footnoteField;
        private string instrumentsField;

        private Key[] keyField;
        private Level levelField;
        private MeasureStyle[] measurestyleField;

        private PartSymbol partsymbolField;

        private StaffDetails[] staffdetailsField;
        private string stavesField;
        private Time[] timeField;

        private Transpose[] transposeField;

        [XmlElement(Order = 0)]
        public FormattedText footnote
        {
            get { return footnoteField; }
            set { footnoteField = value; }
        }

        [XmlElement(Order = 1)]
        public Level level
        {
            get { return levelField; }
            set { levelField = value; }
        }

        [XmlElement(Order = 2)]
        public decimal divisions
        {
            get { return divisionsField; }
            set { divisionsField = value; }
        }

        [XmlIgnore]
        public bool divisionsSpecified
        {
            get { return divisionsFieldSpecified; }
            set { divisionsFieldSpecified = value; }
        }

        [XmlElement("key", Order = 3)]
        public Key[] key
        {
            get { return keyField; }
            set { keyField = value; }
        }

        [XmlElement("time", Order = 4)]
        public Time[] time
        {
            get { return timeField; }
            set { timeField = value; }
        }

        [XmlElement(DataType = "nonNegativeInteger", Order = 5)]
        public string staves
        {
            get { return stavesField; }
            set { stavesField = value; }
        }

        [XmlElement("part-symbol", Order = 6)]
        public PartSymbol partsymbol
        {
            get { return partsymbolField; }
            set { partsymbolField = value; }
        }

        [XmlElement(DataType = "nonNegativeInteger", Order = 7)]
        public string instruments
        {
            get { return instrumentsField; }
            set { instrumentsField = value; }
        }

        [XmlElement("clef", Order = 8)]
        public Clef[] clef
        {
            get { return clefField; }
            set { clefField = value; }
        }

        [XmlElement("staff-details", Order = 9)]
        public StaffDetails[] staffdetails
        {
            get { return staffdetailsField; }
            set { staffdetailsField = value; }
        }

        [XmlElement("transpose", Order = 10)]
        public Transpose[] transpose
        {
            get { return transposeField; }
            set { transposeField = value; }
        }

        [XmlElement("directive", Order = 11)]
        public AttributesDirective[] directive
        {
            get { return directiveField; }
            set { directiveField = value; }
        }

        [XmlElement("measure-style", Order = 12)]
        public MeasureStyle[] measurestyle
        {
            get { return measurestyleField; }
            set { measurestyleField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Attributes));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current attributes object into an XML document
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
        ///   Deserializes workflow markup into an attributes object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output attributes object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Attributes obj, out Exception exception)
        {
            exception = null;
            obj = default(Attributes);
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

        public static bool Deserialize(string xml, out Attributes obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Attributes Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Attributes)
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
        ///   Serializes current attributes object into file
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
        ///   Deserializes xml markup from file into an attributes object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output attributes object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Attributes obj, out Exception exception)
        {
            exception = null;
            obj = default(Attributes);
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

        public static bool LoadFromFile(string fileName, out Attributes obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Attributes LoadFromFile(string fileName)
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
        ///   Create a clone of this attributes object
        /// </summary>
        public virtual Attributes Clone()
        {
            return ((Attributes) (MemberwiseClone()));
        }

        #endregion
    }
}