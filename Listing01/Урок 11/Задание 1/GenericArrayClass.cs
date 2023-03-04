using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class GenericArrayClass<T>
    {
        T [] array = new T[10] ;
        

        public void Add (params T [] parametrs)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length < parametrs.Length)
                {
                    throw new PasswordException("Ошибка, вы вышли за границы массива");
                }
                if(parametrs.Length < 10)
                {
                    throw new PasswordException("Ошибка, вы не заполнили массив полностью");
                }
                array[i] = parametrs[i];
                
               
                Console.Write(array[i] + " ");
               

            }
        }
        public void AddNum(T value)
        {
            var newArray = new T [array.Length+1] ;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
               
            }
            newArray[array.Length] = value;
            array = newArray;
            Console.WriteLine("Массив после добавления элемента: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]+" ");

            }
            Console.WriteLine();
        }
       

        public T  GetElement(int index) 
        {
            Console.WriteLine($"Вы выбрали элемент массива, он равен {array[index]}");
            return array[index];
        }



        
    }
}
