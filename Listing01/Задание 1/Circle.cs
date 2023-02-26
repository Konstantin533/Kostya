using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Circle : Figure
    {
        private double P { get; set; } = 3.14;
        public int R { get; set; }  
        public override string Name { get; set; } = "Круг";
        public override double Perimetr()
        {
            
            return 2 * P * R;
        }

        public override  double Square()
        {
            
            return P * R * 2;
        }
    }
}
