using OpenQA.Selenium;

namespace EaFrameWork.Driver
{
    public interface IDriverWait
    {
        IWebElement FindElement(By elementLLocator);
        IEnumerable<IWebElement> FindElements(By elementLLocator);
    }
}