using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("write second numer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("write operation: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("This is the calculator");
            Mathematic math = new Mathematic(num1, num2, symbol);


            math.Back();

            /*
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            Console.Write("write first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("write second numer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("write operation: ");
            string symbol = Console.ReadLine();

            
            
            do
            {   
                Console.Write("write first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("write second numer: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the operator (+, -, *, /): ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                        //Console.WriteLine($"Your result: {num1} + {num2} =" + result);
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
                        if (num1 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                        }
                        else
                        Console.WriteLine($"Your result: {num1} / {num2} =" + result);
                        break;
                    default:
                        Console.WriteLine("invalid operation");
                        break;
                }
                Console.WriteLine("Continue?: Y or N:");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            */

            Console.ReadKey();
        }
       
    }
}
