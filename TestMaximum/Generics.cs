using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{

    public class Generics<T> where T : IComparable
    {
        public T[] number;
        public Generics(T[] number)
        {
            this.number = number;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(number);
            return sorted_values[^1];
        }
       
            public void PrintMaxValue()
        {
            var print = MaxValue(this.number);      
            Console.WriteLine("Maximum value is " + print);
        }
    }
}
