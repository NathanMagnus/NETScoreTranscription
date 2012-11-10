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
    public class Clef
    {
        private static XmlSerializer serializer;
        private YesNo additionalField;

        private bool additionalFieldSpecified;

        private YesNo afterBarlineField;

        private bool afterBarlineFieldSpecified;
        private string clefOctvaeChangeField;
        private string lineField;
        private string numberField;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;
        private ClefSign signField;
        private SymbolSize sizeField;

        private bool sizeFieldSpecified;

        [XmlElement(Order = 0)]
        public ClefSign sign
        {
            get { return signField; }
            set { signField = value; }
        }

        [XmlElement(DataType = "integer", Order = 1)]
        public string line
        {
            get { return lineField; }
            set { lineField = value; }
        }

        [XmlElement("clef-octave-change", DataType = "integer", Order = 2)]
        public string clefOctaveChange
        {
            get { return clefOctvaeChangeField; }
            set { clefOctvaeChangeField = value; }
        }

        [XmlAttribute(DataType = "positiveInteger")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        [XmlAttribute]
        public YesNo additional
        {
            get { return additionalField; }
            set { additionalField = value; }
        }

        [XmlIgnore]
        public bool additionalSpecified
        {
            get { return additionalFieldSpecified; }
            set { additionalFieldSpecified = value; }
        }

        [XmlAttribute]
        public SymbolSize size
        {
            get { return sizeField; }
            set { sizeField = value; }
        }

        [XmlIgnore]
        public bool sizeSpecified
        {
            get { return sizeFieldSpecified; }
            set { sizeFieldSpecified = value; }
        }

        [XmlAttribute("after-barline")]
        public YesNo afterBarline
        {
            get { return afterBarlineField; }
            set { afterBarlineField = value; }
        }

        [XmlIgnore]
        public bool afterBarlineSpecified
        {
            get { return afterBarlineFieldSpecified; }
            set { afterBarlineFieldSpecified = value; }
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
                    serializer = new XmlSerializer(typeof (Clef));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current clef object into an XML document
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
        ///   Deserializes workflow markup into an clef object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output clef object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Clef obj, out Exception exception)
        {
            exception = null;
            obj = default(Clef);
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

        public static bool Deserialize(string xml, out Clef obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Clef Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Clef)
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
        ///   Serializes current clef object into file
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
        ///   Deserializes xml markup from file into an clef object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output clef object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Clef obj, out Exception exception)
        {
            exception = null;
            obj = default(Clef);
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

        public static bool LoadFromFile(string fileName, out Clef obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Clef LoadFromFile(string fileName)
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
        ///   Create a clone of this clef object
        /// </summary>
        public virtual Clef Clone()
        {
            return ((Clef) (MemberwiseClone()));
        }

        #endregion
    }
}