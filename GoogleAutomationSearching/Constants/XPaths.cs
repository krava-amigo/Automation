namespace GoogleAutomationSearching.Constants
{
    public static class XPaths
    {
        public static class GoogleMainPage
        {
            public static string EditSearchFieldXPath = "//input[@role='combobox']",
                ButtonGoogleSearchXPath = "//div[contains(@jsaction, 'mouseout')]//input[@name='btnK' and not(ancestor::div[contains(@style, 'display:none')])]";
        }

        public static class GoogleSearchResultsPage
        {
            public static string SearchResultsXPath = "//div[@data-sokoban-container]";
        }
    }
}