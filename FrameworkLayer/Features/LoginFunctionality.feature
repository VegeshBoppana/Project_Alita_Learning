Feature: Login Functionality

  Scenario: Successful login with valid credentials
    Given I am on the login page
    When I enter a valid username and password
    And I click the login button
    Then I should be redirected to the homepage

  Scenario: Unsuccessful login with invalid username
    Given I am on the login page
    When I enter an invalid username and a valid password
    And I click the login button
    Then I should see an error message

  Scenario: Unsuccessful login with invalid password
    Given I am on the login page
    When I enter a valid username and an invalid password
    And I click the login button
    Then I should see an error message

  Scenario: Unsuccessful login with empty fields
    Given I am on the login page
    When I leave the username and password fields empty
    And I click the login button
    Then I should see an error message for required fields

  Scenario: Password field should mask input
    Given I am on the login page
    When I enter a password
    Then the password field should mask the input

  Scenario: Remember Me option
    Given I am on the login page
    When I select the Remember Me option
    And I enter valid credentials
    And I click the login button
    Then I should be logged in automatically next time