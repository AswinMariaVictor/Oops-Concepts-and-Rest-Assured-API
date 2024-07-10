using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Base;

namespace PageClass.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(Browser browser) : base(browser)   { }

        #region Page Locators

        /// <summary>
        /// Element for login button
        /// </summary>
        private readonly string _firstNameLocator = "//input[@placeholder='First Name']";

        private IWebElement FirstName => _browserDriver.FindElement(By.XPath(_firstNameLocator));

        #endregion Page Locators

        #region Page Funtions

        public void EnterFirstName()
        {
            FirstName.SendKeys("Name");
            WebDriverWait wait = new WebDriverWait(_browserDriver, TimeSpan.FromSeconds(10));
            //wait.Until(Expected)
        }
        #endregion Page Functions
    }
}
