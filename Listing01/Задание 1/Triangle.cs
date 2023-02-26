using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Listing01
{
    public class  Triangle : Rectangle
    {
        public override string Name { get; set; } = "Треугольник";


        public  double Perimetr(int side, int sideOne, int sideTwo)
        {
            return side + sideOne + sideTwo;
        }

        public override double Square(int height, int basis)
        {
            return (height*basis)/2;
        }










    }
}
