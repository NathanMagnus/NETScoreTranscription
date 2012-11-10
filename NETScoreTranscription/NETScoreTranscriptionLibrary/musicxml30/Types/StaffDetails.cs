using System.IO;
using System.Xml;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "staff-details")]
    [System.Xml.Serialization.XmlRootAttribute("staff-details", Namespace = "", IsNullable = true)]
    public class StaffDetails
    {

        private StaffType staffTypeField;

        private bool staffTypeFieldSpecified;

        private string staffLinesField;

        private StaffTuning[] staffTuningField;

        private string capoField;

        private decimal staffSizeField;

        private bool staffSizeFieldSpecified;

        private string numberField;

        private ShowFrets showFretsField;

        private bool showFretsFieldSpecified;

        private YesNo printObjectField;

        private bool printObjectFieldSpecified;

        private YesNo printSpacingField;

        private bool printSpacingFieldSpecified;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute("staff-type", Order = 0)]
        public StaffType staffType
        {
            get
            {
                return staffTypeField;
            }
            set
            {
                staffTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool stafftypeSpecified
        {
            get
            {
                return staffTypeFieldSpecified;
            }
            set
            {
                staffTypeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-lines", DataType = "nonNegativeInteger", Order = 1)]
        public string staffLines
        {
            get
            {
                return staffLinesField;
            }
            set
            {
                staffLinesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-tuning", Order = 2)]
        public StaffTuning[] stafftuning
        {
            get
            {
                return staffTuningField;
            }
            set
            {
                staffTuningField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger", Order = 3)]
        public string capo
        {
            get
            {
                return capoField;
            }
            set
            {
                capoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("staff-size", Order = 4)]
        public decimal staffSize
        {
            get
            {
                return staffSizeField;
            }
            set
            {
                staffSizeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool staffSizeSpecified
        {
            get
            {
                return staffSizeFieldSpecified;
            }
            set
            {
                staffSizeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
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

        [System.Xml.Serialization.XmlAttributeAttribute("show-frets")]
        public ShowFrets showFrets
        {
            get
            {
                return showFretsField;
            }
            set
            {
                showFretsField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool showFretsSpecified
        {
            get
            {
                return showFretsFieldSpecified;
            }
            set
            {
                showFretsFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
        public YesNo printObject
        {
            get
            {
                return printObjectField;
            }
            set
            {
                printObjectField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printObjectSpecified
        {
            get
            {
                return printObjectFieldSpecified;
            }
            set
            {
                printObjectFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("print-spacing")]
        public YesNo printSpacing
        {
            get
            {
                return printSpacingField;
            }
            set
            {
                printSpacingField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool printSpacingSpecified
        {
            get
            {
                return printSpacingFieldSpecified;
            }
            set
            {
                printSpacingFieldSpecified = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(StaffDetails));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current staffdetails object into an XML document
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
        /// Deserializes workflow markup into an staffdetails object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output staffdetails object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out StaffDetails obj, out System.Exception exception)
        {
            exception = null;
            obj = default(StaffDetails);
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

        public static bool Deserialize(string xml, out StaffDetails obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static StaffDetails Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((StaffDetails)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader, new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse }))));
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
        /// Serializes current staffdetails object into file
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
        /// Deserializes xml markup from file into an staffdetails object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output staffdetails object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out StaffDetails obj, out System.Exception exception)
        {
            exception = null;
            obj = default(StaffDetails);
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

        public static bool LoadFromFile(string fileName, out StaffDetails obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static StaffDetails LoadFromFile(string fileName)
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
        /// Create a clone of this staffdetails object
        /// </summary>
        public virtual StaffDetails Clone()
        {
            return ((StaffDetails)(MemberwiseClone()));
        }
        #endregion
    }
}