using EaFrameWork.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
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
            Driver = _testSettings.TestRunType == TestRunType.Local ? GetWebDriver() : GetRemoteWebDriver();
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

        private IWebDriver GetRemoteWebDriver()
        {
            return _testSettings.BrosweType switch
            {
                BrowserType.Chrome => new RemoteWebDriver(_testSettings.GridUri, new ChromeOptions()),
                BrowserType.Firefox => new RemoteWebDriver(_testSettings.GridUri, new FirefoxOptions()),
                BrowserType.Safari => new RemoteWebDriver(_testSettings.GridUri, new SafariOptions()),
                _ => new RemoteWebDriver(_testSettings.GridUri, new ChromeOptions())
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
