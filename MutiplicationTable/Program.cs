using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int result;

            for (int i = 0; i < 11; i++)
            {

                for (int j = 0; j < 11; j++)
                {

                    result = i * j;
                    Console.WriteLine(i + " * " + j + " = " + result);

                }

                Console.WriteLine("\n");
                Console.ReadKey();

            }

            Console.ReadKey();
        }
    }
}

