using EaApplicaitonTest.Models;
using EaApplicaitonTest.Pages;
using TechTalk.SpecFlow.Assist;

namespace EaSpecflowTests.StepDefinitions
{
    [Binding]
    public sealed class ProductDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IHomePage _homePage;
        private readonly IProductPage _productPage;

        public ProductDefinitions(ScenarioContext scenarioContext, IHomePage homePage, IProductPage productpage)
        {
            _scenarioContext = scenarioContext;
            _homePage = homePage;
            _productPage = productpage;
        }
        [Given(@"I click the Product menu")]
        public void GivenIClickTheProductMenu()
        {
            _homePage.ClickProduct();
        }

        [Given(@"I click the ""(.*)"" link")]
        public void GivenIClickTheLink(string createS0)
        {
            _productPage.ClickCreateButton();
        }

        [Given(@"I create product with the following details")]
        public void GivenICreateProductWithTheFollowingDetails(Table table)
        {
            var product = table.CreateInstance<Product>();
            _productPage.CreateProduct(product);
            _scenarioContext.Set<Product>(product);
        }

        [When(@"I click the Details link of the newly created product")]
        public void WhenIClickTheDetailsLinkOfTheNewlyCreatedProduct()
        {
            var product = _scenarioContext.Get<Product>();
            _productPage.PerformClickonSpecialValue(product.Name, "Details");
        }

        [Then(@"I see all the product details are ceated as expected")]
        public void ThenISeeAllTheProductDetailsAreCeatedAsExpected()
        {
            var product = _scenarioContext.Get<Product>();
           // _productPage.getProductName().Should().BeEquivalentTo(product.Name.Trim());
        }
    }


}
     
