using System;

namespace ChangePlacesOfMinMaxIn2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 54, 320, 690, 10, 12, 0, 99, 30, 9, 3 };
            int[] array2 = { 6, 20, 40, -4, 99, 54, 66, 8 };
            int minArray1Value = array1[array1.Length - 1];
            int minArray2Value = array2[array2.Length - 1];
            int maxArray1Value = array1[array1.Length - 1];
            int maxArray2Value = array2[array2.Length - 1];

            //Array #1 min/max values
            for (int index = 0; index < array1.Length; index++)
            {                
                minArray1Value = minArray1Value <= array1[index] ? minArray1Value : array1[index];
                maxArray1Value = maxArray1Value >= array1[index] ? maxArray1Value : array1[index];
            }
            Console.WriteLine("Array #{0}: [{1}]", 1, String.Join(", ", array1));
            Console.WriteLine("Minimal array #{0} value: {1}\nMaximal array #{0} value: {2}", 1, minArray1Value, maxArray1Value);
            
            //Array #2 min/max values
            for (int index = 0; index < array2.Length; index++)
            {
                minArray2Value = minArray2Value <= array2[index] ? minArray2Value : array2[index];
                maxArray2Value = maxArray2Value >= array2[index] ? maxArray2Value : array2[index];
            }
            Console.WriteLine("Array #{0}: [{1}]", 2, String.Join(", ", array2));
            Console.WriteLine("Minimal array #{0} value: {1}\nMaximal array #{0} value: {2}", 2, minArray2Value, maxArray2Value);

            //Array #1 - change min/max places
            for (int index = 0; index < array1.Length; index++)
            {
                //Change min to max
                if (array1[index] == minArray1Value)
                {
                    array1[index] = maxArray1Value;
                }
                //Change max to min
                else if (array1[index] == maxArray1Value)
                {
                    array1[index] = minArray1Value;
                }
            }
            Console.WriteLine("Changed min/max places in array #{0}: [{1}]:", 1, String.Join(", ", array1));

            //Array #2 - change min/max places
            for (int index = 0; index < array2.Length; index++)
            {
                //Change min to max
                if (array2[index] == minArray2Value)
                {
                    array2[index] = maxArray2Value;
                }
                //Change max to min
                else if (array2[index] == maxArray2Value)
                {
                    array2[index] = minArray2Value;
                }
            }
            Console.WriteLine("Changed min/max places in array #{0}: [{1}]:", 2, String.Join(", ", array2));
        }
    }
}
