using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            for (int number1 = 0; number1 < 11; number1++)
            {
                for (int number2 = 0; number2 < 11; number2++)
                {
                    result = number1 * number2;
                    Console.WriteLine(number1 + " * " + number2 + " = " + result);
                }

                Console.WriteLine("\n");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}

