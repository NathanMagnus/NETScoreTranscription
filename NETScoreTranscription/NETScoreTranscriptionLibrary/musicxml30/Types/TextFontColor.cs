using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "text-font-color")]
    [System.Xml.Serialization.XmlRootAttribute("text-font-color", Namespace = "", IsNullable = true)]
    public class TextFontColor
    {

        private string fontFamilyField;

        private FontStyle fontStyleField;

        private bool fontStyleFieldSpecified;

        private string fontSizeField;

        private FontWeight fontWeightField;

        private bool fontWeightFieldSpecified;

        private string colorField;

        private string underlineField;

        private string overlineField;

        private string lineThroughField;

        private decimal rotationField;

        private bool rotationFieldSpecified;

        private string letterSpacingField;

        private string langField;

        private TextDirection dirField;

        private bool dirFieldSpecified;

        private string valueField;

        private static System.Xml.Serialization.XmlSerializer serializer;

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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string underline
        {
            get
            {
                return underlineField;
            }
            set
            {
                underlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string overline
        {
            get
            {
                return overlineField;
            }
            set
            {
                overlineField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("line-through", DataType = "nonNegativeInteger")]
        public string lineThrough
        {
            get
            {
                return lineThroughField;
            }
            set
            {
                lineThroughField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public decimal rotation
        {
            get
            {
                return rotationField;
            }
            set
            {
                rotationField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool rotationSpecified
        {
            get
            {
                return rotationFieldSpecified;
            }
            set
            {
                rotationFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("letter-spacing")]
        public string letterSpacing
        {
            get
            {
                return letterSpacingField;
            }
            set
            {
                letterSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return langField;
            }
            set
            {
                langField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute]
        public TextDirection dir
        {
            get
            {
                return dirField;
            }
            set
            {
                dirField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool dirSpecified
        {
            get
            {
                return dirFieldSpecified;
            }
            set
            {
                dirFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute]
        public string Value
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TextFontColor));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current textfontcolor object into an XML document
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
        /// Deserializes workflow markup into an textfontcolor object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output textfontcolor object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TextFontColor obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TextFontColor);
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

        public static bool Deserialize(string xml, out TextFontColor obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TextFontColor Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((TextFontColor)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current textfontcolor object into file
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
        /// Deserializes xml markup from file into an textfontcolor object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output textfontcolor object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out TextFontColor obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TextFontColor);
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

        public static bool LoadFromFile(string fileName, out TextFontColor obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TextFontColor LoadFromFile(string fileName)
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
        /// Create a clone of this textfontcolor object
        /// </summary>
        public virtual TextFontColor Clone()
        {
            return ((TextFontColor)(MemberwiseClone()));
        }
        #endregion
    }
}