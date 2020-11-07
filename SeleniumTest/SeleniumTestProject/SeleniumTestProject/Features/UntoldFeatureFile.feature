Feature: UntoldFeatureFile
	In order to validate home access
	As a visitor of the site
	I want to navigate to home from menu

@GoToHomeFromMenu
Scenario: navigate to home from menu
	Given i navigate to untold.com page
	When i select home from menu
	Then the url will be untold.com