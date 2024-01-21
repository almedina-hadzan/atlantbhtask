using System;
using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        public bool IsElementPresent(By by)
        {
            try
            {
                GetDriver().FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}

