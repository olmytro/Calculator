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

                Console.Write("write second numer: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /): ");
                string symbol = Console.ReadLine();

                Mathematic math = new Mathematic(num1, num2, symbol);

                math.Back();

                Console.WriteLine("Continue?: Y or N:");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            Console.ReadKey();
        }
       
    }
}
