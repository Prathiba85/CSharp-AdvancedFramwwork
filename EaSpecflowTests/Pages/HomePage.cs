
using EaFrameWork.Driver;
using OpenQA.Selenium;


namespace EaApplicaitonTest.Pages
{
    public interface IHomePage
    {
        void ClickProduct();

    }
  public  class HomePage : IHomePage    {
        private readonly IDriverWait _driver;

        public HomePage(IDriverWait driver)
        {
            _driver = driver;
        }

        private IWebElement lnkHome => _driver.FindElement(By.LinkText("Home"));
        private IWebElement lnkProduct => _driver.FindElement(By.LinkText("Product"));
        private IWebElement lnkCreate => _driver.FindElement(By.LinkText("Create"));
        private IWebElement lnkPrivacy => _driver.FindElement(By.LinkText("Privacy"));
       

      

        public void ClickProduct()
        {
            lnkProduct.Click();
        
        }

        

    }
}
