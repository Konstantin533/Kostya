using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public  class Figure
    {
        public virtual string Name { get; set; } = "Фигура";
        public double result;
        public virtual void ShowName()
        {
            Console.WriteLine($"Я {Name}");
        }
       
        public double SumPer(params double[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                
                result = result + param[i];
                
            }
            return result;
        }
    }
}
