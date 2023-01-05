using LightNWonderAssignmentDemo.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LightNWonderAssignmentDemo.Steps
{
    [Binding]
    public sealed class Scenario1
    {
        PageObject.Scenario1_logic loginPage = null;

        //Step Defination
        [Given(@"Login to the site ""(.*)""")]
        public void GivenLoginToTheSite(string p0)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.scanmalta.com/");
            loginPage = new PageObject.Scenario1_logic(webDriver);
        }

        [Given(@"Search for the keyword")]
        public void GivenSearchForTheKeyword(Table table)
        {
            loginPage.Clicksearch();
            loginPage.TypeKeyword();
        }


        [Given(@"Once the page is loaded click the first product search result and add it to cart")]
        public void GivenOnceThePageIsLoadedClickTheFirstProductSearchResultAndAddItToCart()
        {
            loginPage.ClickFirstElement();
        }

        [Then(@"Assert the item added in cart matched the price in the one listed in single product page")]
        public void ThenAssertTheItemAddedInCartMatchedThePriceInTheOneListedInSingleProductPage()
        {
            loginPage.validatePrice();
        }

    }
}
