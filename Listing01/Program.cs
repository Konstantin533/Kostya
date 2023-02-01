using System;



namespace Listing01
{
    class Program
    {
        static void Main()
        {
            string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Очень приятно, " + name);
            Console.WriteLine("Знакомство состоялось!");
        }
    }
}
