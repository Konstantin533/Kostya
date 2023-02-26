using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Circle:Figure
    {
        private double P { get; set; } = 3.14;
        public override string Name { get; set; } = "Круг";
        public double Perimetr(int radius)
        {
            
            return 2 * P * radius;
        }

        public  double Square(int radius)
        {
            
            return P * radius * 2;
        }
    }
}
