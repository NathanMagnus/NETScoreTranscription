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
    [XmlType(TypeName = "staff-details")]
    [XmlRoot("staff-details", Namespace = "", IsNullable = true)]
    public class StaffDetails
    {
        private static XmlSerializer serializer;
        private string capoField;

        private string numberField;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;

        private YesNo printSpacingField;

        private bool printSpacingFieldSpecified;
        private ShowFrets showFretsField;

        private bool showFretsFieldSpecified;
        private string staffLinesField;
        private decimal staffSizeField;

        private bool staffSizeFieldSpecified;
        private StaffTuning[] staffTuningField;
        private StaffType staffTypeField;

        private bool staffTypeFieldSpecified;

        [XmlElement("staff-type", Order = 0)]
        public StaffType staffType
        {
            get { return staffTypeField; }
            set { staffTypeField = value; }
        }

        [XmlIgnore]
        public bool stafftypeSpecified
        {
            get { return staffTypeFieldSpecified; }
            set { staffTypeFieldSpecified = value; }
        }

        [XmlElement("staff-lines", DataType = "nonNegativeInteger", Order = 1)]
        public string staffLines
        {
            get { return staffLinesField; }
            set { staffLinesField = value; }
        }

        [XmlElement("staff-tuning", Order = 2)]
        public StaffTuning[] stafftuning
        {
            get { return staffTuningField; }
            set { staffTuningField = value; }
        }

        [XmlElement(DataType = "nonNegativeInteger", Order = 3)]
        public string capo
        {
            get { return capoField; }
            set { capoField = value; }
        }

        [XmlElement("staff-size", Order = 4)]
        public decimal staffSize
        {
            get { return staffSizeField; }
            set { staffSizeField = value; }
        }

        [XmlIgnore]
        public bool staffSizeSpecified
        {
            get { return staffSizeFieldSpecified; }
            set { staffSizeFieldSpecified = value; }
        }

        [XmlAttribute(DataType = "positiveInteger")]
        public string number
        {
            get { return numberField; }
            set { numberField = value; }
        }

        [XmlAttribute("show-frets")]
        public ShowFrets showFrets
        {
            get { return showFretsField; }
            set { showFretsField = value; }
        }

        [XmlIgnore]
        public bool showFretsSpecified
        {
            get { return showFretsFieldSpecified; }
            set { showFretsFieldSpecified = value; }
        }

        [XmlAttribute("print-object")]
        public YesNo printObject
        {
            get { return printObjectField; }
            set { printObjectField = value; }
        }

        [XmlIgnore]
        public bool printObjectSpecified
        {
            get { return printObjectFieldSpecified; }
            set { printObjectFieldSpecified = value; }
        }

        [XmlAttribute("print-spacing")]
        public YesNo printSpacing
        {
            get { return printSpacingField; }
            set { printSpacingField = value; }
        }

        [XmlIgnore]
        public bool printSpacingSpecified
        {
            get { return printSpacingFieldSpecified; }
            set { printSpacingFieldSpecified = value; }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof (StaffDetails));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize

        /// <summary>
        ///   Serializes current staffdetails object into an XML document
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
        ///   Deserializes workflow markup into an staffdetails object
        /// </summary>
        /// <param name = "xml">string workflow markup to deserialize</param>
        /// <param name = "obj">Output staffdetails object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out StaffDetails obj, out Exception exception)
        {
            exception = null;
            obj = default(StaffDetails);
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

        public static bool Deserialize(string xml, out StaffDetails obj)
        {
            Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static StaffDetails Deserialize(string xml)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(xml);
                return
                    ((StaffDetails)
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
        ///   Serializes current staffdetails object into file
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
        ///   Deserializes xml markup from file into an staffdetails object
        /// </summary>
        /// <param name = "fileName">string xml file to load and deserialize</param>
        /// <param name = "obj">Output staffdetails object</param>
        /// <param name = "exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out StaffDetails obj, out Exception exception)
        {
            exception = null;
            obj = default(StaffDetails);
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

        public static bool LoadFromFile(string fileName, out StaffDetails obj)
        {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static StaffDetails LoadFromFile(string fileName)
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
        ///   Create a clone of this staffdetails object
        /// </summary>
        public virtual StaffDetails Clone()
        {
            return ((StaffDetails) (MemberwiseClone()));
        }

        #endregion
    }
}