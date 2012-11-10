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
    [XmlType(TypeName = "part-group")]
    [XmlRoot("part-group", Namespace = "", IsNullable = true)]
    public class PartGroup
    {
        private static XmlSerializer serializer;
        private FormattedText footnoteField;
        private GroupName groupAbbreviationField;

        private NameDisplay groupAbbreviationdisplayField;

        private GroupBarline groupBarlineField;
        private GroupName groupNameField;

        private NameDisplay groupNamedisplayField;
        private GroupSymbol groupSymbolField;

        private Empty groupTimeField;

        private Level levelField;

        private string numberField;
        private StartStop typeField;

        public PartGroup()
        {
            numberField = "1";
        }

        [XmlElement("group-name", Order = 0)]
        public GroupName groupName
        {
            get { return groupNameField; }
            set { groupNameField = value; }
        }

        [XmlElement("group-name-display", Order = 1)]
        public NameDisplay groupNamedisplay
        {
            get { return groupNamedisplayField; }
            set { groupNamedisplayField = value; }
        }

        [XmlElement("group-abbreviation", Order = 2)]
        public GroupName groupAbbreviation
        {
            get { return groupAbbreviationField; }
            set { groupAbbreviationField = value; }
        }

        [XmlElement("group-abbreviation-display", Order = 3)]
        public NameDisplay groupAbbreviationdisplay
        {
            get { return groupAbbreviationdisplayField; }
            set { groupAbbreviationdisplayField = value; }
        }

        [XmlElement("group-symbol", Order = 4)]
        public GroupSymbol groupSymbol
        {
            get { return groupSymbolField; }
            set { groupSymbolField = value; }
        }

        [XmlElement("group-barline", Order = 5)]
        public GroupBarline groupBarline
        {
            get { return groupBarlineField; }
            set { groupBarlineField = value; }
        }

        [XmlElement("group-time", Order = 6)]
        public Empty groupTime
        {
            get { return groupTimeField; }
            set { groupTimeField = value; }
        }

        [XmlElement(Order = 7)]
        public FormattedText footnote
        {
            get { return footnoteField; }
            set { footnoteField = value; }
        }

        [XmlElement(Order = 8)]
        public Level level
        {
            get { return levelField; }
            set { levelField = value; }
        }

        [XmlAttribute]
        public StartStop type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlAttribute(DataType = "token")]
        [DefaultValue("1")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (PartGroup));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current partgroup object into an XML document
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
        ///   Deserializes workflow markup into an partgroup object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output partgroup object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out PartGroup obj, out Exception exception)
        {
            exception = null;
            obj = default(PartGroup);
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

        public static bool Deserialize(string xml, out PartGroup obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static PartGroup Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((PartGroup)
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
        ///   Serializes current partgroup object into file
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
        ///   Deserializes xml markup from file into an partgroup object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output partgroup object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out PartGroup obj, out Exception exception)
        {
            exception = null;
            obj = default(PartGroup);
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

        public static bool LoadFromFile(string fileName, out PartGroup obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PartGroup LoadFromFile(string fileName)
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
        ///   Create a clone of this partgroup object
        /// </summary>
        public virtual PartGroup Clone()
        {
            return ((PartGroup) (MemberwiseClone()));
        }

        #endregion
    }
}