using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{

    public class Generics<T> where T : IComparable
    {
        public T[] arrayNew;
        public Generics(T[] arrayOriginal)
        {
            this.arrayNew = arrayOriginal;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(T[] values)
        {
            var sorted_values = Sort(arrayNew);
            return sorted_values[^1];
        }
          
            public void PrintMaxValue()
            {
            var print = MaxValue(arrayNew);      
            Console.WriteLine("Maximum value is " + print);
        }
    }
}