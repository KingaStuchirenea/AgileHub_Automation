Feature: GooglePageFeatureFile
	In order to validate search of a picture
	As a user
	I want to search for a picture on google page

@SmokeTest
Scenario: Search for "paris", go to Images, click on the first picture and go back
	Given i search for paris on google homepage
	When i go to images first picture and back
	Then the first picture with paris is displayed