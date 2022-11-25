using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("write first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /): ");
                string symbol = Console.ReadLine();

                Console.Write("write second numer: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (symbol)
                {
                    case "+":
                        Mathematic.Add(num1, num2);
                        break;
                    case "-":
                        Mathematic.Subtract(num1, num2);
                        break;
                    case "*":
                        Mathematic.Multiply(num1, num2);
                        break;
                    case "/":
                        Mathematic.Divide(num1, num2);
                        break;
                }

                Console.WriteLine("Continue?: Y or N:");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            Console.ReadKey();
        }
       
    }
}
