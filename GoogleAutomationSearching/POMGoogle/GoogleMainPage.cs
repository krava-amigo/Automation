using NUnit.Framework;
using OpenQA.Selenium;
using static GoogleAutomationSearching.Constants.XPaths.GoogleMainPage;

namespace GoogleAutomationSearching.POMGoogle
{
    public class GoogleMainPage : BasePage
    {
        public GoogleMainPage(IWebDriver driver) : base(driver)
        {
            
        }

        private IWebElement EditSearchField => webDriver.FindElement(By.XPath(EditSearchFieldXPath));
        private IWebElement ButtonGoogleSearch => webDriver.FindElement(By.XPath(ButtonGoogleSearchXPath));

        #region Actions

        public void SetInputSearchFieldValue(string text)
        {
            EditSearchField.Clear();
            EditSearchField.SendKeys(text);
        }

        public void ClickButtonGoogleSearch()
        {
            ButtonGoogleSearch.Click();
        }

        #endregion

        #region ACV

        public void VerifyInputSearchFieldIsVisible(bool expected = true)
        {
            var actual = EditSearchField.Displayed;
            Assert.AreEqual(expected, actual, "Verify search field is visible");
        }

        public void VerifyInputSearchFieldTextIsCorrect(string expected)
        {
            var actual = EditSearchField.GetAttribute("value");
            Assert.AreEqual(expected, actual, "Verify search field is correct");
        }

        #endregion
    }
}