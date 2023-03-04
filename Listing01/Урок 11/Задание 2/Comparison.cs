using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;


namespace Listing01
{
    public class Comparison<T> where T : IComparable<T>
    {
        public  T Max;
        public T Value { get; set; } 
        public T ValueOne { get; set; }
        public T ValueTwo { get; set; }



        public Comparison(T value, T valueOne, T valueTwo)
        {
            
            Value = value;
            ValueOne = valueOne;
            ValueTwo = valueTwo;
        }

        public T GreateThen()
        {
            if (Value.CompareTo(ValueOne) >= 0 & Value.CompareTo(ValueTwo) >= 0)
                return Value;

            if (ValueOne.CompareTo(Value) >= 0 & ValueOne.CompareTo(ValueTwo) >= 0)
                return ValueOne;

            if (ValueTwo.CompareTo(Value) >= 0 & ValueTwo.CompareTo(ValueOne) >= 0)
                return ValueTwo;


            return Value;
        }
    }
}
