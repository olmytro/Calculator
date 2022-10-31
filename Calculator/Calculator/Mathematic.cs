using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Mathematic
    {
        public int num1;
        public int num2;
        public string symbol;
        public int result;

        public Mathematic(int aNum1, int aNum2, string aSymbol)
        {
            num1 = aNum1;
            num2 = aNum2;
            symbol = aSymbol;
        }

        public void Back()
        {
            switch (symbol)
            {
                case "+":
                    Console.WriteLine("Summ:");
                    result = num1 + num2;
                    Console.WriteLine("the result is: " + num1 + " + " + num2 + " = " + result );
                    break;
                case "-":
                    Console.WriteLine("Subtract:");
                    result = num1 - num2;
                    Console.WriteLine("the result is: " + num1 + " - " + num2 + " = " + result);
                    break;
                case "*":
                    Console.WriteLine("Multiply:");
                    result = num1 * num2;
                    Console.WriteLine("the result is: " + num1 + " * " + num2 + " = " + result);
                    break;
                case "/":
                    Console.WriteLine("divide:");
                    result = num1 / num2;
                    Console.WriteLine("the result is: " + num1 + " / " + num2 + " = " + result);
                    break;
            }
        }
    }
}
