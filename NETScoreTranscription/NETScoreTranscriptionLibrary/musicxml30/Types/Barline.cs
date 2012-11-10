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
    public class Barline
    {
        private static XmlSerializer serializer;
        private BarStyleColor barStyleField;
        private string coda1Field;

        private EmptyPrintStyleAlign codaField;
        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private Ending endingField;
        private Fermata[] fermataField;
        private FormattedText footnoteField;

        private Level levelField;

        private RightLeftMiddle locationField;
        private Repeat repeatField;

        private string segno1Field;
        private EmptyPrintStyleAlign segnoField;
        private WavyLine wavylineField;

        public Barline()
        {
            locationField = RightLeftMiddle.right;
        }

        [XmlElement("bar-style", Order = 0)]
        public BarStyleColor barStyle
        {
            get { return barStyleField; }
            set { barStyleField = value; }
        }

        [XmlElement(Order = 1)]
        public FormattedText footnote
        {
            get { return footnoteField; }
            set { footnoteField = value; }
        }

        [XmlElement(Order = 2)]
        public Level level
        {
            get { return levelField; }
            set { levelField = value; }
        }

        [XmlElement("wavy-line", Order = 3)]
        public WavyLine wavyline
        {
            get { return wavylineField; }
            set { wavylineField = value; }
        }

        [XmlElement(Order = 4)]
        public EmptyPrintStyleAlign segno
        {
            get { return segnoField; }
            set { segnoField = value; }
        }

        [XmlElement(Order = 5)]
        public EmptyPrintStyleAlign coda
        {
            get { return codaField; }
            set { codaField = value; }
        }

        [XmlElement("fermata", Order = 6)]
        public Fermata[] fermata
        {
            get { return fermataField; }
            set { fermataField = value; }
        }

        [XmlElement(Order = 7)]
        public Ending ending
        {
            get { return endingField; }
            set { endingField = value; }
        }

        [XmlElement(Order = 8)]
        public Repeat repeat
        {
            get { return repeatField; }
            set { repeatField = value; }
        }

        [XmlAttribute]
        [DefaultValue(RightLeftMiddle.right)]
        public RightLeftMiddle location
        {
            get { return locationField; }
            set { locationField = value; }
        }

        [XmlAttribute("segno", DataType = "token")]
        public string segno1
        {
            get { return segno1Field; }
            set { segno1Field = value; }
        }

        [XmlAttribute("coda", DataType = "token")]
        public string coda1
        {
            get { return coda1Field; }
            set { coda1Field = value; }
        }

        [XmlAttribute]
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

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Barline));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current barline object into an XML document
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
        ///   Deserializes workflow markup into an barline object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output barline object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Barline obj, out Exception exception)
        {
            exception = null;
            obj = default(Barline);
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

        public static bool Deserialize(string xml, out Barline obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Barline Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Barline)
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
        ///   Serializes current barline object into file
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
        ///   Deserializes xml markup from file into an barline object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output barline object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Barline obj, out Exception exception)
        {
            exception = null;
            obj = default(Barline);
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

        public static bool LoadFromFile(string fileName, out Barline obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Barline LoadFromFile(string fileName)
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
        ///   Create a clone of this barline object
        /// </summary>
        public virtual Barline Clone()
        {
            return ((Barline) (MemberwiseClone()));
        }

        #endregion
    }
}