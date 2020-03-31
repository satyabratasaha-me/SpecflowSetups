Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@p2
Scenario: Navigate Login Page
	When I click to navigate to Login page
	Then I land to Login Page successfully


@p1
Scenario: Sign In 
	When I click to navigate to Login page
	And I Sign In using the below details
		| username      | password |
		| xyz@gmail.com | password |
	Then I see the welcome page

@p2
Scenario: Sign Up Link 
	When I click to navigate to Login page
	Then I see the sign up link