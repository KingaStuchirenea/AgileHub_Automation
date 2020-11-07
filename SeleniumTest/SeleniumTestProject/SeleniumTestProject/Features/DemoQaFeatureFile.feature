Feature: DemoQaFeatureFile
	In order to validate populating the page and submitting
	As a visitor of the site
	I want to populate the form/textbox and submit

@AutomationPracticeForm
Scenario: populate the fields for the form and submit
	Given i navigate to page demoqa.com/automation-practice-form
	When i populate all the fields and submit
	Then thanks for submitting the page text is displayed

@Text-box
Scenario: populate the fields for textbox and submit
	Given i navigate to page demoqa.com/textbox
	When i populate all fields and submit
	Then name details are displayed