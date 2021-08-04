using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
   public class Program
    {
        public static void Main(String[] args)
        {
            int[] arrayInteger = { 200, 400, 100, 300, 500 };
            Generics<int> generic = new Generics<int>(arrayInteger);
            generic.PrintMaxValue();

            string[] arrayString = { "Cat", "Ball", "Bat", "Apple" };
            Generics<string> generics = new Generics<string>(arrayString);
            generics.PrintMaxValue();

            int[] arrayFloat = { 555, 450, 200, 600, 100 };
            Generics<int> genericss = new Generics<int>(arrayFloat);
            genericss.PrintMaxValue();
        }
    }
}
