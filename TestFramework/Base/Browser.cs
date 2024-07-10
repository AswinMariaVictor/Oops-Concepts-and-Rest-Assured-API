using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFramework.Base
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }

        public RemoteWebDriver ConcurrentDriver { get; set; }

        public ThreadLocal<IWebDriver> parallelDriver { get; set; }

        public bool parallelConfig { get; set; }
    }
}
