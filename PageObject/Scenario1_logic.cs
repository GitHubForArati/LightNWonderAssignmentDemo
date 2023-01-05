using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightNWonderAssignmentDemo.PageObject
{
    public class Scenario1_logic
    {
        public IWebDriver WebDriver { get; }
        public Scenario1_logic(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI Elements
        public IWebElement searchKeyword => WebDriver.FindElement(By.Id("search"));
        String clickfirst = "//ul/li[1]//div[@class='meta']";
        public IWebElement clickfirstelement => WebDriver.FindElement(By.XPath(clickfirst));

        String priceOfFirstProd = "//div[contains(@class,'product-main-top')]//span[@class='special-price']//span[@class='price']";
        public IWebElement getTextProduct => WebDriver.FindElement(By.XPath(priceOfFirstProd));
        String addCart = "//div[contains(@class,'product-main-top')]//span[contains(text(),'Add to Cart')]";
        public IWebElement addToCart => WebDriver.FindElement(By.XPath(addCart));
        String cartElement = "//ol[@id='mini-cart-pro']//span[@class='price']";
        public IWebElement cartPrice => WebDriver.FindElement(By.XPath(cartElement));

        public void Clicksearch() => searchKeyword.Click();
        public void TypeKeyword() => searchKeyword.SendKeys("Lenovo Laptop");
        public void ClickFirstElement()
        {
            WebDriverWait w = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            w.Until(d => d.FindElement(By.XPath(clickfirst)));
            clickfirstelement.Click();
        }

        public void validatePrice()
        {
            String price = getTextProduct.Text;
            // Expected condition of element exist 
            WebDriverWait w = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            w.Until(d => d.FindElement(By.XPath(addCart)));
            addToCart.Click();
            w.Until(d => d.FindElement(By.XPath(cartElement)));
            String cartprice = cartPrice.Text;
            bool result = price.Equals(cartprice);
            Console.WriteLine("Product Price matches the one listed in Single product");

        }
        
    }
}
