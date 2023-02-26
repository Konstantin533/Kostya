using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing01
{
    public class Rectangle : Circle
    {
        public override string Name { get; set; } = "Прямоугольник";
        public virtual double Perimetr(int height, int weight)
        {

            return 2 * (height + weight);
        }

        public virtual double Square(int height, int weight)
        {

            return height*weight;
        }
    }
}
