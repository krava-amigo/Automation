using NUnit.Framework;
using OpenQA.Selenium;

namespace GoogleAutomationSearching.POMGoogle
{
    public class BasePage
    {
        protected readonly IWebDriver webDriver;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Actions

        public void OpenUrl(string url)
        {
            if (webDriver.Url != url)
            {
                webDriver.Url = url;
            }
        }

        #endregion

        #region ACV

        public void VerifyUrlIsCorrect(string expected)
        {
            var actual = webDriver.Url;
            Assert.AreEqual(expected, actual, "Verify url is correct");
        }
        
        public void VerifyUrlContainsText(string text, bool expected = true)
        {
            var actual = webDriver.Url.Contains(text);
            Assert.AreEqual(expected, actual, $"Verify url contains '{text}'");
        }

        #endregion
    }
}