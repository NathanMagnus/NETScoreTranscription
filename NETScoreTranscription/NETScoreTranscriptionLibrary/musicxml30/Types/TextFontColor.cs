using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(TypeName = "text-font-color")]
    [XmlRoot("text-font-color", Namespace = "", IsNullable = true)]
    public class TextFontColor
    {
        private static XmlSerializer serializer;
        private string colorField;
        private TextDirection dirField;

        private bool dirFieldSpecified;
        private string fontFamilyField;
        private string fontSizeField;

        private FontStyle fontStyleField;

        private bool fontStyleFieldSpecified;

        private FontWeight fontWeightField;

        private bool fontWeightFieldSpecified;
        private string langField;
        private string letterSpacingField;

        private string lineThroughField;
        private string overlineField;

        private decimal rotationField;

        private bool rotationFieldSpecified;
        private string underlineField;

        private string valueField;

        [XmlAttribute("font-family", DataType = "token")]
        public string fontFamily
        {
            get { return fontFamilyField; }
            set { fontFamilyField = value; }
        }

        [XmlAttribute("font-style")]
        public FontStyle fontStyle
        {
            get { return fontStyleField; }
            set { fontStyleField = value; }
        }

        [XmlIgnore]
        public bool fontStyleSpecified
        {
            get { return fontStyleFieldSpecified; }
            set { fontStyleFieldSpecified = value; }
        }

        [XmlAttribute("font-size")]
        public string fontSize
        {
            get { return fontSizeField; }
            set { fontSizeField = value; }
        }

        [XmlAttribute("font-weight")]
        public FontWeight fontWeight
        {
            get { return fontWeightField; }
            set { fontWeightField = value; }
        }

        [XmlIgnore]
        public bool fontWeightSpecified
        {
            get { return fontWeightFieldSpecified; }
            set { fontWeightFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string underline
        {
            get { return underlineField; }
            set { underlineField = value; }
        }

        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string overline
        {
            get { return overlineField; }
            set { overlineField = value; }
        }

        [XmlAttribute("line-through", DataType = "nonNegativeInteger")]
        public string lineThrough
        {
            get { return lineThroughField; }
            set { lineThroughField = value; }
        }

        [XmlAttribute]
        public decimal rotation
        {
            get { return rotationField; }
            set { rotationField = value; }
        }

        [XmlIgnore]
        public bool rotationSpecified
        {
            get { return rotationFieldSpecified; }
            set { rotationFieldSpecified = value; }
        }

        [XmlAttribute("letter-spacing")]
        public string letterSpacing
        {
            get { return letterSpacingField; }
            set { letterSpacingField = value; }
        }

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get { return langField; }
            set { langField = value; }
        }

        [XmlAttribute]
        public TextDirection dir
        {
            get { return dirField; }
            set { dirField = value; }
        }

        [XmlIgnore]
        public bool dirSpecified
        {
            get { return dirFieldSpecified; }
            set { dirFieldSpecified = value; }
        }

        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (TextFontColor));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current textfontcolor object into an XML document
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
        ///   Deserializes workflow markup into an textfontcolor object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output textfontcolor object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TextFontColor obj, out Exception exception)
        {
            exception = null;
            obj = default(TextFontColor);
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

        public static bool Deserialize(string xml, out TextFontColor obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TextFontColor Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((TextFontColor)
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
        ///   Serializes current textfontcolor object into file
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
        ///   Deserializes xml markup from file into an textfontcolor object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output textfontcolor object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TextFontColor obj, out Exception exception)
        {
            exception = null;
            obj = default(TextFontColor);
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

        public static bool LoadFromFile(string fileName, out TextFontColor obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TextFontColor LoadFromFile(string fileName)
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
        ///   Create a clone of this textfontcolor object
        /// </summary>
        public virtual TextFontColor Clone()
        {
            return ((TextFontColor) (MemberwiseClone()));
        }

        #endregion
    }
}