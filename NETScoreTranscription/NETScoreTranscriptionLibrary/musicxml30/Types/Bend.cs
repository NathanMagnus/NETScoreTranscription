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
    public class Bend
    {
        private static XmlSerializer serializer;
        private YesNo accelerateField;

        private bool accelerateFieldSpecified;

        private decimal beatsField;

        private bool beatsFieldSpecified;
        private decimal bendAlterField;

        private decimal firstBeatField;

        private bool firstBeatFieldSpecified;
        private ItemChoiceType1 itemElementNameField;
        private Empty itemField;

        private decimal lastBeatField;

        private bool lastBeatFieldSpecified;
        private PlacementText withBarField;

        [XmlElement("bend-alter", Order = 0)]
        public decimal bendAlter
        {
            get { return bendAlterField; }
            set { bendAlterField = value; }
        }

        [XmlElement("pre-bend", typeof (Empty), Order = 1)]
        [XmlElement("release", typeof (Empty), Order = 1)]
        [XmlChoiceIdentifier("ItemElementName")]
        public Empty Item
        {
            get { return itemField; }
            set { itemField = value; }
        }

        [XmlElement(Order = 2)]
        [XmlIgnore]
        public ItemChoiceType1 ItemElementName
        {
            get { return itemElementNameField; }
            set { itemElementNameField = value; }
        }

        [XmlElement("with-bar", Order = 3)]
        public PlacementText withBar
        {
            get { return withBarField; }
            set { withBarField = value; }
        }

        [XmlAttribute]
        public YesNo accelerate
        {
            get { return accelerateField; }
            set { accelerateField = value; }
        }

        [XmlIgnore]
        public bool accelerateSpecified
        {
            get { return accelerateFieldSpecified; }
            set { accelerateFieldSpecified = value; }
        }

        [XmlAttribute]
        public decimal beats
        {
            get { return beatsField; }
            set { beatsField = value; }
        }

        [XmlIgnore]
        public bool beatsSpecified
        {
            get { return beatsFieldSpecified; }
            set { beatsFieldSpecified = value; }
        }

        [XmlAttribute("first-beat")]
        public decimal firstBeat
        {
            get { return firstBeatField; }
            set { firstBeatField = value; }
        }

        [XmlIgnore]
        public bool firstBeatSpecified
        {
            get { return firstBeatFieldSpecified; }
            set { firstBeatFieldSpecified = value; }
        }

        [XmlAttribute("last-beat")]
        public decimal lastBeat
        {
            get { return lastBeatField; }
            set { lastBeatField = value; }
        }

        [XmlIgnore]
        public bool lastBeatSpecified
        {
            get { return lastBeatFieldSpecified; }
            set { lastBeatFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Bend));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current bend object into an XML document
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
        ///   Deserializes workflow markup into an bend object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output bend object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Bend obj, out Exception exception)
        {
            exception = null;
            obj = default(Bend);
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

        public static bool Deserialize(string xml, out Bend obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Bend Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Bend)
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
        ///   Serializes current bend object into file
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
        ///   Deserializes xml markup from file into an bend object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output bend object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Bend obj, out Exception exception)
        {
            exception = null;
            obj = default(Bend);
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

        public static bool LoadFromFile(string fileName, out Bend obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Bend LoadFromFile(string fileName)
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
        ///   Create a clone of this bend object
        /// </summary>
        public virtual Bend Clone()
        {
            return ((Bend) (MemberwiseClone()));
        }

        #endregion
    }
}