using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AtlantBH_Task.Configurations
{
    public class Config
    {
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("contactFirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("addContactButtonText")]
        public string AddContactButtonText { get; set; }

        public static Config Load()
        {
            string json = File.ReadAllText("Configurations/Config.json");
            return JsonConvert.DeserializeObject<Config>(json);
        }

    }
}

