using Class_Work_MethodPractice_27_02_2024.Helpers;
using Class_Work_MethodPractice_27_02_2024.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_MethodPractice_27_02_2024.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Add your email:");
            Email: string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
                goto Email;
            }

            Console.WriteLine("Add your password:");
            string password = Console.ReadLine();

            var response = _accountService.Login(email, password);

            if (response)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
