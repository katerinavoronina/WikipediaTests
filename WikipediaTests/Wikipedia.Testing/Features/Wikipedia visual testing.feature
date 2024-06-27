Feature: Wikipedia visual testing

Scenario: Wikipedia visual testing
	When I open Wikipedia main page
	Then The wikipedia main page is opened
		And The 'Logo' element is correctly displayed
