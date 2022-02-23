using System;

namespace Array10toSquaredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[10];
            for (int index = 0; index < initialArray.Length; index++)
            {
                initialArray[index] = index;
            }
            Console.WriteLine("Initial array indexes: [{0}]", string.Join(", ", initialArray));

            int[] squaredArray = initialArray;
            for (int index = 0; index < squaredArray.Length; index++)
            {
                squaredArray[index] = (int)Math.Pow(initialArray[index], 2);
            }
            Console.WriteLine("Squared array indexes: [{0}]", string.Join(", ", squaredArray));
        }
    }
}
