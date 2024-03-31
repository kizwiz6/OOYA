using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYA
{
    public class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city = "N/A", string country = "N/A", string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }

        public string ViewProfile()
        {
            string bio = $"Name: {name},\n Age: {age},\n City: {city},\n Country: {country},\n Pronouns: {pronouns}";
            bio += ",\n Hobbies:\n";
            foreach (string hobby in hobbies)
            {
                bio += $"- {hobby}\n";
            }
            return bio;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
