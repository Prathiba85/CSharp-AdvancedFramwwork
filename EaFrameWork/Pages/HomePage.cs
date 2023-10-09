using EaFramework.Extensions;
using EaFrameWork.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFrameWork.Pages
{
    public interface IHomePage
    {
        void ClickProduct();

    }
  public  class HomePage : IHomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
        }

        private IWebElement lnkHome => driver.FindElement(By.LinkText("Home"));
        private IWebElement lnkProduct => driver.FindElement(By.LinkText("Product"));
        private IWebElement lnkCreate => driver.FindElement(By.LinkText("Create"));
        private IWebElement lnkPrivacy => driver.FindElement(By.LinkText("Privacy"));
       


        

        public void ClickProduct()
        {
            lnkProduct.Click();
        
        }

        

    }
}
