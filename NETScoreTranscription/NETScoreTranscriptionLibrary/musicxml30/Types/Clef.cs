using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Clef
    {

        private ClefSign signField;

        private string lineField;

        private string clefOctvaeChangeField;

        private string numberField;

        private YesNo additionalField;

        private bool additionalFieldSpecified;

        private SymbolSize sizeField;

        private bool sizeFieldSpecified;

        private YesNo afterBarlineField;

        private bool afterBarlineFieldSpecified;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ClefSign sign
        {
            get
            {
                return signField;
            }
            set
            {
                signField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer", Order = 1)]
        public string line
        {
            get
            {
                return lineField;
            }
            set
            {
                lineField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("clef-octave-change", DataType = "integer", Order = 2)]
        public string clefOctaveChange
        {
            get
            {
                return clefOctvaeChangeField;
            }
            set
            {
                clefOctvaeChangeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string number
        {
            get
            {
                return numberField;
            }
            set
            {
                numberField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo additional
        {
            get
            {
                return additionalField;
            }
            set
            {
                additionalField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool additionalSpecified
        {
            get
            {
                return additionalFieldSpecified;
            }
            set
            {
                additionalFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public SymbolSize size
        {
            get
            {
                return sizeField;
            }
            set
            {
                sizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool sizeSpecified
        {
            get
            {
                return sizeFieldSpecified;
            }
            set
            {
                sizeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("after-barline")]
        public YesNo afterBarline
        {
            get
            {
                return afterBarlineField;
            }
            set
            {
                afterBarlineField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool afterBarlineSpecified
        {
            get
            {
                return afterBarlineFieldSpecified;
            }
            set
            {
                afterBarlineFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public YesNo printObject
        {
            get
            {
                return printObjectField;
            }
            set
            {
                printObjectField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printObjectSpecified
        {
            get
            {
                return printObjectFieldSpecified;
            }
            set
            {
                printObjectFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Clef));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current clef object into an XML document
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
        /// Deserializes workflow markup into an clef object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output clef object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Clef obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Clef);
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

        public static bool Deserialize(string xml, out Clef obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Clef Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Clef)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current clef object into file
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
        /// Deserializes xml markup from file into an clef object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output clef object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Clef obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Clef);
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

        public static bool LoadFromFile(string fileName, out Clef obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Clef LoadFromFile(string fileName)
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
        /// Create a clone of this clef object
        /// </summary>
        public virtual Clef Clone()
        {
            return ((Clef)(MemberwiseClone()));
        }
        #endregion
    }
}