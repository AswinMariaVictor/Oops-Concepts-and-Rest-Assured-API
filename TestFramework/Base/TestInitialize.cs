using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestFramework.Base;

namespace TestFramework
{
    class TestInitialize : TestBase
    {

        public void TestFixtureSetUp()
        {
            //_browser.WebDriver = new ChromeDriver();
        }
        
        public void NavigateToApplication()
        {
            //_browser.WebDriver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }

        public void GenerateReport()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string name = TestContext.CurrentContext.Test.MethodName + "_screenshot" + DateTime.Now.Ticks + ".png";
                Screenshot screenshot = ((ITakesScreenshot)_browser.WebDriver).GetScreenshot();
                screenshot.SaveAsFile(name);
                TestContext.AddTestAttachment(name);
            }
        }

        public void TestFixtureTearDown()
        {
            _browser.WebDriver.Quit();
        }
     }
}
