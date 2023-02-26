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
    public class  Triangle : Figure
    {
        public override string Name { get; set; } = "Треугольник";
        public int Side { get; set; } 
        public int SideOne { get; set; } 
        public int SideTwo { get; set; } 
        public int Height { get; set; }
        public int Basis { get; set; }

        public override  double Perimetr()
        {
            return Side + SideOne + SideTwo;
        }

        public override double Square()
        {
            return (Height * Basis) /2;
        }










    }
}
