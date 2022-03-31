using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using static GoogleAutomationSearching.Constants.XPaths.GoogleSearchResultsPage;

namespace GoogleAutomationSearching.POMGoogle
{
    public class GoogleSearchResultsPage : BasePage
    {
        public GoogleSearchResultsPage(IWebDriver driver) : base(driver)
        {
            
        }

        private List<IWebElement> ListSearchResults => webDriver.FindElements(By.XPath(SearchResultsXPath)).ToList();

        #region Verification

        public void VerifyFirstAmountOfSearchResultsContainText(int countOfResults, string text, bool expected = true)
        {
            List<bool> expectedList = Enumerable.Repeat(expected, countOfResults).ToList();
            List<bool> actualList = new List<bool>();
            for (var i = 0; i < countOfResults; i++)
            {
                var actual = ListSearchResults[i].Text.ToLower().Contains(text.ToLower());
                actualList.Add(actual);
            }
            Assert.AreEqual(expectedList, actualList, $"Verify that first {countOfResults} contain {text}");
        }

        #endregion
    }
}