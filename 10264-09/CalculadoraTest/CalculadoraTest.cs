using _002_UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace CalculadoraTest
{
    
    
    /// <summary>
    ///This is a test class for CalculadoraTest and is intended
    ///to contain all CalculadoraTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculadoraTest
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
        ///A test for Somar
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Desktop\\MOC-10264\\10264-09\\002-UnitTest", "/")]
        [UrlToTest("http://localhost:1053/WebForm1.aspx")]
        public void SomarTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            double x = 10; // TODO: Initialize to an appropriate value
            double y = 20; // TODO: Initialize to an appropriate value
            double expected = 30; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Somar(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subtrair
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Desktop\\MOC-10264\\10264-09\\002-UnitTest", "/")]
        [UrlToTest("http://localhost:1053/WebForm1.aspx")]
        public void SubtrairTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            double x = 10; // TODO: Initialize to an appropriate value
            double y = 20; // TODO: Initialize to an appropriate value
            double expected = -10; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Subtrair(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Multiplicar
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Desktop\\MOC-10264\\10264-09\\002-UnitTest", "/")]
        [UrlToTest("http://localhost:1053/WebForm1.aspx")]
        public void MultiplicarTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            double x = 10; // TODO: Initialize to an appropriate value
            double y = 20; // TODO: Initialize to an appropriate value
            double expected = 200; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Multiplicar(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dividir
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Desktop\\MOC-10264\\10264-09\\002-UnitTest", "/")]
        [UrlToTest("http://localhost:1053/WebForm1.aspx")]
        public void DividirTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            double x = 10; // TODO: Initialize to an appropriate value
            double y = 20; // TODO: Initialize to an appropriate value
            double expected = 0.5; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.Dividir(x, y);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
