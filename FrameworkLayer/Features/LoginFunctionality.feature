Feature: Test Login Functionality

  Scenario: Valid username/email and password
    Given I navigate to the login page
    When I enter a valid username/email and valid password
    And I click the 'Login' button
    Then the user is successfully logged in and redirected to the homepage/dashboard

  Scenario: Invalid username/email
    Given I navigate to the login page
    When I enter an invalid username/email
    And I enter a valid password
    And I click the 'Login' button
    Then an error message 'Invalid username/email' is displayed, and the user remains on the login page

  Scenario: Invalid password
    Given I navigate to the login page
    When I enter a valid username/email
    And I enter an invalid password
    And I click the 'Login' button
    Then an error message 'Invalid password' is displayed, and the user remains on the login page

  Scenario: Leave both fields empty
    Given I navigate to the login page
    When I leave the username/email and password fields empty
    And I click the 'Login' button
    Then an error message 'Both fields are required' is displayed

  Scenario: Password masking
    Given I navigate to the login page
    When I enter any characters in the password field
    Then the password characters should be masked

  Scenario: Remember Me option
    Given I navigate to the login page
    When I enter a valid username/email and password
    And I select the 'Remember Me' option
    And I click the 'Login' button
    And I close and reopen the browser
    And I navigate to the website
    Then the user should be logged in automatically without entering credentials again