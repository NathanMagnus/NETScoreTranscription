using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Frame
    {

        private string frameStringsField;

        private string frameFretsField;

        private FirstFret firstFretField;

        private Framenote[] framenoteField;

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;

        private string colorField;

        private LeftCenterRight halignField;

        private bool halignFieldSpecified;

        private ValignImage valignField;

        private bool valignFieldSpecified;

        private decimal heightField;

        private bool heightFieldSpecified;

        private decimal widthField;

        private bool widthFieldSpecified;

        private string unplayedField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("frame-strings", DataType = "positiveInteger", Order = 0)]
        public string frameStrings
        {
            get
            {
                return frameStringsField;
            }
            set
            {
                frameStringsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("frame-frets", DataType = "positiveInteger", Order = 1)]
        public string frameFrets
        {
            get
            {
                return frameFretsField;
            }
            set
            {
                frameFretsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("first-fret", Order = 2)]
        public FirstFret firstFret
        {
            get
            {
                return firstFretField;
            }
            set
            {
                firstFretField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("frame-note", Order = 3)]
        public Framenote[] frameNote
        {
            get
            {
                return framenoteField;
            }
            set
            {
                framenoteField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("default-x")]
        public decimal defaultX
        {
            get
            {
                return defaultXField;
            }
            set
            {
                defaultXField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool defaultXSpecified
        {
            get
            {
                return defaultXFieldSpecified;
            }
            set
            {
                defaultXFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("default-y")]
        public decimal defaultY
        {
            get
            {
                return defaultYField;
            }
            set
            {
                defaultYField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool defaultYSpecified
        {
            get
            {
                return defaultYFieldSpecified;
            }
            set
            {
                defaultYFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("relative-x")]
        public decimal relativeX
        {
            get
            {
                return relativeXField;
            }
            set
            {
                relativeXField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool relativeXSpecified
        {
            get
            {
                return relativeXFieldSpecified;
            }
            set
            {
                relativeXFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("relative-y")]
        public decimal relativeY
        {
            get
            {
                return relativeYField;
            }
            set
            {
                relativeYField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool relativeYSpecified
        {
            get
            {
                return relativeYFieldSpecified;
            }
            set
            {
                relativeYFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string color
        {
            get
            {
                return colorField;
            }
            set
            {
                colorField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public LeftCenterRight halign
        {
            get
            {
                return halignField;
            }
            set
            {
                halignField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool halignSpecified
        {
            get
            {
                return halignFieldSpecified;
            }
            set
            {
                halignFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public ValignImage valign
        {
            get
            {
                return valignField;
            }
            set
            {
                valignField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool valignSpecified
        {
            get
            {
                return valignFieldSpecified;
            }
            set
            {
                valignFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal height
        {
            get
            {
                return heightField;
            }
            set
            {
                heightField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool heightSpecified
        {
            get
            {
                return heightFieldSpecified;
            }
            set
            {
                heightFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal width
        {
            get
            {
                return widthField;
            }
            set
            {
                widthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool widthSpecified
        {
            get
            {
                return widthFieldSpecified;
            }
            set
            {
                widthFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string unplayed
        {
            get
            {
                return unplayedField;
            }
            set
            {
                unplayedField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Frame));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current frame object into an XML document
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
        /// Deserializes workflow markup into an frame object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output frame object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Frame obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Frame);
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

        public static bool Deserialize(string xml, out Frame obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Frame Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Frame)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current frame object into file
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
        /// Deserializes xml markup from file into an frame object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output frame object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Frame obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Frame);
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

        public static bool LoadFromFile(string fileName, out Frame obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Frame LoadFromFile(string fileName)
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
        /// Create a clone of this frame object
        /// </summary>
        public virtual Frame Clone()
        {
            return ((Frame)(MemberwiseClone()));
        }
        #endregion
    }
}