using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Slur
    {

        private StartStopContinue typeField;

        private string numberField;

        private LineType lineTypeField;

        private bool lineTypeFieldSpecified;

        private decimal dashLengthField;

        private bool dashLengthFieldSpecified;

        private decimal spaceLengthField;

        private bool spaceLengthFieldSpecified;

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;

        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private OverUnder orientationField;

        private bool orientationFieldSpecified;

        private decimal bezierOffsetField;

        private bool bezierOffsetFieldSpecified;

        private decimal bezierOffset2Field;

        private bool bezierOffset2FieldSpecified;

        private decimal bezierXField;

        private bool bezierXFieldSpecified;

        private decimal bezierYField;

        private bool bezierYFieldSpecified;

        private decimal bezierX2Field;

        private bool bezierX2FieldSpecified;

        private decimal bezierY2Field;

        private bool bezierY2FieldSpecified;

        private string colorField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public Slur()
        {
            numberField = "1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public StartStopContinue type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        [System.ComponentModel.DefaultValueAttribute("1")]
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

        [System.Xml.Serialization.XmlAttributeAttribute("line-type")]
        public LineType lineType
        {
            get
            {
                return lineTypeField;
            }
            set
            {
                lineTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool lineTypeSpecified
        {
            get
            {
                return lineTypeFieldSpecified;
            }
            set
            {
                lineTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("dash-length")]
        public decimal dashLength
        {
            get
            {
                return dashLengthField;
            }
            set
            {
                dashLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool dashLengthSpecified
        {
            get
            {
                return dashLengthFieldSpecified;
            }
            set
            {
                dashLengthFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("space-length")]
        public decimal spaceLength
        {
            get
            {
                return spaceLengthField;
            }
            set
            {
                spaceLengthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool spaceLengthSpecified
        {
            get
            {
                return spaceLengthFieldSpecified;
            }
            set
            {
                spaceLengthFieldSpecified = value;
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

        [System.Xml.Serialization.XmlAttributeAttribute]
        public AboveBelow placement
        {
            get
            {
                return placementField;
            }
            set
            {
                placementField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool placementSpecified
        {
            get
            {
                return placementFieldSpecified;
            }
            set
            {
                placementFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public OverUnder orientation
        {
            get
            {
                return orientationField;
            }
            set
            {
                orientationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool orientationSpecified
        {
            get
            {
                return orientationFieldSpecified;
            }
            set
            {
                orientationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset")]
        public decimal bezierOffset
        {
            get
            {
                return bezierOffsetField;
            }
            set
            {
                bezierOffsetField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierOffsetSpecified
        {
            get
            {
                return bezierOffsetFieldSpecified;
            }
            set
            {
                bezierOffsetFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-offset2")]
        public decimal bezierOffset2
        {
            get
            {
                return bezierOffset2Field;
            }
            set
            {
                bezierOffset2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierOffset2Specified
        {
            get
            {
                return bezierOffset2FieldSpecified;
            }
            set
            {
                bezierOffset2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x")]
        public decimal bezierX
        {
            get
            {
                return bezierXField;
            }
            set
            {
                bezierXField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierXSpecified
        {
            get
            {
                return bezierXFieldSpecified;
            }
            set
            {
                bezierXFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y")]
        public decimal bezierY
        {
            get
            {
                return bezierYField;
            }
            set
            {
                bezierYField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierYSpecified
        {
            get
            {
                return bezierYFieldSpecified;
            }
            set
            {
                bezierYFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-x2")]
        public decimal bezierX2
        {
            get
            {
                return bezierX2Field;
            }
            set
            {
                bezierX2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierX2Specified
        {
            get
            {
                return bezierX2FieldSpecified;
            }
            set
            {
                bezierX2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("bezier-y2")]
        public decimal bezierY2
        {
            get
            {
                return bezierY2Field;
            }
            set
            {
                bezierY2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bezierY2Specified
        {
            get
            {
                return bezierY2FieldSpecified;
            }
            set
            {
                bezierY2FieldSpecified = value;
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Slur));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current slur object into an XML document
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
        /// Deserializes workflow markup into an slur object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output slur object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Slur obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Slur);
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

        public static bool Deserialize(string xml, out Slur obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Slur Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Slur)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current slur object into file
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
        /// Deserializes xml markup from file into an slur object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output slur object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Slur obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Slur);
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

        public static bool LoadFromFile(string fileName, out Slur obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Slur LoadFromFile(string fileName)
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
        /// Create a clone of this slur object
        /// </summary>
        public virtual Slur Clone()
        {
            return ((Slur)(MemberwiseClone()));
        }
        #endregion
    }
}