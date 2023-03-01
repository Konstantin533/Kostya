using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Listing01
{
    public class Account
    {


        public static void PasswordChecked (string login, string password, string confirmPassword)
        {
            Regex regex = new Regex(@"[0-9]");
            MatchCollection matches = regex.Matches(password);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    
                }
            }
            else
            {
                throw new PasswordException("Поле не содержит число");
            }


            for (int j = 0; j < login.Length; j++)
            {
                if (Char.IsWhiteSpace(login[j]))
                    throw new PasswordException("Введен пробел ошибка");

                if (login.Length > 20)
                    throw new PasswordException("Превышает количество символов");
                
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsWhiteSpace(password[i]))
                    throw new PasswordException("Введен пробел ошибка");

                if (password.Length > 20)
                    throw new PasswordException("Превышает количество символов");

                if (!password.Equals(confirmPassword))
                {
                    throw new PasswordException("Неверный пароль!");
                }
               

            }
        }
    }
}