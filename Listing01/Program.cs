using System;



namespace Listing01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\t\t\t\tЗадание 1.");
            Console.WriteLine();
            int num;
            Console.Write("Введите номер месяца, для определения поры года: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует!В году 12 месяцев");

                    break;

            }

            Console.WriteLine("\t\t\t\t\tЗадание 2.");
            Console.WriteLine();

            int num1;
            Console.Write("Введите номер месяца, для определения поры года: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 1 || num1 == 12 || num1 == 2)
            {
                Console.WriteLine("Зима");
            }
            else if (num1 == 3 || num1 == 4 || num1 == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (num1 == 6 || num1 == 7 || num1 == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (num1 == 9 || num1 == 10 || num1 == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("Такого месяца не существует!В году 12 месяцев");
            }

            Console.WriteLine("\t\t\t\t\tЗадание 3.");
            Console.WriteLine();
            int num2;

            Console.Write("Введите число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 % 2 == 0 ? "Число чётное" : "Число нечётное");



            Console.WriteLine("\t\t\t\t\tЗадание 4.");
            Console.WriteLine();
            int t;
            Console.Write("Введите температуру на улице: ");
            t = Convert.ToInt32(Console.ReadLine());
            if (t > -5) Console.WriteLine("Тепло");
            else if (-5 >= t && t > -20) Console.WriteLine("Нормально");
            else if (-20 >= t) Console.WriteLine("Холодно");


            Console.WriteLine("\t\t\t\t\tЗадание 5.");
            Console.WriteLine();
            int num3;
            Console.Write("Введите номер, для определения цвета радуги: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            switch (num3)
            {

                case 1:
                    Console.WriteLine("Красный");
                    break;
                case 2:
                    Console.WriteLine("Оранжевый");
                    break;
                case 3:
                    Console.WriteLine("Жёлтый");
                    break;
                case 4:
                    Console.WriteLine("Зеленый");
                    break;
                case 5:
                    Console.WriteLine("Голубой");
                    break;
                case 6:
                    Console.WriteLine("Синий");
                    break;
                case 7:
                    Console.WriteLine("Фиолетовый");
                    break;
                default:
                    Console.WriteLine("Введены неверные данные!");
                    break;

            }

        }
    }
}
