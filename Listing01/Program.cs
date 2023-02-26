using System;

namespace Listing01
{
    class Program
    {
        static void Main()
        {
           //Задание 1.

            var figure = new Figure();

            figure.ShowName();

            var triangle = new Triangle();

            triangle.ShowName();
            Console.WriteLine("Периметр: " + triangle.Perimetr(11,10));
            Console.WriteLine("Площадь: " + triangle.Square(5,7));
            var circle = new Circle();
            circle.ShowName();
            Console.WriteLine("Периметр: " + circle.Perimetr(5));
            Console.WriteLine("Площадь: " + circle.Square(7));
            var rectangle = new Rectangle();
            rectangle.ShowName();
            Console.WriteLine("Периметр: " + rectangle.Perimetr(5, 10));
            Console.WriteLine("Площадь: " + rectangle.Square(6, 10));

           double result = figure.SumPer(triangle.Perimetr(11, 10), circle.Perimetr(5), rectangle.Perimetr(5, 10));

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
