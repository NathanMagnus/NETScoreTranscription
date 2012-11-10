﻿using System;
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
    [XmlType(TypeName = "accidental-text")]
    [XmlRoot("accidental-text", Namespace = "", IsNullable = true)]
    public class AccidentalText
    {
        private static XmlSerializer serializer;
        private string langField;

        private string spaceField;

        private AccidentalValue valueField;

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get { return langField; }
            set { langField = value; }
        }

        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string space
        {
            get { return spaceField; }
            set { spaceField = value; }
        }

        [XmlText]
        public AccidentalValue Value
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
                    serializer = new XmlSerializer(typeof (AccidentalText));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current accidentaltext object into an XML document
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
        ///   Deserializes workflow markup into an accidentaltext object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output accidentaltext object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out AccidentalText obj, out Exception exception)
        {
            exception = null;
            obj = default(AccidentalText);
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

        public static bool Deserialize(string xml, out AccidentalText obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static AccidentalText Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((AccidentalText)
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
        ///   Serializes current accidentaltext object into file
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
        ///   Deserializes xml markup from file into an accidentaltext object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output accidentaltext object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out AccidentalText obj, out Exception exception)
        {
            exception = null;
            obj = default(AccidentalText);
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

        public static bool LoadFromFile(string fileName, out AccidentalText obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static AccidentalText LoadFromFile(string fileName)
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
        ///   Create a clone of this accidentaltext object
        /// </summary>
        public virtual AccidentalText Clone()
        {
            return ((AccidentalText) (MemberwiseClone()));
        }

        #endregion
    }
}