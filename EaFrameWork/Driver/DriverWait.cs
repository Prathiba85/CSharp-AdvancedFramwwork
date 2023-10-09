using EaFrameWork.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFrameWork.Driver
{
    public class DriverWait : IDriverWait
    {
        private readonly IDriverFixture _driverFixture;
        private readonly TestSettings _testSettings;
        private readonly Lazy<WebDriverWait> _webdriverWait;
        public DriverWait(IDriverFixture driverFixture, TestSettings testSettings)
        {
            _driverFixture = driverFixture;
            _testSettings = testSettings;
            _webdriverWait = new Lazy<WebDriverWait>((GetWaitDriver));
        }

        public IWebElement FindElement(By elementLLocator)
        {
            return _webdriverWait.Value.Until(_ => _driverFixture.Driver.FindElement(elementLLocator));
        }

        public IEnumerable<IWebElement> FindElements(By elementLLocator)
        {
            return _webdriverWait.Value.Until(_ => _driverFixture.Driver.FindElements(elementLLocator));
        }

        private WebDriverWait GetWaitDriver()
        {
            return new WebDriverWait(_driverFixture.Driver, timeout: TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 30))
            {
                PollingInterval = TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 1)


            };

        }
    }
}
