using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageClass.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
        }

        #region Page Locators

        /// <summary>
        /// Element for login button
        /// </summary>
        private readonly string _firstNameLocator = "//input[@placeholder='First Name']";

        private IWebElement FirstName => _driver.FindElement(By.XPath(_firstNameLocator));
        #endregion Page Locators

        #region Page Funtions

        public void EnterFirstName()
        {
            _wait.Until(ExpectedConditions.)
            
        }
        #endregion Page Functions
    }
}
