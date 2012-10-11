using NETScoreTranscriptionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NETScoreTranscription;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using NETScoreTranscriptionLibrary.MusicXML30;

namespace NETScoreTranscriptionTests
{
    
    
    /// <summary>
    ///This is a test class for XMLParserTest and is intended
    ///to contain all XMLParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class XMLParserTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        //todo: if file doesn't match scorepartwise, then xsl transform it and try again then fail if fail again.
        public static void CompareProperties(Type myType, Object o1, Object o2)
        {
            // Get the public properties.
            PropertyInfo[] myPropertyInfo = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Assert.AreEqual(o1.GetType(), o2.GetType());

            if (o1 == null || o2 == null) Assert.AreEqual(o1, o2);

            // Display the public properties.
            for (int i = 0; i < myPropertyInfo.Length; i++)
            {

                PropertyInfo myPropInfo = (PropertyInfo)myPropertyInfo[i];
                Object obj1 = myPropInfo.GetValue(o1, null);
                Object obj2 = myPropInfo.GetValue(o2, null);

                if (obj1 == null || obj2 == null) Assert.AreEqual(obj1, obj2);


                if (obj1 != null && obj2 != null)
                {
                    if (typeof(ICollection).IsAssignableFrom(myPropInfo.PropertyType))
                    {
                        ICollection collection1 = (ICollection)obj1;
                        ICollection collection2 = (ICollection)obj2;
                        IEnumerator e1 = collection1.GetEnumerator();
                        IEnumerator e2 = collection2.GetEnumerator();

                        Assert.AreEqual(collection1.Count, collection2.Count);

                        while (e1.MoveNext())
                        {
                            e2.MoveNext();
                            Assert.AreEqual(e1.GetType(), e2.GetType());
                            CompareProperties(e1.Current.GetType(), e1.Current, e2.Current);
                        }
                    }
                    else
                    {
                        Assert.AreEqual(obj1, obj2);
                    }
                }

            }
        }


        /// <summary>
        ///A test for ParseString
        ///</summary>
        [TestMethod()]
        public void ParseStringTest()
        {
            String testString1 = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n" +
                                "<!DOCTYPE score-partwise PUBLIC\n" +
                                "\"-//Recordare//DTD MusicXML 3.0 Partwise//EN\"\n" +
                                "\"http://www.musicxml.org/dtds/partwise.dtd\">\n" +
                                "<score-partwise version=\"3.0\">\n" +
                                "<part-list><score-part id=\"P1\"><part-name>Music</part-name></score-part></part-list>" +
                                "<part id=\"P1\"><measure number=\"1\"><attributes><divisions>1</divisions><key>" +
                                "<fifths>0</fifths></key><time><beats>4</beats><beat-type>4</beat-type></time>" +
                                "<clef><sign>G</sign><line>2</line></clef></attributes>" +
                                "<note><pitch><step>C</step><octave>4</octave></pitch><duration>4</duration>" +
                                "<type>whole</type><stem>up</stem></note></measure></part></score-partwise>";
            // create the expected structure
            Note n = new Note()
            {
                type = new NoteType() { Value = NoteTypeValue.whole },
                stem = new Stem() { Value = stemvalue.up },
                Items = new object[] { new Pitch() { step = Step.C, octave = "4" }, new decimal(4) }
            };

            ScorePartwisePartMeasure m = new ScorePartwisePartMeasure()
            {
                number = "1",
                Items = new object[]{
                    new Attributes()
                    { 
                        divisions = 1, 
                        key = new Key[]
                        {
                            new Key()
                            { 
                                Items = new object[]
                                {
                                    new decimal(0)
                                }
                            }
                        }, 
                        time = new Time[]
                        {
                            new Time()
                            {
                                /*Items = new object[]
                                {
                                    new decimal(4),
                                    new decimal(4)
                                }*/
                                //todo: beats and beat type
                            }
                        }, 
                        clef = new Clef[]
                        {
                            new Clef()
                            {
                                sign = ClefSign.G,
                                line = "2"
                            }
                        }
                    },
                n
                }
            };
            
            ScorePartwise expected = new ScorePartwise() { version = "3.0" };

            ScorePartwise actual = ScorePartwise.Deserialize(testString1);
            CompareProperties(actual.GetType(), actual, expected);

            // assert inconclusive because this isn't done yet
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ParseFile
        ///</summary>
        [TestMethod()]
        public void ParseFileTest()
        {
            string fileName = string.Empty; // TODO: Initialize to an appropriate value
            //ScoreObject expected = null; // TODO: Initialize to an appropriate value
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
