Feature: GoogleSearch
	Google search Automation

Scenario: Enter search value and verify result
	Given https://www.google.com/ page is opened
	And search field is visible
	When search field is set to '<query>'
	Then search field contains '<query>'
	When Google Search button is clicked
	Then search results page is opened
	And first 5 results consist of '<query>'
	
Examples:
	| query      |
	| Automation |