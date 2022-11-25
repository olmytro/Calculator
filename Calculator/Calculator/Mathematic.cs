using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    static class Mathematic
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);
        }

        public static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);
        }

        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);
        }

        public static void Divide(int a, int b)
        {
            if (a == 0 | b == 0)
                Console.WriteLine("На ноль делить нельзя");
            else
            {
                int result = a / b;
                Console.WriteLine(a + " / " + b + " = " + result);
            }
        }
        
    }
}
