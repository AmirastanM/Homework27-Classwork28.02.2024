using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_28_02_2024.Models
{
    internal class User
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        private string password;

    public User(string name, string surname, int age, string password)
        {
            Name = name;
            Surname = surname;
            Age = age;
            this.password = password;
        }

    public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        public string GetPassword()
        {
           return password;
        }

    }
}
