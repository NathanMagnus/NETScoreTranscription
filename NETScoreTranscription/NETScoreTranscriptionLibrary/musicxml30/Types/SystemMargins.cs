﻿using System.IO;
using System.Xml;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "system-margins")]
    [System.Xml.Serialization.XmlRootAttribute("system-margins", Namespace = "", IsNullable = true)]
    public class SystemMargins
    {

        private decimal leftMarginField;

        private decimal rightMarginField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("left-margin", Order = 0)]
        public decimal leftMargin
        {
            get
            {
                return leftMarginField;
            }
            set
            {
                leftMarginField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("right-margin", Order = 1)]
        public decimal rightMargin
        {
            get
            {
                return rightMarginField;
            }
            set
            {
                rightMarginField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(SystemMargins));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current systemmargins object into an XML document
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
        /// Deserializes workflow markup into an systemmargins object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output systemmargins object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out SystemMargins obj, out System.Exception exception)
        {
            exception = null;
            obj = default(SystemMargins);
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

        public static bool Deserialize(string xml, out SystemMargins obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static SystemMargins Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((SystemMargins)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current systemmargins object into file
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
        /// Deserializes xml markup from file into an systemmargins object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output systemmargins object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out SystemMargins obj, out System.Exception exception)
        {
            exception = null;
            obj = default(SystemMargins);
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

        public static bool LoadFromFile(string fileName, out SystemMargins obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static SystemMargins LoadFromFile(string fileName)
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
        /// Create a clone of this systemmargins object
        /// </summary>
        public virtual SystemMargins Clone()
        {
            return ((SystemMargins)(MemberwiseClone()));
        }
        #endregion
    }
}