using System;
namespace WorkWithArray
{
    internal class AdditionTable
    {
        public static void Main(string[] args)
        {
            int[] numbersArray = new Int32[9] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int numberOne = 0; numberOne < 9; numberOne++)
            {
                for (int numberTwo = 0; numberTwo < 9; numberTwo++)
                {
                    Console.WriteLine($"{numbersArray[numberOne]} + {numbersArray[numberTwo]} = {numbersArray[numberOne] + numbersArray[numberTwo]}");
                }
            }
        }
    }
}