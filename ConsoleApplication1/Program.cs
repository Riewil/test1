using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] massiv = new Int32[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int numberOne = 0; numberOne < 9; numberOne++)
            {
                for (int numberTwo = 0; numberTwo < 9; numberTwo++)
                {
                    Console.WriteLine($"{massiv[numberOne]} + {massiv[numberTwo]} = {massiv[numberOne] + massiv[numberTwo]}");
                }
            }
        }
    }
}