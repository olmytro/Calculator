using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do{
                int num1 = 0;
                int num2 = 0;
                int result = 0;

                Console.WriteLine("This is the calculator");

                Console.WriteLine("write number 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("write number 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("Add");
                Console.WriteLine("Subtract");
                Console.WriteLine("Multiply");
                Console.WriteLine("Divide");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} =" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} =" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} =" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} =" + result);
                        break;
                    default:
                        Console.WriteLine("valid");
                        break;
                }
                Console.WriteLine("Continue? Y or n:");
            }while (Console.ReadLine().ToUpper() == "Y");

            Console.ReadKey();

        }
    }
}
