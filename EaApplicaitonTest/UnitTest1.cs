using AutoFixture.Xunit2;
using EaApplicaitonTest.Models;
using EaApplicaitonTest.Pages;

namespace EaApplicaitonTest
{
    public class UnitTest1 
    {
        /*
           private readonly IHomePage _homePage;
           private readonly IProductPage _productPage;
           public UnitTest1(IHomePage homePage,IProductPage productPage)
           {


               _homePage = homePage;
               _productPage = productPage;

           }
           /*
           [Theory]
           [InlineData("FirstProduct2","description of product","200","CPU")]
           [InlineData("FirstProduct3", "description of product", "200", "CPU")]
           [InlineData("FirstProduct4", "description of product", "200", "CPU")]
           public void Test1(string name,string description, string price,string productType)
           {
               //Create objects for page
           var homePage = new HomePage(_driverFixture);
             var  productpage = new ProductPage(_driverFixture);


               //Click the create link
               homePage.ClickProduct();

               //Create Product

               productpage.ClickCreateButton();
               productpage.CreateProduct(name,description,price,productType);
               productpage.PerformClickonSpecialValue(name, "Details");


           }*/
        /* Method without Autofixture
        [Fact]
        public void Test1()
        {
            //Create objects for page
            var homePage = new HomePage(_driverFixture);
            var productpage = new ProductPage(_driverFixture);
            Product product = new Product()
            {
                Name = "NewProd",
                Description = "New Product",
                Price = 1000,
                ProductType = ProductType.EXTERNAL
            };
            //Click the create link
            homePage.ClickProduct();

            //Create Product

            productpage.ClickCreateButton();
            productpage.CreateProduct(product);
            productpage.PerformClickonSpecialValue(product.Name, "Details");


        }

        [Theory]
        [AutoData]
        public void CreateProduct(Product product)
        {
            
            //Click the create link
            _homePage.ClickProduct();

            //Create Product

            _productPage.ClickCreateButton();
            _productPage.CreateProduct(product);
            _productPage.PerformClickonSpecialValue(product.Name,"Details");


        }*/
        
        private readonly IHomePage _homePage;
        private readonly IProductPage _productPage;

        public UnitTest1(IHomePage homePage, IProductPage productPage)
        {
            _homePage = homePage;
            _productPage = productPage;
        }

        [Theory]
        [AutoData]
        public void CreateProduct(Product product)
        {
            //Click the Create link
            _homePage.ClickProduct();

            //Create product
            _productPage.ClickCreateButton();
            _productPage.CreateProduct(product);
            _productPage.PerformClickonSpecialValue(product.Name, "Details");
        }

    }
}