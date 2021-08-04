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
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.number);
            return max;
        }
    }
}