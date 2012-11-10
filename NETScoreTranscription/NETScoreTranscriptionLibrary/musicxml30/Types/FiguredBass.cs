using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "figured-bass")]
    [System.Xml.Serialization.XmlRootAttribute("figured-bass", Namespace = "", IsNullable = true)]
    public class FiguredBass
    {

        private Figure[] figureField;

        private decimal durationField;

        private FormattedText footnoteField;

        private Level levelField;

        private YesNo printDotField;

        private bool printDotFieldSpecified;

        private YesNo printLyricField;

        private bool printLyricFieldSpecified;

        private YesNo parenthesesField;

        private bool parenthesesFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("figure", Order = 0)]
        public Figure[] figure
        {
            get
            {
                return figureField;
            }
            set
            {
                figureField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public decimal duration
        {
            get
            {
                return durationField;
            }
            set
            {
                durationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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

        [System.Xml.Serialization.XmlAttributeAttribute("print-dot")]
        public YesNo printDot
        {
            get
            {
                return printDotField;
            }
            set
            {
                printDotField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printDotSpecified
        {
            get
            {
                return printDotFieldSpecified;
            }
            set
            {
                printDotFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-lyric")]
        public YesNo printLyric
        {
            get
            {
                return printLyricField;
            }
            set
            {
                printLyricField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printLyricSpecified
        {
            get
            {
                return printLyricFieldSpecified;
            }
            set
            {
                printLyricFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo parentheses
        {
            get
            {
                return parenthesesField;
            }
            set
            {
                parenthesesField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool parenthesesSpecified
        {
            get
            {
                return parenthesesFieldSpecified;
            }
            set
            {
                parenthesesFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(FiguredBass));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current figuredbass object into an XML document
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
        /// Deserializes workflow markup into an figuredbass object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output figuredbass object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out FiguredBass obj, out System.Exception exception)
        {
            exception = null;
            obj = default(FiguredBass);
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

        public static bool Deserialize(string xml, out FiguredBass obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static FiguredBass Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((FiguredBass)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current figuredbass object into file
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
        /// Deserializes xml markup from file into an figuredbass object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output figuredbass object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out FiguredBass obj, out System.Exception exception)
        {
            exception = null;
            obj = default(FiguredBass);
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

        public static bool LoadFromFile(string fileName, out FiguredBass obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static FiguredBass LoadFromFile(string fileName)
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
        /// Create a clone of this figuredbass object
        /// </summary>
        public virtual FiguredBass Clone()
        {
            return ((FiguredBass)(MemberwiseClone()));
        }
        #endregion
    }
}