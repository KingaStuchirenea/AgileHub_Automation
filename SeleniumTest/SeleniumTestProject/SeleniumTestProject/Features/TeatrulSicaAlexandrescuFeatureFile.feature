Feature: TeatrulSicaAlexandrescuFeatureFile
	In order to validate accessing to first show
	As a visitor of the site
	I want to select the first show of the first member of the team

@SelectFirstShow
Scenario: select the first show of the first member of the team
	Given i navigate to team from page teatrulsicaalexandrescu.ro/?lang=en
	When i select the first show of the first member
	Then the url will be teatrulsicaalexandrescu.ro/prins-in-plasa/