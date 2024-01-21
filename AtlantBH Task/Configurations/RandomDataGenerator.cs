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
            return faker.Person.DateOfBirth.ToString("yyyy-MM-dd");
        }

        public string GenerateEmail()
        {
            return faker.Person.Email;
        }

        public string GeneratePhone()
        {
            Random random = new Random();
            int min = (int)Math.Pow(10, 6);  
            int max = (int)Math.Pow(10, 9);  

            return random.Next(min, max).ToString();
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

