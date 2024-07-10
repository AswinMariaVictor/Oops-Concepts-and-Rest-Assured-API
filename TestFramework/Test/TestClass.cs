using NUnit.Framework;
using PageClass.Pages;
using TestFramework.API;
using TestFramework.Base;


namespace TestFramework
{
    class TestClass : TestInitialize
    {
        #region Page Class Objects

        /// <summary>
        ///  Login page object
        /// </summary>
        private readonly LoginPage loginPage;

        /// <summary>
        /// Rest api page object
        /// </summary>
        private readonly RestAPI restapi;

        #endregion Page Class Objects

        public TestClass()
        {
            loginPage = new LoginPage(_browser);
             restapi = new RestAPI();
        }

        [OneTimeSetUp]
        public void TestFixtureInitialization()
        {
            TestFixtureSetUp();
        }

        [SetUp]
        public void TestInitialization() => NavigateToApplication();

        [TearDown]
        public void TestClosure()
        {
            GenerateReport();
        }

        [OneTimeTearDown]
        public void TestFixtureClosure()
        {
            TestFixtureTearDown();
        }

        [Test]
        [Order(1)]
        public void TestMethod()
        {
            //loginPage.EnterFirstName();
            restapi.GetApiMethod();
            restapi.PostApiMethod();
        }
    }
}
