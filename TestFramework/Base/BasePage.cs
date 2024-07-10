using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Base
{
    public class BasePage
    {
        protected readonly Browser Browser;

        public IWebDriver _browserDriver => Browser.parallelConfig ? Browser.parallelDriver.Value : Browser.WebDriver;

        public string GetCurrentUrl => _browserDriver.Url;

        public string GetHeadTitle => _browserDriver.Title;

        public BasePage(Browser browser)
        {
            Console.WriteLine("Inherited class: " + GetType().Name);
            Browser = browser;
        }
    }
}
