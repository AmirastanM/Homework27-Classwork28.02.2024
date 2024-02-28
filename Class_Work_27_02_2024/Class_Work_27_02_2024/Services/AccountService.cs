using Class_Work_MethodPractice_27_02_2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_MethodPractice_27_02_2024.Services
{
    internal class AccountService 
    {
        private readonly UserService _userService;
        public AccountService()
        {
            _userService = new UserService();
        }

        public bool Login(string email, string password)
        {
            var users = _userService.GetAll();
            return users.Any(m => m.email == email && m.password == password);
            


        }


        
        

    }
}
