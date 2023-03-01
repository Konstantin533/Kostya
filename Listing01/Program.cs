using System;

namespace Listing01
{
    class Program
    {
        static void Main()
        {
            //Задание 1.

            //        var figure = new Figure();

            //        figure.ShowName();

            //        var triangle = new Triangle() { Height = 10, Basis = 5, Side = 12,SideOne = 5, SideTwo = 20};

            //        triangle.ShowName();
            //        Console.WriteLine("Периметр: " + triangle.Perimetr());
            //        Console.WriteLine("Площадь: " + triangle.Square());
            //        var circle = new Circle() { R = 12};
            //        circle.ShowName();
            //        Console.WriteLine("Периметр: " + circle.Perimetr());
            //        Console.WriteLine("Площадь: " + circle.Square());
            //        var rectangle = new Rectangle() { Height= 10, Width = 5};
            //        rectangle.ShowName();
            //        Console.WriteLine("Периметр: " + rectangle.Perimetr());
            //        Console.WriteLine("Площадь: " + rectangle.Square());

            //       double result = figure.SumPer(triangle.Perimetr(), circle.Perimetr(), rectangle.Perimetr());

            //        Console.WriteLine("Сумма периметров всех фигур: " + result);


            //        // Задание 2.

            //        var worker = new Worker();
            //        worker.JobTitle();
            //        var accountant = new Accountant();
            //        accountant.JobTitle();
            //        var director = new Director();
            //        director.JobTitle();

            //        //Задание enum

            //        int dayweaks = int.Parse(Console.ReadLine());
            //        switch (dayweaks)
            //        {
            //            case (int) DayWeaks.Monday:
            //                {
            //        Console.WriteLine("Понедельник");
            //        break;
            //    }
            //            case (int) DayWeaks.Tuesday:
            //                {
            //        Console.WriteLine("Вторник");
            //        break;
            //    }
            //            case (int) DayWeaks.Wednesday:
            //                {
            //        Console.WriteLine("Среда");
            //        break;
            //    }
            //            case (int) DayWeaks.Thursday:
            //                {
            //        Console.WriteLine("Четверг");
            //        break;
            //    }
            //            case (int) DayWeaks.Friday:
            //                {
            //        Console.WriteLine("Пятница");
            //        break;
            //    }
            //            case (int) DayWeaks.Saturday:
            //                {
            //        Console.WriteLine("Суббота");
            //        break;
            //    }
            //            case (int) DayWeaks.Sunday:
            //                {
            //        Console.WriteLine("Воскресенье");
            //        break;
            //    }
            //}

            ////Задание Структуры 

            //        var person = new UserInfo(0);
            //        person.Name = "Игорь";
            //        person.Print();


            //var register = new Register();
            //int otp;
            //Console.WriteLine("Добро пожаловать в регистр!");


            //do
            //{

            //    Console.WriteLine("1.Контракт с сотрудником");
            //    Console.WriteLine("2.Контракт на поставку товаров");
            //    Console.WriteLine("3.Финансовая накладная");
            //    Console.WriteLine("4.Показать информацию о документе");
            //    Console.Write("Введите номер операции для создания нужного документа: ");
            //    otp =int.Parse(Console.ReadLine());
            //    switch (otp)
            //    {
            //        case (int)NumberOperation.Employee:
            //            Console.Clear();
            //            register.CreateContractEmployee();
            //            break;

            //        case (int)NumberOperation.Supply:
            //            Console.Clear();
            //            register.CreateSupplyContract(); 
            //            break;

            //        case (int)NumberOperation.Finance:
            //            Console.Clear();
            //            register.CreateFinance();
            //            break;
            //        case (int)NumberOperation.Show:
            //            Console.Clear();
            //            register.InfoDocument();
            //            break;


            //    }

            //} while (otp != (int)NumberOperation.Exit);




            try
            {
                Account.PasswordChecked("Admin", "qwe1rt", "qwe1rt");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
