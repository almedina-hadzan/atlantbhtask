using System;
using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace AtlantBH_Task.Pages
{
    public class ContactList : Base
    {
        [FindsBy(How = How.Id, Using = "add-contact")]
        IWebElement AddContactButton { get; set; }

        public ContactList ValidateLoggedIn()
        {
            new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("add-contact")));
            return ContactListPage;
        }

        internal AddNewContact AddNewContact()
        {
            new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("add-contact")));
            AddContactButton.Click();

            return AddNewContactPage;
        }
    }
}

