using Class_Work_MethodPractice_27_02_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_MethodPractice_27_02_2024.Services
{
    internal class UserService 
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                id = 1,
                fullName = "Ali Mammadov",
                age = 24,
                email = "alimammadov@gmail.com",
                password = "ali12345",
            };

            User user2 = new()
            {
                id = 2,
                fullName = "Mamed Abbasov",
                age = 26,
                email = "mamedabbasov@gmail.com",
                password = "mamed12345",
            };

            User user3 = new()
            {
                id = 3,
                fullName = "Iskender Mamedov",
                age = 28,
                email = "iskendermammadov@gmail.com",
                password = "iskender12345",
            };

            User user4 = new()
            {
                id = 4,
                fullName = "Kamran Aliyev",
                age = 30,
                email = "kamranaliyev@gmail.com",
                password = "kamran12345",
            };

            User user5 = new()
            {
                id = 5,
                fullName = "Shakir Abdullayev",
                age = 32,
                email = "shakirabdullayev@gmail.com",
                password = "shakir12345",
            };

            User[] users = { user1, user2, user3, user4, user5 };

            return users;

        }

        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }
    }
}
