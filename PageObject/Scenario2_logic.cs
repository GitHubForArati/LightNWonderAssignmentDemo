using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LightNWonderAssignmentDemo.PageObject
{
    class Scenario2_logic
    {
        public IWebDriver WebDriver { get; }
        public Scenario2_logic(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        // UI Elements
        public IWebElement searchKeyword => WebDriver.FindElement(By.Id("search"));
        String searchbutton = "//div[@class='actions']//button";
        public IWebElement searchButton => WebDriver.FindElement(By.XPath(searchbutton));
        String sortelement = "//div[@class='search results']//div[1][contains(@class,'toolbar-prod')]//div[contains(@class,'sort')]/a";
        public IWebElement sortelmentdescending => WebDriver.FindElement(By.XPath(sortelement));
        String firstProd = "//div[contains(@class,'product-list-container')]//div[1][@class='search results']//ol//li[1]";
        public IWebElement firstProdElement => WebDriver.FindElement(By.XPath(firstProd));
        String Prod = "//div[contains(@class,'product-main-top')]//span[@class='price']";
        public IWebElement prodPriceElement => WebDriver.FindElement(By.XPath(Prod));
        String addbutton = "//div[@class='qty-ctl']//button[@title='Increase']";
        public IWebElement addbuttonElement => WebDriver.FindElement(By.XPath(addbutton));
        String addCart = "//div[contains(@class,'product-main-top')]//span[contains(text(),'Add to Cart')]";
        public IWebElement addToCart => WebDriver.FindElement(By.XPath(addCart));
        String cartElement = "//div[@class='cart-total']//span[@class='price']";
        public IWebElement cartPrice => WebDriver.FindElement(By.XPath(cartElement));
        public void searchByDescending()
        {
            searchKeyword.Click();
            searchKeyword.SendKeys("Apple Macbook");
            searchButton.Click();
            WebDriverWait w = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            w.Until(d => d.FindElement(By.XPath(sortelement)));
            sortelmentdescending.Click();
        }

        public void clickFirstProd() => firstProdElement.Click();
        public void validateProduct()
        {
            String prodPrice = prodPriceElement.Text;
            prodPrice = prodPrice.Remove(0, 1);
            int price = Int32.Parse(prodPrice);
            WebDriverWait w = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(20));
            w.Until(d => d.FindElement(By.XPath(addbutton)));
            addbuttonElement.Click();
            addToCart.Click();
            w.Until(d => d.FindElement(By.XPath(cartElement)));
            String cartprice = cartPrice.Text;
            cartprice = cartprice.Remove(0, 1);
            int cart = Int32.Parse(cartprice);
            if (cart == 2 * price)
            {
                Console.WriteLine("The Added item in cart matches the total price");
            }

        }
    }
}
