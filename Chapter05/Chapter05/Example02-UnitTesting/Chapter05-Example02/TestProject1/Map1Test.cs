using Chapter05_Example02.Maps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for Map1Test and is intended
    ///to contain all Map1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Map1Test
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


        /// <summary>
        ///A test for Map1 Constructor
        ///</summary>
        [TestMethod()]
        public void Map1OutputTest()
        {
            Map1 target = new Map1();
            string input = @"C:\BTS2013CertGuide\Chapter05\Example02-UnitTesting\SimplifiedCar.xml";
            string output = @"C:\BTS2013CertGuide\Chapter05\Example02-UnitTesting\SimplifiedCar_MapOut.xml";
            target.TestMap(
                input,
                Microsoft.BizTalk.TestTools.Schema.InputInstanceType.Xml,
                output,
                Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML);
            Assert.IsTrue(File.Exists(output));
        }
    }
}
