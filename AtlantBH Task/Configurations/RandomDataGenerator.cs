using System;
using Bogus;

namespace AtlantBH_Task.Configurations
{
    public class RandomDataGenerator
    {
        private readonly Faker faker;

        public RandomDataGenerator()
        {
            faker = new Faker();
        }

        public string GenerateFirstName()
        {
            return faker.Person.FirstName;
        }

        public string GenerateLastName()
        {
            return faker.Person.LastName;
        }

        public string GenerateDateOfBirth()
        {
            string dateOfBirth = faker.Person.DateOfBirth.ToString("yyyy-MM-dd");

            /*string dateOfBirth = faker.Person.DateOfBirth.Year.ToString()
                + "-" + faker.Person.DateOfBirth.Month.ToString()
                + "-" + faker.Person.DateOfBirth.Day.ToString();*/
            return dateOfBirth;
        }

        public string GenerateEmail()
        {
            return faker.Person.Email;
        }

        public string GeneratePhone()
        {
            return faker.Person.Phone;
        }

        public string GenerateStreetAddress1()
        {
            return faker.Address.StreetAddress();
        }

        public string GenerateStreetAddress2()
        {
            return faker.Address.SecondaryAddress();
        }

        public string GenerateCity()
        {
            return faker.Address.City();
        }

        public string GenerateStateOrProvince()
        {
            return faker.Address.State();
        }

        public string GeneratePostalCode()
        {
            return faker.Address.ZipCode();
        }

        public string GenerateCountry()
        {
            return faker.Address.Country();
        }

        public string GeneratePassword()
        {
            return faker.Internet.Password();
        }

    }
}

