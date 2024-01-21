using System;
using AtlantBH_Task.Pages;
using OpenQA.Selenium.Chrome;
using static AtlantBH_Task.Pages.Base;

namespace AtlantBH_Task.TestCases
{
    public class TestCases : BaseTest
    {
        [Test]
        public void ValidateSignUp()
        {
            HomePage
                .ClickSignUp();

            SignUpPage
               .PopulateFirstName()
               .PopulateLastName()
               .PopulateEmail()
               .PopulatePassword()
               .Submit();

            ContactListPage
               .ValidateContactListPageDisplayed();
        }

        [Test]
        public void ValidateLogIn()
        {
            LogInPage
                .PopulateEmail()
                .PopulatePassword()
                .Submit();

            ContactListPage
              .ValidateContactListPageDisplayed();
        }

        [Test]
        public void ValidateAddNewContact()
        {
            LogInPage
                .PopulateEmail()
                .PopulatePassword()
                .Submit();

            ContactListPage
                .AddNewContact();

            AddNewContactPage
                .PopulateFirstName()
                .PopulateLastName()
                .PopulateDateOfBirth()
                .PopulateEmail()
                .PopulatePhone()
                .PopulateStreetAddress1()
                .PopulateStreetAddress2()
                .PopulateCity()
                .PopulateStateOrProvince()
                .PopulatePostalCode()
                .PopulateCountry()
                .Submit()
                .ValidateNoErrorsDisplayed();
        }
    }
}

