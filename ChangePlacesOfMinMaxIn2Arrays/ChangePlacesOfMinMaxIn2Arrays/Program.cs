using System;

namespace ChangePlacesOfMinMaxIn2Arrays
{
    class Program
    {       
        /// <summary>
        /// Create new array by values
        /// </summary>
        /// <param name="arrayVallues">Array values</param>
        /// <returns>array</returns>
        static int[] CreateArray(params int[] arrayVallues)
        {
            int[] array = arrayVallues;
            return array;
        }

        /// <summary>
        /// Get min/max array values and return as array, where minMaxArrayValues[0] = min, minMaxArrayValues[1] = max
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>minMaxArrayValues</returns>
        static int[] GetMinMaxArrayValues(int[] array)
        {
            int[] sortedArray = new int[array.Length];
            Array.Copy(array, sortedArray, array.Length);
            Array.Sort(sortedArray);

            int minArrayValue = sortedArray[0];
            int maxArrayValue = sortedArray[^1];
            int[] minMaxArrayValues = new int[] { minArrayValue, maxArrayValue };

            return minMaxArrayValues;
        }

        /// <summary>
        /// Get array with changed min <-> max value places
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <returns>changedMinMaxArray</returns>
        static int[] GetChangedMinMaxArray(int[] array)
        {
            int[] changedMinMaxArray = new int[array.Length];
            Array.Copy(array, changedMinMaxArray, array.Length);

            int minArrayValue = GetMinMaxArrayValues(array)[0];
            int maxArrayValue = GetMinMaxArrayValues(array)[1];

            int minArrayValueIndex = Array.IndexOf(array, minArrayValue);
            int maxArrayValueIndex = Array.IndexOf(array, maxArrayValue);

            changedMinMaxArray[minArrayValueIndex] = maxArrayValue;
            changedMinMaxArray[maxArrayValueIndex] = minArrayValue;
      
            return changedMinMaxArray;
        }

        /// <summary>
        /// Display array info: initial array, min aaray value, max array value, changed array with replaced min <-> max values
        /// </summary>
        /// <param name="arrayNumber">Array number</param>
        /// <param name="array">Initial array</param>
        static void DisplayArrayInfo(int arrayNumber, int[] array)
        {
            int minArrayValue = GetMinMaxArrayValues(array)[0];
            int maxArrayValue = GetMinMaxArrayValues(array)[1];
            int[] changedMinMaxArray = GetChangedMinMaxArray(array);

            Console.WriteLine("Array #{0}: [{1}]", arrayNumber, String.Join(", ", array));
            Console.WriteLine("Minimal array #{0} value: {1}", arrayNumber, minArrayValue);
            Console.WriteLine("Maximal array #{0} value: {1}", arrayNumber, maxArrayValue);
            Console.WriteLine("Changed min <-> max places in array #{0}: [{1}]", arrayNumber, String.Join(", ", changedMinMaxArray));
        }

        static void Main(string[] args)
        {
            DisplayArrayInfo(1, CreateArray(10, 1, 5, -4, 6, 32, 8));
            DisplayArrayInfo(2, CreateArray(36, 258, -39, -40, -600));
        }
    }
}
