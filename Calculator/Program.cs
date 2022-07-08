using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which Operation? Choose: +, -, * or /");
            string operation = Console.ReadLine();
            Console.WriteLine("What is value of A?");
            int paramA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is value of B?");
            int paramB = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine(Addition(paramA, paramB));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(Subtraction(paramA, paramB));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(Multiplication(paramA, paramB));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(Division(paramA, paramB));
                        break;
                    }
                default:
                    Console.WriteLine("Wrong Operand");
                    break;
            }
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
