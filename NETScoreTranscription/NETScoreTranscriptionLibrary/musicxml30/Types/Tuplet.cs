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
    public class Tuplet
    {
        private static XmlSerializer serializer;
        private YesNo bracketField;

        private bool bracketFieldSpecified;

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;
        private LineShape lineShapeField;

        private bool lineShapeFieldSpecified;
        private string numberField;
        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;
        private ShowTuplet showNumberField;

        private bool showNumberFieldSpecified;

        private ShowTuplet showtypeField;

        private bool showtypeFieldSpecified;
        private TupletPortion tupletActualField;

        private TupletPortion tupletNormalField;

        private StartStop typeField;

        [XmlElement("tuplet-actual", Order = 0)]
        public TupletPortion tupletActual
        {
            get { return tupletActualField; }
            set { tupletActualField = value; }
        }

        [XmlElement("tuplet-normal", Order = 1)]
        public TupletPortion tupletNormal
        {
            get { return tupletNormalField; }
            set { tupletNormalField = value; }
        }

        [XmlAttribute]
        public StartStop type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlAttribute(DataType = "positiveInteger")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        [XmlAttribute]
        public YesNo bracket
        {
            get { return bracketField; }
            set { bracketField = value; }
        }

        [XmlIgnore]
        public bool bracketSpecified
        {
            get { return bracketFieldSpecified; }
            set { bracketFieldSpecified = value; }
        }

        [XmlAttribute("show-number")]
        public ShowTuplet showNumber
        {
            get { return showNumberField; }
            set { showNumberField = value; }
        }

        [XmlIgnore]
        public bool showNumberSpecified
        {
            get { return showNumberFieldSpecified; }
            set { showNumberFieldSpecified = value; }
        }

        [XmlAttribute("show-type")]
        public ShowTuplet showtype
        {
            get { return showtypeField; }
            set { showtypeField = value; }
        }

        [XmlIgnore]
        public bool showtypeSpecified
        {
            get { return showtypeFieldSpecified; }
            set { showtypeFieldSpecified = value; }
        }

        [XmlAttribute("line-shape")]
        public LineShape lineShape
        {
            get { return lineShapeField; }
            set { lineShapeField = value; }
        }

        [XmlIgnore]
        public bool lineShapeSpecified
        {
            get { return lineShapeFieldSpecified; }
            set { lineShapeFieldSpecified = value; }
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

        [XmlAttribute]
        public AboveBelow placement
        {
            get { return placementField; }
            set { placementField = value; }
        }

        [XmlIgnore]
        public bool placementSpecified
        {
            get { return placementFieldSpecified; }
            set { placementFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Tuplet));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current tuplet object into an XML document
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
        ///   Deserializes workflow markup into an tuplet object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output tuplet object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Tuplet obj, out Exception exception)
        {
            exception = null;
            obj = default(Tuplet);
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

        public static bool Deserialize(string xml, out Tuplet obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Tuplet Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Tuplet)
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
        ///   Serializes current tuplet object into file
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
        ///   Deserializes xml markup from file into an tuplet object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output tuplet object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Tuplet obj, out Exception exception)
        {
            exception = null;
            obj = default(Tuplet);
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

        public static bool LoadFromFile(string fileName, out Tuplet obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Tuplet LoadFromFile(string fileName)
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
        ///   Create a clone of this tuplet object
        /// </summary>
        public virtual Tuplet Clone()
        {
            return ((Tuplet) (MemberwiseClone()));
        }

        #endregion
    }
}