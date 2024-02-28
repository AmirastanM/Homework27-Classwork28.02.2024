
using ClassPractice_28_02_2024.Models;

User user = new User("Amirastan", "Mereyev", 33, "amirastan123");

Console.WriteLine($"{user.Name} - {user.Surname} - {user.Age}");


user.SetPassword("yenipassword123");


string password = user.GetPassword();

Console.WriteLine($"{password}");