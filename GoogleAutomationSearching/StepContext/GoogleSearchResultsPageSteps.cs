using GoogleAutomationSearching.Drivers;
using GoogleAutomationSearching.POMGoogle;
using TechTalk.SpecFlow;
using static GoogleAutomationSearching.Constants.Urls;

namespace GoogleAutomationSearching.StepContext
{
    [Binding]
    public class GoogleSearchResultsPageSteps
    {
        private readonly GoogleSearchResultsPage _googleSearchResultsPage;

        public GoogleSearchResultsPageSteps(Driver driver)
        {
            _googleSearchResultsPage = new GoogleSearchResultsPage(driver.CurrentDriver);
        }

        [Then("search results page is opened")]
        public void ThenSearchResultsPageIsOpened()
        {
            _googleSearchResultsPage.VerifyUrlContainsText(GoogleSearchPageUrl);
        }

        [Then("first (\\d+) results consist of '(.*)'")]
        public void ThenFirstCountOfResultsContainsText(int numberOfResults, string text)
        {
            _googleSearchResultsPage.VerifyFirstAmountOfSearchResultsContainText(numberOfResults, text);
        }
    }
}