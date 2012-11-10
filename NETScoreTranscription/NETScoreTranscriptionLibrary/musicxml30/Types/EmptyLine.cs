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
    [XmlType(TypeName = "empty-line")]
    [XmlRoot("empty-line", Namespace = "", IsNullable = true)]
    public class EmptyLine
    {
        private static XmlSerializer serializer;
        private decimal dashLengthField;

        private bool dashLengthFieldSpecified;
        private LineShape lineShapeField;

        private bool lineShapeFieldSpecified;

        private LineType lineTypeField;

        private bool lineTypeFieldSpecified;

        private AboveBelow placementField;

        private bool placementFieldSpecified;
        private decimal spaceLengthField;

        private bool spaceLengthFieldSpecified;

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

        [XmlAttribute("line-type")]
        public LineType lineType
        {
            get { return lineTypeField; }
            set { lineTypeField = value; }
        }

        [XmlIgnore]
        public bool lineTypeSpecified
        {
            get { return lineTypeFieldSpecified; }
            set { lineTypeFieldSpecified = value; }
        }

        [XmlAttribute("dash-length")]
        public decimal dashLength
        {
            get { return dashLengthField; }
            set { dashLengthField = value; }
        }

        [XmlIgnore]
        public bool dashLengthSpecified
        {
            get { return dashLengthFieldSpecified; }
            set { dashLengthFieldSpecified = value; }
        }

        [XmlAttribute("space-length")]
        public decimal spaceLength
        {
            get { return spaceLengthField; }
            set { spaceLengthField = value; }
        }

        [XmlIgnore]
        public bool spaceLengthSpecified
        {
            get { return spaceLengthFieldSpecified; }
            set { spaceLengthFieldSpecified = value; }
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
                    serializer = new XmlSerializer(typeof (EmptyLine));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current emptyline object into an XML document
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
        ///   Deserializes workflow markup into an emptyline object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output emptyline object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out EmptyLine obj, out Exception exception)
        {
            exception = null;
            obj = default(EmptyLine);
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

        public static bool Deserialize(string xml, out EmptyLine obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static EmptyLine Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((EmptyLine)
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
        ///   Serializes current emptyline object into file
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
        ///   Deserializes xml markup from file into an emptyline object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output emptyline object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out EmptyLine obj, out Exception exception)
        {
            exception = null;
            obj = default(EmptyLine);
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

        public static bool LoadFromFile(string fileName, out EmptyLine obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static EmptyLine LoadFromFile(string fileName)
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
        ///   Create a clone of this emptyline object
        /// </summary>
        public virtual EmptyLine Clone()
        {
            return ((EmptyLine) (MemberwiseClone()));
        }

        #endregion
    }
}