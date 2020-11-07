Feature: DemositeFeatureFile
	In order to validate login with valid user, adding product in cart
	As a simple user/admin
	I want to authenticate into casqad.org, add product in cart

@LoginValidUser
Scenario: validate login with valid user
	Given i navigate to authentication page
	When i login with following credentials
		| userEmail           | userPassword |
		| john.miller@xyz.com | !123John     |
	Then i am logged in

@AddProductInCartAsUser
Scenario: add product in cart as user
	Given i login with valid user
		| userEmail           | userPassword |
		| john.miller@xyz.com | !123John     |
	When i add a product in cart
	Then i can order the product

@AddProductInCartAsAdmin
Scenario: add product in cart as admin
	Given i login with admin
		| userEmail             | userPassword |
		| admin.test3@gmail.com | password123  |
	When i add product in cart
	Then i can order product

@SignUpAndLogin
Scenario: sign up and login
	Given i sign up
	When i login with new user
	Then i can logout

@LoginLogoutWithValidUser
Scenario: login logout with valid user
	Given i login valid user
		| userEmail           | userPassword |
		| john.miller@xyz.com | !123John     |
	When i logout
	Then i can login again

@GoTroughtHorizontalMenus
Scenario: go trought horizontal menus
	Given i navigate to demosite
	When i go trought horizontal menus
	Then i arrive to accesorii url

@AsAdminOpenAdministrare
Scenario: as admin open administrare menu
	Given i login with admin user
	When i go to administrare menu
	Then utilizatori menu is displayed

@AsAdminOpenUtilizatori
Scenario: as admin open utilizatori menu
	Given i login with the admin
	When i go to utilizatori menu
	Then nume header is displayed

@AsAdminEditUser
Scenario: as admin edit user
	Given i access utilizatori menu as admin
	When i select and edit a user
	Then user role is displayed