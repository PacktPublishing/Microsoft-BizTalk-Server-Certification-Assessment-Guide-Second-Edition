using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter05_Example02.Schemas;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;

namespace TestProject1
{
    [TestClass]
    public class RcvCarTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestRcvCarTest()
        {
            RcvCar target = new RcvCar();

            StringCollection documents = new StringCollection();
            string sourceFile = @"C:\BTS2013CertGuide\Chapter05\Example02-UnitTesting\SimplifiedCar.xml";
            Assert.IsTrue(File.Exists(sourceFile));
            documents.Add(sourceFile);

            StringCollection parts = new StringCollection();

            Dictionary<string, string> schemas = new Dictionary<string, string>();
            string sourceSchema = @"C:\BTS2013CertGuide\Chapter05\Example02-UnitTesting\Chapter05-Example02\Chapter05-Example02.Schemas\SimplifiedCar.xsd";
            Assert.IsTrue(File.Exists(sourceSchema));
            schemas.Add("Chapter05_Example02.Schemas.SimplifiedCar", sourceSchema);

            target.TestPipeline(documents, parts, schemas);

            string[] strMessages = Directory.GetFiles(this.TestContext.TestDir + "\\out", "Message*.out");
            Assert.IsTrue(strMessages.Length > 0);
            SimplifiedCar car = new SimplifiedCar();
            foreach (string outFile in strMessages)
            {
                Assert.IsTrue(car.ValidateInstance(outFile, Microsoft.BizTalk.TestTools.Schema.OutputInstanceType.XML));
            }                     
        }
    }
}
