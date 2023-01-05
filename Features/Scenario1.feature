Feature: Login
	Search for the keyword “Lenovo Laptop”. Once the search page
    has loaded click on the first item in the “Product Search result” list. Now add
    the product to your shopping cart. Assert that the item has been added to
    your cart successfully and that the product pricing matches the one listed
    in the single product page view.

@Scenario1
Scenario: Validate the product added succesfully to cart
	#Steps
	Given Login to the site "https://www.scanmalta.com/shop/"
	And Search for the keyword 
	And Once the page is loaded click the first product search result and add it to cart
	Then Assert the item added in cart matched the price in the one listed in single product page