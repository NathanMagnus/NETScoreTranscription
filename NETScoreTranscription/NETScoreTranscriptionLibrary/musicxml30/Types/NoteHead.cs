﻿using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public class NoteHead
    {

        private YesNo filledField;

        private bool filledFieldSpecified;

        private YesNo parenthesesField;

        private bool parenthesesFieldSpecified;

        private string fontFamilyField;

        private FontStyle fontStyleField;

        private bool fontStyleFieldSpecified;

        private string fontSizeField;

        private FontWeight fontWeightField;

        private bool fontWeightFieldSpecified;

        private string colorField;

        private NoteHeadValue valueField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlAttributeAttribute]
        public YesNo filled
        {
            get
            {
                return filledField;
            }
            set
            {
                filledField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool filledSpecified
        {
            get
            {
                return filledFieldSpecified;
            }
            set
            {
                filledFieldSpecified = value;
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

        [System.Xml.Serialization.XmlAttributeAttribute("font-family", DataType = "token")]
        public string fontFamily
        {
            get
            {
                return fontFamilyField;
            }
            set
            {
                fontFamilyField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("font-style")]
        public FontStyle fontStyle
        {
            get
            {
                return fontStyleField;
            }
            set
            {
                fontStyleField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool fontStyleSpecified
        {
            get
            {
                return fontStyleFieldSpecified;
            }
            set
            {
                fontStyleFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("font-size")]
        public string fontSize
        {
            get
            {
                return fontSizeField;
            }
            set
            {
                fontSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("font-weight")]
        public FontWeight fontWeight
        {
            get
            {
                return fontWeightField;
            }
            set
            {
                fontWeightField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool fontWeightSpecified
        {
            get
            {
                return fontWeightFieldSpecified;
            }
            set
            {
                fontWeightFieldSpecified = value;
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

        [System.Xml.Serialization.XmlTextAttribute]
        public NoteHeadValue Value
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(NoteHead));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current noteHead object into an XML document
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
        /// Deserializes workflow markup into an noteHead object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output noteHead object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out NoteHead obj, out System.Exception exception)
        {
            exception = null;
            obj = default(NoteHead);
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

        public static bool Deserialize(string xml, out NoteHead obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static NoteHead Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((NoteHead)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current noteHead object into file
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
        /// Deserializes xml markup from file into an noteHead object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output noteHead object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out NoteHead obj, out System.Exception exception)
        {
            exception = null;
            obj = default(NoteHead);
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

        public static bool LoadFromFile(string fileName, out NoteHead obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static NoteHead LoadFromFile(string fileName)
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
        /// Create a clone of this noteHead object
        /// </summary>
        public virtual NoteHead Clone()
        {
            return ((NoteHead)(MemberwiseClone()));
        }
        #endregion
    }
}