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
    public sealed class Scenario2
    {
        PageObject.Scenario2_logic loginPage = null;

        //Step Defination
        [Given(@"Login to the site ""(.*)""")]
        public void GivenLoginToTheSite(string p0)
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.scanmalta.com/");
            loginPage = new PageObject.Scenario2_logic(webDriver);
        }

        [Given(@"Search for the keyword ""(.*)"" and sort it in descending")]
        public void GivenSearchForTheKeywordAndSortItInDescending(string p0)
        {
            loginPage.searchByDescending();
        }

        [Given(@"Once the page is loaded click the first product search result and add it to cart twice")]
        public void GivenOnceThePageIsLoadedClickTheFirstProductSearchResultAndAddItToCartTwice()
        {
            loginPage.clickFirstProd();
        }

        [Then(@"Assert the item added in cart matched the price and pricing total of both are correct")]
        public void ThenAssertTheItemAddedInCartMatchedThePriceAndPricingTotalOfBothAreCorrect()
        {
            loginPage.validateProduct();
        }

    }
}
