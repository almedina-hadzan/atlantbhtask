using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AtlantBH_Task.Pages
{
    public class LogIn : Base
    {

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement SubmitButton { get; set; }

        internal LogIn PopulateEmail()
        {
            EmailTextBox.SendKeys(GetConfig().Email);
            return LogInPage;
        }

        internal LogIn PopulatePassword()
        {
            PasswordTextBox.SendKeys(GetConfig().Password);
            return LogInPage;
        }

        internal ContactList Submit()
        {
            SubmitButton.Click();
            return ContactListPage;
        }

    }
}