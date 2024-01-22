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

        public ContactList ValidateContactListPageDisplayed()
        {
            var expectedAddContactButtonText = Config.Load().AddContactButtonText;
            new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("add-contact")));

            var actualAddContactButtonText = GetDriver().FindElement(By.Id("add-contact")).Text;

            Assert.AreEqual(expectedAddContactButtonText, actualAddContactButtonText);
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
