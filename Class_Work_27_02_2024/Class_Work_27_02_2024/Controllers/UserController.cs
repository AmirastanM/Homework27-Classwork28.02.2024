using Class_Work_MethodPractice_27_02_2024.Helpers;
using Class_Work_MethodPractice_27_02_2024.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_MethodPractice_27_02_2024.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        public void GetAll()
        {
            var users= _userService.GetAll();
            foreach (var user in users)
            {
                string result = $"{user.fullName} {user.email} {user.age}";
                Console.WriteLine(result);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter user id");
            string strId = Console.ReadLine();

            int id;

            bool isCorrectId = int.TryParse(strId, out id);

        
            var user = _userService.GetById(_userService.GetAll(), 3);

            if (user == null)
            {
                Console.WriteLine(ResponseMessages.Notfound);
                return;
            }
            var result = $"{user.fullName} {user.email} {user.age}";
            Console.WriteLine(result);
        }

    }
}
