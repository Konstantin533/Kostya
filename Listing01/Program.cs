using System;
using System.Text;
using System.Text.RegularExpressions;


namespace Listing01
{
    class Program
    {
        static void Main()
        {
            //Задание 1.

            int numOne = 0, numTwo = 1, mySize = 11;



            Console.WriteLine("Диапозон Фибоначчи: ");


            Console.Write(numOne + " ");

            while (mySize - 1 > 0)
            {

                numOne = numTwo + numOne;

                numTwo = numOne - numTwo;


                Console.Write(numOne + " ");

                mySize--;
            }

            Console.WriteLine();

            // Задание 2.
            Console.Write("Введите сумму вклада: ");
            float sum = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введиет срок вклада в месяцах: ");
            int period = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < period; i++)
            {
                sum = sum + sum * 0.07f;
            }
            Console.WriteLine($"За {period} месяцев сумма вклада будет составлять {sum}");



            //Задание 4.

            bool Here = true;
            while (Here)
            {
                Random rnd = new Random();
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] newArray = new int[size];
                int FutureArrayLength = 0;
                if (size > 5 & size <= 10)
                {

                    Here = false;
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = rnd.Next(1, 20);
                        Console.WriteLine(newArray[i]);
                        if (newArray[i] % 2 == 1)
                        {
                            FutureArrayLength++;
                        }

                    }
                    Console.WriteLine("Массив с нечетными числами");
                    int[] starArray = new int[FutureArrayLength];
                    int iterationForAppend = 0;
                    for (int i = 0; i < newArray.Length; i++)
                    {

                        if (newArray[i] % 2 == 1)
                        {

                            if (iterationForAppend != starArray.Length)
                            {
                                starArray[iterationForAppend] = newArray[i];

                                iterationForAppend++;


                            }

                        }

                    }
                    for (int i = 0; i < starArray.Length; i++)
                    {
                        Console.WriteLine(starArray[i]);
                    }



                }
                else
                {
                    Console.WriteLine("Вы ввели неверны данные! Попробуйте снова!");
                }


            }



            //Задание 5.

            int[] myArr = new int[5];
            Random rand = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rand.Next(1, 20);
                Console.Write(myArr[i] + "\t");


            }
            Console.WriteLine();

            for (int i = 0; i < myArr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    myArr[i] = 0;

                }

                Console.Write(myArr[i] + "\t");
            }
            Console.WriteLine();
            //Задание 6.
            string[] names = new string[7] { "Сергей", "Александр", "Константин", "Артём", "Генадий", "Игорь", "Олег" };
            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}/ ");
            }
            Console.WriteLine("\nМассив после сортировки");

            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]}/ ");
            }
            Console.WriteLine();

            //Задание 7. Метод пузырька.

            char s;
            char[] symbs = { 'Q', 'f', 't', 'w', 'A', 'ы', 'а', 'r', 'q', 'b', 'A' };
            Console.WriteLine("Массив до сортировки: ");
            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write(symbs[i] + " ");
            }
            Console.WriteLine();
            for (int k = 1; k < symbs.Length; k++)
            {
                for (int j = 0; j < symbs.Length - k; j++)
                {
                    if (symbs[j] > symbs[j + 1])
                    {
                        s = symbs[j + 1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }
            }
            Console.WriteLine("Массив после сортировки: ");
            for (int i = 0; i < symbs.Length; i++)
            {
                Console.Write(symbs[i] + " ");
            }
            Console.WriteLine();

            //Задание 5. String
            Console.Write("Введите текст: ");
            string myText = Console.ReadLine();

            string duplicatText;

            for (int i = 0; i < myText.Length; i++)
            {

                duplicatText = string.Concat(myText[i], myText[i]);
                Console.Write(duplicatText);

            }
            Console.WriteLine();

           
        }
    }
    
}
