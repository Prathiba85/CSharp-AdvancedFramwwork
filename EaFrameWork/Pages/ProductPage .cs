using EaFramework.Extensions;
using EaFrameWork.Driver;
using EaFrameWork.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaFrameWork.Pages
{
  public  class ProductPage
    {
        private readonly IWebDriver driver;

        public ProductPage(IDriverFixture driverFixture)
        {

          driver = driverFixture.Driver;

        }
      
        private IWebElement lnkCreate => driver.FindElement(By.LinkText("Create"));
        private IWebElement txtName => driver.FindElement(By.Id("Name"));
        private IWebElement txtDescription => driver.FindElement(By.Name("Description"));
        private IWebElement txtPrice => driver.FindElement(By.Id("Price"));
        private IWebElement ddlProductType => driver.FindElement(By.Id("ProductType"));
        private IWebElement btnCreate => driver.FindElement(By.Id("Create"));
        private IWebElement tbllist => driver.FindElement(By.CssSelector(".table"));

        public void ClickCreateButton()=>lnkCreate.Click();
        

        
        public void CreateProduct(String name, String description,string price, string productType)
        {
            txtName.SendKeys(name);
            txtDescription.SendKeys(description);   
            txtPrice.SendKeys(price);
            ddlProductType.SelectDropDownByText(productType);
            btnCreate.Click();

            
        }
        public void PerformClickonSpecialValue(string name, string operation)

        {

            tbllist.PerformActionOnCell("5", "Name", "Monitor", operation);

        }

    }
}
