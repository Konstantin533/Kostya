using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public struct  UserInfo
    {
        public  string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public UserInfo(int x)//пришлось передаь значение , иначе пишет ошибку про версии С#
        {
            Name = "Сергей";
            Surname = "Сидоров";
            Age = 20;
            Adress = "Минск";
            Login = "Admin";
            Password = 1234;
        }

        

        
        public void Print()
        {
            Console.WriteLine($"Меня зовут {Name}, фамилия {Surname}. Мне {Age} . Адрес: {Adress}. Мой логин {Login}, мой пароль: {Password}");
        }

    }
}
