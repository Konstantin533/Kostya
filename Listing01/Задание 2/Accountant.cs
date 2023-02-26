using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing01
{
    public class Accountant : IWrite
    {
        public string Name { get; set; } = "Бухгалтер";
        public void JobTitle()
        {
            Console.WriteLine("Печатаю: ");
            for (int i = 0; i < Name.Length; i++)
            {

                Console.Write(Name[i]);
                Thread.Sleep(500);
            }
            Console.WriteLine();

        }
    }
}
