﻿namespace GroupCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
      
        public static int Subtraction(int a, int b)
        {
            int sum = a - b;
            return sum;
        }

        static int Multiplicate(int firstNum, int secondNum)
        {
            int product = firstNum * secondNum;
            return product;
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
