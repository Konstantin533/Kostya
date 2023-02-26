using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Rectangle : Figure
    {
        public override string Name { get; set; } = "Прямоугольник";
        public int Height { get; set; } 
        public int Width { get; set; } 
        public override double Perimetr()
        {

            return 2 * (Height + Width);
        }

        public override double Square()
        {

            return Height * Width;
        }
    }
}
