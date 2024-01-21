using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AtlantBH_Task.Pages
{
    public class AddNewContact : Base
    {

        [FindsBy(How = How.Id, Using = "firstName")]
        IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "birthdate")]
        IWebElement DateOfBirthTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement EmailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "phone")]
        IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "street1")]
        IWebElement StreetAddress1TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "street2")]
        IWebElement StreetAddress2TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "stateProvince")]
        IWebElement StateOrProvinceTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "postalCode")]
        IWebElement PostalCodeTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "country")]
        IWebElement CountryTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        IWebElement SubmitButton { get; set; }

        internal AddNewContact PopulateFirstName()
        {
            string contactFirstName = new RandomDataGenerator().GenerateFirstName();
            FirstNameTextBox.SendKeys(contactFirstName);
            return AddNewContactPage;
        }

        internal AddNewContact PopulateLastName()
        {
            LastNameTextBox.SendKeys(new RandomDataGenerator().GenerateLastName());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateDateOfBirth()
        {
            DateOfBirthTextBox.SendKeys(new RandomDataGenerator().GenerateDateOfBirth());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateEmail()
        {
            EmailTextBox.SendKeys(new RandomDataGenerator().GenerateEmail());
            return AddNewContactPage;
        }

        internal AddNewContact PopulatePhone()
        {
            PhoneTextBox.SendKeys(new RandomDataGenerator().GeneratePhone());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateStreetAddress1()
        { 

            StreetAddress1TextBox.SendKeys(new RandomDataGenerator().GenerateStreetAddress1());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateStreetAddress2()
        {
            StreetAddress2TextBox.SendKeys(new RandomDataGenerator().GenerateStreetAddress2());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateCity()
        {
            CityTextBox.SendKeys(new RandomDataGenerator().GenerateCity());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateStateOrProvince()
        {
            StateOrProvinceTextBox.SendKeys(new RandomDataGenerator().GenerateStateOrProvince());
            return AddNewContactPage;
        }

        internal AddNewContact PopulatePostalCode()
        {
            PostalCodeTextBox.SendKeys(new RandomDataGenerator().GeneratePostalCode());
            return AddNewContactPage;
        }

        internal AddNewContact PopulateCountry()
        {
            CountryTextBox.SendKeys(new RandomDataGenerator().GenerateCountry());
            return AddNewContactPage;
        }

        internal AddNewContact Submit()
        {
            SubmitButton.Click();
            return AddNewContactPage;
        }

    }
}

