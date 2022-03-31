using GoogleAutomationSearching.Drivers;
using GoogleAutomationSearching.POMGoogle;
using TechTalk.SpecFlow;

namespace GoogleAutomationSearching.StepContext
{
    [Binding]
    public class GoogleMainPageSteps
    {
        private readonly GoogleMainPage _googleMainPage;
        
        public GoogleMainPageSteps(Driver driver)
        {
            _googleMainPage = new GoogleMainPage(driver.CurrentDriver);
        }
        
        [Given("(.*) page is opened")]
        public void GivenWebsiteIsOpened(string url)
        {
            _googleMainPage.VerifyUrlIsCorrect(url);
        }
        
        [Given("search field is visible")]
        public void GivenSearchFieldIsVisible()
        {
            _googleMainPage.VerifyInputSearchFieldIsVisible();
        }

        [When("search field is set to '(.*)'")]
        public void WhenSearchFieldIsSetToValue(string text)
        {
            _googleMainPage.SetInputSearchFieldValue(text);
        }

        [When("Google Search button is clicked")]
        public void WhenGoogleSearchButtonIsClicked()
        {
            _googleMainPage.ClickButtonGoogleSearch();
        }

        [Then("search field contains '(.*)'")]
        public void ThenSearchFieldContainsValue(string text)
        {
            _googleMainPage.VerifyInputSearchFieldTextIsCorrect(text);
        }
    }
}