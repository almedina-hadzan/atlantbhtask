using System;
using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AtlantBH_Task.TestCases
{
    public class BaseTest
    {
        private static Config config;
        protected static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static Config GetConfig()
        {
            return config;
        }

        [SetUp]
        public void SetUp()
        {
            config = Config.Load();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(config.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        // Selenium extensions
        public bool IsElementVisible(By by)
        {
            try
            {
                new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(2))
                .Until(ExpectedConditions.InvisibilityOfElementLocated(by));
                var element = GetDriver().FindElement(by);
                if (element.Displayed)
                    return true;
                else
                    return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

