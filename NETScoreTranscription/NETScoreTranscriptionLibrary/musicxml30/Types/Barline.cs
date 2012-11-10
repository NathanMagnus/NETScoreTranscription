using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Barline
    {

        private BarStyleColor barStyleField;

        private FormattedText footnoteField;

        private Level levelField;

        private WavyLine wavylineField;

        private EmptyPrintStyleAlign segnoField;

        private EmptyPrintStyleAlign codaField;

        private Fermata[] fermataField;

        private Ending endingField;

        private Repeat repeatField;

        private RightLeftMiddle locationField;

        private string segno1Field;

        private string coda1Field;

        private decimal divisionsField;

        private bool divisionsFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public Barline()
        {
            locationField = RightLeftMiddle.right;
        }

        [System.Xml.Serialization.XmlElementAttribute("bar-style", Order = 0)]
        public BarStyleColor barStyle
        {
            get
            {
                return barStyleField;
            }
            set
            {
                barStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

        [System.Xml.Serialization.XmlElementAttribute("wavy-line", Order = 3)]
        public WavyLine wavyline
        {
            get
            {
                return wavylineField;
            }
            set
            {
                wavylineField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public EmptyPrintStyleAlign segno
        {
            get
            {
                return segnoField;
            }
            set
            {
                segnoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public EmptyPrintStyleAlign coda
        {
            get
            {
                return codaField;
            }
            set
            {
                codaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("fermata", Order = 6)]
        public Fermata[] fermata
        {
            get
            {
                return fermataField;
            }
            set
            {
                fermataField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public Ending ending
        {
            get
            {
                return endingField;
            }
            set
            {
                endingField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public Repeat repeat
        {
            get
            {
                return repeatField;
            }
            set
            {
                repeatField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        [System.ComponentModel.DefaultValueAttribute(RightLeftMiddle.right)]
        public RightLeftMiddle location
        {
            get
            {
                return locationField;
            }
            set
            {
                locationField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("segno", DataType = "token")]
        public string segno1
        {
            get
            {
                return segno1Field;
            }
            set
            {
                segno1Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("coda", DataType = "token")]
        public string coda1
        {
            get
            {
                return coda1Field;
            }
            set
            {
                coda1Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Barline));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current barline object into an XML document
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
        /// Deserializes workflow markup into an barline object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output barline object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Barline obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Barline);
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

        public static bool Deserialize(string xml, out Barline obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Barline Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Barline)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current barline object into file
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
        /// Deserializes xml markup from file into an barline object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output barline object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Barline obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Barline);
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

        public static bool LoadFromFile(string fileName, out Barline obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Barline LoadFromFile(string fileName)
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
        /// Create a clone of this barline object
        /// </summary>
        public virtual Barline Clone()
        {
            return ((Barline)(MemberwiseClone()));
        }
        #endregion
    }
}