using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "part-group")]
    [System.Xml.Serialization.XmlRootAttribute("part-group", Namespace = "", IsNullable = true)]
    public class PartGroup
    {

        private GroupName groupNameField;

        private NameDisplay groupNamedisplayField;

        private GroupName groupAbbreviationField;

        private NameDisplay groupAbbreviationdisplayField;

        private GroupSymbol groupSymbolField;

        private GroupBarline groupBarlineField;

        private Empty groupTimeField;

        private FormattedText footnoteField;

        private Level levelField;

        private StartStop typeField;

        private string numberField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public PartGroup()
        {
            numberField = "1";
        }

        [System.Xml.Serialization.XmlElementAttribute("group-name", Order = 0)]
        public GroupName groupName
        {
            get
            {
                return groupNameField;
            }
            set
            {
                groupNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-name-display", Order = 1)]
        public NameDisplay groupNamedisplay
        {
            get
            {
                return groupNamedisplayField;
            }
            set
            {
                groupNamedisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation", Order = 2)]
        public GroupName groupAbbreviation
        {
            get
            {
                return groupAbbreviationField;
            }
            set
            {
                groupAbbreviationField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-abbreviation-display", Order = 3)]
        public NameDisplay groupAbbreviationdisplay
        {
            get
            {
                return groupAbbreviationdisplayField;
            }
            set
            {
                groupAbbreviationdisplayField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-symbol", Order = 4)]
        public GroupSymbol groupSymbol
        {
            get
            {
                return groupSymbolField;
            }
            set
            {
                groupSymbolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-barline", Order = 5)]
        public GroupBarline groupBarline
        {
            get
            {
                return groupBarlineField;
            }
            set
            {
                groupBarlineField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("group-time", Order = 6)]
        public Empty groupTime
        {
            get
            {
                return groupTimeField;
            }
            set
            {
                groupTimeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public FormattedText footnote
        {
            get
            {
                return footnoteField;
            }
            set
            {
                footnoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public Level level
        {
            get
            {
                return levelField;
            }
            set
            {
                levelField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public StartStop type
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
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

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(PartGroup));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current partgroup object into an XML document
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
        /// Deserializes workflow markup into an partgroup object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output partgroup object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out PartGroup obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PartGroup);
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

        public static bool Deserialize(string xml, out PartGroup obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static PartGroup Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((PartGroup)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current partgroup object into file
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
        /// Deserializes xml markup from file into an partgroup object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output partgroup object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out PartGroup obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PartGroup);
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

        public static bool LoadFromFile(string fileName, out PartGroup obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PartGroup LoadFromFile(string fileName)
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
        /// Create a clone of this partgroup object
        /// </summary>
        public virtual PartGroup Clone()
        {
            return ((PartGroup)(MemberwiseClone()));
        }
        #endregion
    }
}