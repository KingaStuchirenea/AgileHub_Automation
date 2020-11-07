Feature: AuthenticationTestsFeature
	In order to validate login
	As an admin user
	I want to authenticate into casqad.org

@SmokeTest
@Jira-Number
Scenario: ValidateLogin
	Given I navigate authentication page
	When I login with following credentials:
		| userEmail             | userPassword |
		| admin.test3@gmail.com | password123  |
	#When I login with user: 'admin.test3@gmail.com'
	#And  password: 'password123'
	Then I am logged in