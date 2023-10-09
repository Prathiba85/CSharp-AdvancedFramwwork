using EaFrameWork.Config;
using EaFrameWork.Driver;
using EaFrameWork.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EaApplicaitonTest
{
    public class UnitTest1 : IDisposable
    {
        private IDriverFixture _driverFixture;
       
        public UnitTest1()
        {
            var testSettings = new TestSettings()
            {
                BrosweType = DriverFixture.BrowserType.Chrome,
                ApplicaitonUrl = new Uri("http://localhost:33084/"),
                TimeoutInterval = 30
            };
            _driverFixture = new DriverFixture(testSettings);
        }

        [Fact]
         public void Test1()
        {
            //Create objects for page
        var homePage = new HomePage(_driverFixture);
          var  productpage = new ProductPage(_driverFixture);


            //Click the create link
            homePage.ClickProduct();

            //Create Product

            productpage.ClickCreateButton();
            productpage.CreateProduct("FirstProduct10","description of product","200","MONITOR");
            productpage.PerformClickonSpecialValue("FirstProduct10", operation: "Details");
         
            
        }

        

        public void Dispose()
        {
           _driverFixture.Driver.Quit();
        }

    }
}