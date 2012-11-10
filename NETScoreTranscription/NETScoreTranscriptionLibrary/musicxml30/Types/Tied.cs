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
    public class Tied
    {
        private static XmlSerializer serializer;
        private decimal bezierOffset2Field;

        private bool bezierOffset2FieldSpecified;
        private decimal bezierOffsetField;

        private bool bezierOffsetFieldSpecified;
        private decimal bezierX2Field;

        private bool bezierX2FieldSpecified;
        private decimal bezierXField;

        private bool bezierXFieldSpecified;
        private decimal bezierY2Field;

        private bool bezierY2FieldSpecified;
        private decimal bezierYField;

        private bool bezierYFieldSpecified;
        private string colorField;
        private decimal dashLengthField;

        private bool dashLengthFieldSpecified;

        private decimal defaultXField;

        private bool defaultXFieldSpecified;

        private decimal defaultYField;

        private bool defaultYFieldSpecified;
        private LineType lineTypeField;

        private bool lineTypeFieldSpecified;
        private string numberField;
        private OverUnder orientationField;

        private bool orientationFieldSpecified;
        private AboveBelow placementField;

        private bool placementFieldSpecified;

        private decimal relativeXField;

        private bool relativeXFieldSpecified;

        private decimal relativeYField;

        private bool relativeYFieldSpecified;
        private decimal spaceLengthField;

        private bool spaceLengthFieldSpecified;
        private StartStopContinue typeField;

        [XmlAttribute]
        public StartStopContinue type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        [XmlAttribute(DataType = "positiveInteger")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
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

        [XmlAttribute("default-x")]
        public decimal defaultX
        {
            get { return defaultXField; }
            set { defaultXField = value; }
        }

        [XmlIgnore]
        public bool defaultXSpecified
        {
            get { return defaultXFieldSpecified; }
            set { defaultXFieldSpecified = value; }
        }

        [XmlAttribute("default-y")]
        public decimal defaultY
        {
            get { return defaultYField; }
            set { defaultYField = value; }
        }

        [XmlIgnore]
        public bool defaultYSpecified
        {
            get { return defaultYFieldSpecified; }
            set { defaultYFieldSpecified = value; }
        }

        [XmlAttribute("relative-x")]
        public decimal relativeX
        {
            get { return relativeXField; }
            set { relativeXField = value; }
        }

        [XmlIgnore]
        public bool relativeXSpecified
        {
            get { return relativeXFieldSpecified; }
            set { relativeXFieldSpecified = value; }
        }

        [XmlAttribute("relative-y")]
        public decimal relativeY
        {
            get { return relativeYField; }
            set { relativeYField = value; }
        }

        [XmlIgnore]
        public bool relativeYSpecified
        {
            get { return relativeYFieldSpecified; }
            set { relativeYFieldSpecified = value; }
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

        [XmlAttribute]
        public OverUnder orientation
        {
            get { return orientationField; }
            set { orientationField = value; }
        }

        [XmlIgnore]
        public bool orientationSpecified
        {
            get { return orientationFieldSpecified; }
            set { orientationFieldSpecified = value; }
        }

        [XmlAttribute("bezier-offset")]
        public decimal bezierOffset
        {
            get { return bezierOffsetField; }
            set { bezierOffsetField = value; }
        }

        [XmlIgnore]
        public bool bezierOffsetSpecified
        {
            get { return bezierOffsetFieldSpecified; }
            set { bezierOffsetFieldSpecified = value; }
        }

        [XmlAttribute("bezier-offset2")]
        public decimal bezierOffset2
        {
            get { return bezierOffset2Field; }
            set { bezierOffset2Field = value; }
        }

        [XmlIgnore]
        public bool bezierOffset2Specified
        {
            get { return bezierOffset2FieldSpecified; }
            set { bezierOffset2FieldSpecified = value; }
        }

        [XmlAttribute("bezier-x")]
        public decimal bezierX
        {
            get { return bezierXField; }
            set { bezierXField = value; }
        }

        [XmlIgnore]
        public bool bezierXSpecified
        {
            get { return bezierXFieldSpecified; }
            set { bezierXFieldSpecified = value; }
        }

        [XmlAttribute("bezier-y")]
        public decimal bezierY
        {
            get { return bezierYField; }
            set { bezierYField = value; }
        }

        [XmlIgnore]
        public bool bezierYSpecified
        {
            get { return bezierYFieldSpecified; }
            set { bezierYFieldSpecified = value; }
        }

        [XmlAttribute("bezier-x2")]
        public decimal bezierX2
        {
            get { return bezierX2Field; }
            set { bezierX2Field = value; }
        }

        [XmlIgnore]
        public bool bezierX2Specified
        {
            get { return bezierX2FieldSpecified; }
            set { bezierX2FieldSpecified = value; }
        }

        [XmlAttribute("bezier-y2")]
        public decimal bezierY2
        {
            get { return bezierY2Field; }
            set { bezierY2Field = value; }
        }

        [XmlIgnore]
        public bool bezierY2Specified
        {
            get { return bezierY2FieldSpecified; }
            set { bezierY2FieldSpecified = value; }
        }

        [XmlAttribute(DataType = "token")]
        public string color
        {
            get { return colorField; }
            set { colorField = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (Tied));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current tied object into an XML document
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
        ///   Deserializes workflow markup into an tied object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output tied object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Tied obj, out Exception exception)
        {
            exception = null;
            obj = default(Tied);
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

        public static bool Deserialize(string xml, out Tied obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Tied Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((Tied)
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
        ///   Serializes current tied object into file
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
        ///   Deserializes xml markup from file into an tied object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output tied object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Tied obj, out Exception exception)
        {
            exception = null;
            obj = default(Tied);
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

        public static bool LoadFromFile(string fileName, out Tied obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Tied LoadFromFile(string fileName)
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
        ///   Create a clone of this tied object
        /// </summary>
        public virtual Tied Clone()
        {
            return ((Tied) (MemberwiseClone()));
        }

        #endregion
    }
}