using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing01
{
    public class Weak
    {
        public delegate void WeakWether(string message);
        
        public event WeakWether Notify;
        public static int Num { get; set; } = -1;


        public static void Sum()
        {
            Num++;
        }
        public void Weather()
        {
            string[] weak = new string[] { "Дождь", "Пасмурно", "Солнечно", "Сильный ветер", "Снег" };

            Random n = new Random();
            int i = n.Next(0, 4);
            Thread.Sleep(20);

            Notify.Invoke($" {weak[i]} ");
        }
        
    }
}
