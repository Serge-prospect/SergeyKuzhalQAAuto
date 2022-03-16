using System;

namespace Array10toSquaredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            for (int index = 0; index < Array.Length; index++)
            {
                Array[index] = (int)Math.Pow(index, 2);
            }
            Console.WriteLine("Squared index array: [{0}]", string.Join(", ", Array));
        }
    }
}
