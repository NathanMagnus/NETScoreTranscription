using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class Accidental
    {

        private YesNo cautionaryField;

        private bool cautionaryFieldSpecified;

        private YesNo editorialField;

        private bool editorialFieldSpecified;

        private YesNo parenthesesField;

        private bool parenthesesFieldSpecified;

        private YesNo bracketField;

        private bool bracketFieldSpecified;

        private SymbolSize sizeField;

        private bool sizeFieldSpecified;

        private AccidentalValue valueField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo cautionary
        {
            get
            {
                return cautionaryField;
            }
            set
            {
                cautionaryField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool cautionarySpecified
        {
            get
            {
                return cautionaryFieldSpecified;
            }
            set
            {
                cautionaryFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo editorial
        {
            get
            {
                return editorialField;
            }
            set
            {
                editorialField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool editorialSpecified
        {
            get
            {
                return editorialFieldSpecified;
            }
            set
            {
                editorialFieldSpecified = value;
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

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo bracket
        {
            get
            {
                return bracketField;
            }
            set
            {
                bracketField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool bracketSpecified
        {
            get
            {
                return bracketFieldSpecified;
            }
            set
            {
                bracketFieldSpecified = value;
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

        [System.Xml.Serialization.XmlTextAttribute]
        public AccidentalValue Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Accidental));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current accidental object into an XML document
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
        /// Deserializes workflow markup into an accidental object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output accidental object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Accidental obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Accidental);
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

        public static bool Deserialize(string xml, out Accidental obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Accidental Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Accidental)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current accidental object into file
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
        /// Deserializes xml markup from file into an accidental object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output accidental object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Accidental obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Accidental);
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

        public static bool LoadFromFile(string fileName, out Accidental obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Accidental LoadFromFile(string fileName)
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
        /// Create a clone of this accidental object
        /// </summary>
        public virtual Accidental Clone()
        {
            return ((Accidental)(MemberwiseClone()));
        }
        #endregion
    }
}