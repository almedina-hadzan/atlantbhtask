using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AtlantBH_Task.Pages
{
    public class SignUp : Base
    {

        [FindsBy(How = How.Id, Using = "firstName")]
        IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement SubmitButton { get; set; }

        internal SignUp PopulateFirstName()
        {
            FirstNameTextBox.SendKeys(new RandomDataGenerator().GenerateFirstName());
            return SignUpPage;
        }

        internal SignUp PopulateLastName()
        {
            LastNameTextBox.SendKeys(new RandomDataGenerator().GenerateLastName());
            return SignUpPage;
        }

        internal SignUp PopulateEmail()
        {
            EmailTextBox.SendKeys(new RandomDataGenerator().GenerateEmail());
            return SignUpPage;
        }

        internal SignUp PopulatePassword()
        {
            PasswordTextBox.SendKeys(new RandomDataGenerator().GeneratePassword());
            return SignUpPage;
        }

        internal ContactList Submit()
        {
            SubmitButton.Click();
            return ContactListPage;
        }

    }
}

