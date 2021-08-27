using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            // first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Task 2 - Division
            result = firstNumber - secondNumber;
            Console.WriteLine("The answer is: " + result);

        }
    }
}
