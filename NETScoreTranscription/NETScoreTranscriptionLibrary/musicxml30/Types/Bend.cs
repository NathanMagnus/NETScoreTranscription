using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Bend
    {

        private decimal bendAlterField;

        private Empty itemField;

        private ItemChoiceType1 itemElementNameField;

        private PlacementText withBarField;

        private YesNo accelerateField;

        private bool accelerateFieldSpecified;

        private decimal beatsField;

        private bool beatsFieldSpecified;

        private decimal firstBeatField;

        private bool firstBeatFieldSpecified;

        private decimal lastBeatField;

        private bool lastBeatFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("bend-alter", Order = 0)]
        public decimal bendAlter
        {
            get
            {
                return bendAlterField;
            }
            set
            {
                bendAlterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pre-bend", typeof(Empty), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("release", typeof(Empty), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public Empty Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("with-bar", Order = 3)]
        public PlacementText withBar
        {
            get
            {
                return withBarField;
            }
            set
            {
                withBarField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo accelerate
        {
            get
            {
                return accelerateField;
            }
            set
            {
                accelerateField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool accelerateSpecified
        {
            get
            {
                return accelerateFieldSpecified;
            }
            set
            {
                accelerateFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal beats
        {
            get
            {
                return beatsField;
            }
            set
            {
                beatsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool beatsSpecified
        {
            get
            {
                return beatsFieldSpecified;
            }
            set
            {
                beatsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("first-beat")]
        public decimal firstBeat
        {
            get
            {
                return firstBeatField;
            }
            set
            {
                firstBeatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool firstBeatSpecified
        {
            get
            {
                return firstBeatFieldSpecified;
            }
            set
            {
                firstBeatFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("last-beat")]
        public decimal lastBeat
        {
            get
            {
                return lastBeatField;
            }
            set
            {
                lastBeatField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool lastBeatSpecified
        {
            get
            {
                return lastBeatFieldSpecified;
            }
            set
            {
                lastBeatFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Bend));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current bend object into an XML document
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
        /// Deserializes workflow markup into an bend object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output bend object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Bend obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Bend);
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

        public static bool Deserialize(string xml, out Bend obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Bend Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Bend)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current bend object into file
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
        /// Deserializes xml markup from file into an bend object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output bend object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Bend obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Bend);
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

        public static bool LoadFromFile(string fileName, out Bend obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Bend LoadFromFile(string fileName)
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
        /// Create a clone of this bend object
        /// </summary>
        public virtual Bend Clone()
        {
            return ((Bend)(MemberwiseClone()));
        }
        #endregion
    }
}