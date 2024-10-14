using OpenQA.Selenium;
using System;

namespace PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        // Locators
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("loginButton");
        private By errorMessage = By.Id("errorMessage");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLogin()
        {
            driver.FindElement(loginButton).Click();
        }

        public string GetErrorMessage()
        {
            return driver.FindElement(errorMessage).Text;
        }
    }
}