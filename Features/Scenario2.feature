Feature: Login
	Search for the keyword “Apple Macbook”. Once the search page
	has loaded sort by “Price Descending” and click on the first item in the
	“Product Search result” list. Now add the product twice to your cart. Assert
	that you have both items in your cart and that the pricing total of both items
	is correct.

@Scenario1
Scenario: Validate the product added succesfully to cart
	#Steps
	Given Login to the site "https://www.scanmalta.com/shop/"
	And Search for the keyword "Apple Macbook" and sort it in descending
	And Once the page is loaded click the first product search result and add it to cart twice
	Then Assert the item added in cart matched the price and pricing total of both are correct