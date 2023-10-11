Feature: Product
Create a Product

Scenario: Create product and verify the details 
	Given I click the Product menu
	And I click the "Create" link 
	And I create product with the following details
	| Name       | Description        | Price | ProductType |
	| Monitor | Noise Cancellation | 300   | PERIPHARALS |
	When I click the Details link of the newly created product
	Then I see all the product details are ceated as expected
