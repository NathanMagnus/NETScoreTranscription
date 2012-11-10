using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Attributes
    {

        private FormattedText footnoteField;

        private Level levelField;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private Key[] keyField;

        private Time[] timeField;

        private string stavesField;

        private PartSymbol partsymbolField;

        private string instrumentsField;

        private Clef[] clefField;

        private StaffDetails[] staffdetailsField;

        private Transpose[] transposeField;

        private AttributesDirective[] directiveField;

        private MeasureStyle[] measurestyleField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public FormattedText footnote
        {
            get
            {
                return footnoteField;
            }
            set
            {
                footnoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Level level
        {
            get
            {
                return levelField;
            }
            set
            {
                levelField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public decimal divisions
        {
            get
            {
                return divisionsField;
            }
            set
            {
                divisionsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool divisionsSpecified
        {
            get
            {
                return divisionsFieldSpecified;
            }
            set
            {
                divisionsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("key", Order = 3)]
        public Key[] key
        {
            get
            {
                return keyField;
            }
            set
            {
                keyField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("time", Order = 4)]
        public Time[] time
        {
            get
            {
                return timeField;
            }
            set
            {
                timeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 5)]
        public string staves
        {
            get
            {
                return stavesField;
            }
            set
            {
                stavesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("part-symbol", Order = 6)]
        public PartSymbol partsymbol
        {
            get
            {
                return partsymbolField;
            }
            set
            {
                partsymbolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 7)]
        public string instruments
        {
            get
            {
                return instrumentsField;
            }
            set
            {
                instrumentsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("clef", Order = 8)]
        public Clef[] clef
        {
            get
            {
                return clefField;
            }
            set
            {
                clefField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-details", Order = 9)]
        public StaffDetails[] staffdetails
        {
            get
            {
                return staffdetailsField;
            }
            set
            {
                staffdetailsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("transpose", Order = 10)]
        public Transpose[] transpose
        {
            get
            {
                return transposeField;
            }
            set
            {
                transposeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("directive", Order = 11)]
        public AttributesDirective[] directive
        {
            get
            {
                return directiveField;
            }
            set
            {
                directiveField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("measure-style", Order = 12)]
        public MeasureStyle[] measurestyle
        {
            get
            {
                return measurestyleField;
            }
            set
            {
                measurestyleField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Attributes));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current attributes object into an XML document
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
        /// Deserializes workflow markup into an attributes object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output attributes object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Attributes obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Attributes);
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

        public static bool Deserialize(string xml, out Attributes obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Attributes Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Attributes)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current attributes object into file
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
        /// Deserializes xml markup from file into an attributes object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output attributes object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Attributes obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Attributes);
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

        public static bool LoadFromFile(string fileName, out Attributes obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Attributes LoadFromFile(string fileName)
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
        /// Create a clone of this attributes object
        /// </summary>
        public virtual Attributes Clone()
        {
            return ((Attributes)(MemberwiseClone()));
        }
        #endregion
    }
}