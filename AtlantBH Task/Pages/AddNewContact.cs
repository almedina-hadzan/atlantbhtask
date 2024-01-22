using AtlantBH_Task.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

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

        private static string FirstName { get; set; }
        private static string LastName { get; set; }

        internal AddNewContact PopulateFirstName()
        {
            FirstName = new RandomDataGenerator().GenerateFirstName();
            FirstNameTextBox.SendKeys(FirstName);
            return AddNewContactPage;
        }

        internal AddNewContact PopulateLastName()
        {
            LastName = new RandomDataGenerator().GenerateLastName();
            LastNameTextBox.SendKeys(LastName);
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

        internal ContactList ValidateContactInformation()
        {
            var expectedFullName = FirstName + " " + LastName;

            var actualFullNameLocator = $".//tr[@class='contactTableBodyRow']//td[contains(text(),'{FirstName}')]";

            new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions.ElementIsVisible(By.XPath(actualFullNameLocator)));

            var actualFullName = GetDriver().FindElements(By.XPath(actualFullNameLocator)).First().Text;

            Assert.AreEqual(expectedFullName, actualFullName);

            return ContactListPage;
        }

    }
}

