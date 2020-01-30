/*n – number of lines for the pattern, integer (int)
 * summary   : This method prints number pattern of integers using recursion
 * For example n = 5 will display the output as: 
 * 54321
 * 4321
 * 321
 * 21
 * 1
 * returns      : N/A
 * return type  : void
 */







using System;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 5;

            PrintPattern(n);

        }

        private static void PrintPattern(int n)
        {

            int length = n;
            if (length != 0)
            {
                for (int i = length; i > 0; i--)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
                n--;
                PrintPattern(n);
            }
        }


    }
}
