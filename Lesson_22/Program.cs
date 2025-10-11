using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lesson_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address
            {
                City = "Kazan",
                Street = "Street1"
            };

            var user = new User()
            {
                Id = 1,
                Name = "Test",
                Password = "password",
                Address = address
            };
            Console.WriteLine("Ваше имя: \"\"");

            string json = JsonConvert.SerializeObject(user, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("users.json"))
            {
                sw.WriteLine(json);
            }

            var userNew = JsonConvert.DeserializeObject<User>(json);

          
        }
    }

    public class User
    {
        [JsonProperty("user_id")]
        public int Id { get; set; }

        [JsonProperty("user_name")]
        public string Name { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}
