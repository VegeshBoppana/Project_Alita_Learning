using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace FrameworkLayer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.amazon.com/ap/signin");
        }

        [When(@"I enter a valid username/email and valid password")]
        public void WhenIEnterAValidUsernameEmailAndValidPassword()
        {
            _driver.FindElement(By.Id("ap_email")).SendKeys("valid_username");
            _driver.FindElement(By.Id("continue")).Click();
            _driver.FindElement(By.Id("ap_password")).SendKeys("valid_password");
        }

        [When(@"I click the 'Login' button")]
        public void WhenIClickTheLoginButton()
        {
            _driver.FindElement(By.Id("signInSubmit")).Click();
        }

        [Then(@"I should be successfully logged in and redirected to the homepage/dashboard")]
        public void ThenIShouldBeSuccessfullyLoggedInAndRedirectedToTheHomepageDashboard()
        {
            Assert.IsTrue(_driver.Url.Contains("homepage"));
        }

        // Additional step definitions for other scenarios...
    }
}
