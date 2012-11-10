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
    public class Frame
    {
        private static XmlSerializer serializer;
        private string colorField;
        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;
        private FirstFret firstFretField;
        private string frameFretsField;
        private string frameStringsField;
        private Framenote[] framenoteField;
        private LeftCenterRight halignField;

        private bool halignFieldSpecified;
        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;
        private string unplayedField;

        private ValignImage valignField;

        private bool valignFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        [XmlElement("frame-strings", DataType = "positiveInteger", Order = 0)]
        public string frameStrings
        {
            get { return frameStringsField; }
            set { frameStringsField = value; }
        }

        [XmlElement("frame-frets", DataType = "positiveInteger", Order = 1)]
        public string frameFrets
        {
            get { return frameFretsField; }
            set { frameFretsField = value; }
        }

        [XmlElement("first-fret", Order = 2)]
        public FirstFret firstFret
        {
            get { return firstFretField; }
            set { firstFretField = value; }
        }

        [XmlElement("frame-note", Order = 3)]
        public Framenote[] frameNote
        {
            get { return framenoteField; }
            set { framenoteField = value; }
        }

        [XmlAttribute("default-x")]
        public decimal defaultX
        {
            get { return defaultXField; }
            set { defaultXField = value; }
        }

        [XmlIgnore]
        public bool defaultXSpecified
        {
            get { return defaultXFieldSpecified; }
            set { defaultXFieldSpecified = value; }
        }

        [XmlAttribute("default-y")]
        public decimal defaultY
        {
            get { return defaultYField; }
            set { defaultYField = value; }
        }

        [XmlIgnore]
        public bool defaultYSpecified
        {
            get { return defaultYFieldSpecified; }
            set { defaultYFieldSpecified = value; }
        }

        [XmlAttribute("relative-x")]
        public decimal relativeX
        {
            get { return relativeXField; }
            set { relativeXField = value; }
        }

        [XmlIgnore]
        public bool relativeXSpecified
        {
            get { return relativeXFieldSpecified; }
            set { relativeXFieldSpecified = value; }
        }

        [XmlAttribute("relative-y")]
        public decimal relativeY
        {
            get { return relativeYField; }
            set { relativeYField = value; }
        }

        [XmlIgnore]
        public bool relativeYSpecified
        {
            get { return relativeYFieldSpecified; }
            set { relativeYFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute]
        public LeftCenterRight halign
        {
            get { return halignField; }
            set { halignField = value; }
        }

        [XmlIgnore]
        public bool halignSpecified
        {
            get { return halignFieldSpecified; }
            set { halignFieldSpecified = value; }
        }

        [XmlAttribute]
        public ValignImage valign
        {
            get { return valignField; }
            set { valignField = value; }
        }

        [XmlIgnore]
        public bool valignSpecified
        {
            get { return valignFieldSpecified; }
            set { valignFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal height
        {
            get { return heightField; }
            set { heightField = value; }
        }

        [XmlIgnore]
        public bool heightSpecified
        {
            get { return heightFieldSpecified; }
            set { heightFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal width
        {
            get { return widthField; }
            set { widthField = value; }
        }

        [XmlIgnore]
        public bool widthSpecified
        {
            get { return widthFieldSpecified; }
            set { widthFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string unplayed
        {
            get { return unplayedField; }
            set { unplayedField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Frame));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current frame object into an XML document
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
        ///   Deserializes workflow markup into an frame object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output frame object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Frame obj, out Exception exception)
        {
            exception = null;
            obj = default(Frame);
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

        public static bool Deserialize(string xml, out Frame obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Frame Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Frame)
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
        ///   Serializes current frame object into file
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
        ///   Deserializes xml markup from file into an frame object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output frame object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Frame obj, out Exception exception)
        {
            exception = null;
            obj = default(Frame);
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

        public static bool LoadFromFile(string fileName, out Frame obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Frame LoadFromFile(string fileName)
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
        ///   Create a clone of this frame object
        /// </summary>
        public virtual Frame Clone()
        {
            return ((Frame) (MemberwiseClone()));
        }

        #endregion
    }
}