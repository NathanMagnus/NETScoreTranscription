using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "empty-line")]
    [System.Xml.Serialization.XmlRootAttribute("empty-line", Namespace = "", IsNullable = true)]
    public class EmptyLine
    {

        private LineShape lineShapeField;

        private bool lineShapeFieldSpecified;

        private LineType lineTypeField;

        private bool lineTypeFieldSpecified;

        private decimal dashLengthField;

        private bool dashLengthFieldSpecified;

        private decimal spaceLengthField;

        private bool spaceLengthFieldSpecified;

        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlAttributeAttribute("line-shape")]
        public LineShape lineShape
        {
            get
            {
                return lineShapeField;
            }
            set
            {
                lineShapeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool lineShapeSpecified
        {
            get
            {
                return lineShapeFieldSpecified;
            }
            set
            {
                lineShapeFieldSpecified = value;
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(EmptyLine));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current emptyline object into an XML document
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
        /// Deserializes workflow markup into an emptyline object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output emptyline object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out EmptyLine obj, out System.Exception exception)
        {
            exception = null;
            obj = default(EmptyLine);
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

        public static bool Deserialize(string xml, out EmptyLine obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static EmptyLine Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((EmptyLine)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current emptyline object into file
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
        /// Deserializes xml markup from file into an emptyline object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output emptyline object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out EmptyLine obj, out System.Exception exception)
        {
            exception = null;
            obj = default(EmptyLine);
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

        public static bool LoadFromFile(string fileName, out EmptyLine obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static EmptyLine LoadFromFile(string fileName)
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
        /// Create a clone of this emptyline object
        /// </summary>
        public virtual EmptyLine Clone()
        {
            return ((EmptyLine)(MemberwiseClone()));
        }
        #endregion
    }
}