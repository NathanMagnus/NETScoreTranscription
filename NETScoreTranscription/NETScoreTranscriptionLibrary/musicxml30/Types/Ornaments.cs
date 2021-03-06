﻿using System;
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
    [XmlRoot(Namespace = "", IsNullable = true)]
    public class Ornaments
    {
        private static XmlSerializer serializer;
        private ItemsChoiceType2[] itemsElementNameField;
        private object[] itemsField;

        [XmlElement("accidental-mark", typeof (AccidentalMark), Order = 0)]
        [XmlElement("delayed-inverted-turn", typeof (HorizontalTurn), Order = 0)]
        [XmlElement("delayed-turn", typeof (HorizontalTurn), Order = 0)]
        [XmlElement("inverted-mordent", typeof (Mordent), Order = 0)]
        [XmlElement("inverted-turn", typeof (HorizontalTurn), Order = 0)]
        [XmlElement("mordent", typeof (Mordent), Order = 0)]
        [XmlElement("other-ornament", typeof (PlacementText), Order = 0)]
        [XmlElement("schleifer", typeof (EmptyPlacement), Order = 0)]
        [XmlElement("shake", typeof (EmptyTrillSound), Order = 0)]
        [XmlElement("tremolo", typeof (Tremolo), Order = 0)]
        [XmlElement("trill-mark", typeof (EmptyTrillSound), Order = 0)]
        [XmlElement("turn", typeof (HorizontalTurn), Order = 0)]
        [XmlElement("vertical-turn", typeof (EmptyTrillSound), Order = 0)]
        [XmlElement("wavy-line", typeof (WavyLine), Order = 0)]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get { return itemsField; }
            set { itemsField = value; }
        }

        [XmlElement("ItemsElementName", Order = 1)]
        [XmlIgnore]
        public ItemsChoiceType2[] ItemsElementName
        {
            get { return itemsElementNameField; }
            set { itemsElementNameField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Ornaments));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current ornaments object into an XML document
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
        ///   Deserializes workflow markup into an ornaments object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output ornaments object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Ornaments obj, out Exception exception)
        {
            exception = null;
            obj = default(Ornaments);
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

        public static bool Deserialize(string xml, out Ornaments obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Ornaments Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Ornaments)
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
        ///   Serializes current ornaments object into file
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
        ///   Deserializes xml markup from file into an ornaments object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output ornaments object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Ornaments obj, out Exception exception)
        {
            exception = null;
            obj = default(Ornaments);
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

        public static bool LoadFromFile(string fileName, out Ornaments obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Ornaments LoadFromFile(string fileName)
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
        ///   Create a clone of this ornaments object
        /// </summary>
        public virtual Ornaments Clone()
        {
            return ((Ornaments) (MemberwiseClone()));
        }

        #endregion
    }
}