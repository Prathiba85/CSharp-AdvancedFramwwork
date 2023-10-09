using EaFrameWork.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFrameWork.Driver
{
    public class DriverFixture : IDriverFixture, IDisposable

    {
        private readonly TestSettings _testSettings;
        public IWebDriver Driver { get; }



        public DriverFixture(TestSettings testSettings)

        {
            _testSettings = testSettings;
            Driver = GetWebDriver();
            Driver.Navigate().GoToUrl(_testSettings.ApplicaitonUrl);
        }
        private WebDriver GetWebDriver()
        {
            return _testSettings.BrosweType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),

                _ => new ChromeDriver(),
            };

        }

        public void Dispose()
        {
            Driver.Quit();
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Safari,
            EdgeChromium
        }
    }
}
