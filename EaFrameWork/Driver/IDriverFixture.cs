using OpenQA.Selenium;

namespace EaFrameWork.Driver
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}