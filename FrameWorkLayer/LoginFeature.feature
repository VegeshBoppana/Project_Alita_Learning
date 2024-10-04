Feature: Login Functionality

Scenario: Valid Login
    Given I am on the login page
    When I enter a valid username and password
    And I click the login button
    Then I should be redirected to the homepage

Scenario: Invalid Username
    Given I am on the login page
    When I enter an invalid username and a valid password
    And I click the login button
    Then I should see an error message "Invalid username/email"

Scenario: Invalid Password
    Given I am on the login page
    When I enter a valid username and an invalid password
    And I click the login button
    Then I should see an error message "Invalid password"

Scenario: Empty Credentials
    Given I am on the login page
    When I leave the username and password fields empty
    And I click the login button
    Then I should see an error message "Both fields are required"

Scenario: Password Masking
    Given I am on the login page
    When I enter any characters in the password field
    Then the characters should be masked

Scenario: Remember Me Option
    Given I am on the login page
    When I enter a valid username and password
    And I select the 'Remember Me' option
    And I click the login button
    And I close and reopen the browser
    And I navigate to the website
    Then I should be logged in automatically