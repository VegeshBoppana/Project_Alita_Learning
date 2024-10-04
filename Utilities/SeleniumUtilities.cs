using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Utilities
{
    public static class SeleniumUtilities
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        public static void StartBrowser(string browserType)
        {
            // Initialize WebDriver based on browserType
            if (browserType.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {
                driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            }
            else if (browserType.Equals("Firefox", StringComparison.OrdinalIgnoreCase))
            {
                driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            }
            // Add more browsers as needed
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }

        public static void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public static void EnterText(By locator, string text)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        public static void Click(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public static string GetText(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Text;
        }

        public static void WaitForElement(By locator, int timeoutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void TakeScreenshot(string filePath)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }
    }
}