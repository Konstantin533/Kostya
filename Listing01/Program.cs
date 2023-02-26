﻿using System;

namespace Listing01
{
    class Program
    {
        static void Main()
        {
           //Задание 1.

            var figure = new Figure();

            figure.ShowName();

            var triangle = new Triangle() { Height = 10, Basis = 5, Side = 12,SideOne = 5, SideTwo = 20};

            triangle.ShowName();
            Console.WriteLine("Периметр: " + triangle.Perimetr());
            Console.WriteLine("Площадь: " + triangle.Square());
            var circle = new Circle() { R = 12};
            circle.ShowName();
            Console.WriteLine("Периметр: " + circle.Perimetr());
            Console.WriteLine("Площадь: " + circle.Square());
            var rectangle = new Rectangle() { Height= 10, Width = 5};
            rectangle.ShowName();
            Console.WriteLine("Периметр: " + rectangle.Perimetr());
            Console.WriteLine("Площадь: " + rectangle.Square());

           double result = figure.SumPer(triangle.Perimetr(), circle.Perimetr(), rectangle.Perimetr());

            Console.WriteLine("Сумма периметров всех фигур: " + result);


            // Задание 2.

            var worker = new Worker();
            worker.JobTitle();
            var accountant = new Accountant();
            accountant.JobTitle();
            var director = new Director();
            director.JobTitle();

            //Задание enum

            int dayweaks = int.Parse(Console.ReadLine());
            switch (dayweaks)
            {
                case (int) DayWeaks.Monday:
                    {
            Console.WriteLine("Понедельник");
            break;
        }
                case (int) DayWeaks.Tuesday:
                    {
            Console.WriteLine("Вторник");
            break;
        }
                case (int) DayWeaks.Wednesday:
                    {
            Console.WriteLine("Среда");
            break;
        }
                case (int) DayWeaks.Thursday:
                    {
            Console.WriteLine("Четверг");
            break;
        }
                case (int) DayWeaks.Friday:
                    {
            Console.WriteLine("Пятница");
            break;
        }
                case (int) DayWeaks.Saturday:
                    {
            Console.WriteLine("Суббота");
            break;
        }
                case (int) DayWeaks.Sunday:
                    {
            Console.WriteLine("Воскресенье");
            break;
        }
    }

    //Задание Структуры 

            var person = new UserInfo(0);
            person.Name = "Игорь";
            person.Print();

            
        }
    }
}
