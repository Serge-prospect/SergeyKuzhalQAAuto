using System;

namespace ChangePlacesOfMinMaxIn2Arrays
{
    class Program
    {
        /// <summary>
        /// Create new array by params values 
        /// </summary>
        /// <param name="arrayVallues">New array values</param>
        /// <returns>array</returns>
        static int[] CreateArray(params int[] arrayVallues)
        {
            int[] array = arrayVallues;
            return array;
        }

        /// <summary>
        /// Get min array value
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>minArrayValue</returns>
        static int GetMinArrayValue(int[] array)
        {
            int minArrayValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                minArrayValue = minArrayValue <= array[index] ? minArrayValue : array[index];
            }
            return minArrayValue;
        }

        /// <summary>
        /// Get max array value
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>maxArrayValue</returns>
        static int GetMaxArrayValue(int[] array)
        {
            int maxArrayValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                maxArrayValue = maxArrayValue >= array[index] ? maxArrayValue : array[index];
            }
            return maxArrayValue;
        }

        /// <summary>
        /// Get changed array with replaced min <-> max values
        /// </summary>
        /// <param name="array">Initial array</param>
        /// <param name="minArrayValue">Minimal array value</param>
        /// <param name="maxArrayValue">Maximal array value</param>
        /// <returns>changedMinMaxArray</returns>
        static int[] GetChangedMinMaxArray(int[] array, int minArrayValue, int maxArrayValue)
        {
            int[] changedMinMaxArray = new int[array.Length];            
            for (int index = 0; index < array.Length; index++)
            {
                //Change min to max
                if (array[index] == minArrayValue)
                {
                    changedMinMaxArray[index] = maxArrayValue;
                }
                //Change max to min
                else if (array[index] == maxArrayValue)
                {
                    changedMinMaxArray[index] = minArrayValue;
                }
                else
                {
                    changedMinMaxArray[index] = array[index];
                }
            }            
            return changedMinMaxArray;
        }

        /// <summary>
        /// Display array info: initial array, min aaray value, max array value, changed array with replaced min <-> max values 
        /// </summary>
        /// <param name="arrayNumber">Array number</param>
        /// <param name="array">Initial array</param>
        /// <param name="minArrayValue">Minimal array value</param>
        /// <param name="maxArrayValue">Maximal array value</param>
        /// <param name="changedMinMaxArray">Changed array with replaced min <-> max values</param>
        static void DisplayArrayInfo(int arrayNumber, int[] array, int minArrayValue, int maxArrayValue, int[] changedMinMaxArray)
        {
            Console.WriteLine("Array #{0}: [{1}]", arrayNumber, String.Join(", ", array));
            Console.WriteLine("Minimal array #{0} value: {1}", arrayNumber, minArrayValue);
            Console.WriteLine("Maximal array #{0} value: {1}", arrayNumber, maxArrayValue);
            Console.WriteLine("Changed min <-> max places in array #{0}: [{1}]", arrayNumber, String.Join(", ", changedMinMaxArray));
        }
        static void Main(string[] args)
        {
            int[] array1 = CreateArray(10, 1, 5, -4, 6, 32, 8);
            int[] array2 = CreateArray(36, 258, -39, -40, -600);

            int minArray1Value = GetMinArrayValue(array1);
            int minArray2Value = GetMinArrayValue(array2);

            int maxArray1Value = GetMaxArrayValue(array1);
            int maxArray2Value = GetMaxArrayValue(array2);

            int[] changedMinMaxArray1 = GetChangedMinMaxArray(array1, minArray1Value, maxArray1Value);
            int[] changedMinMaxArray2 = GetChangedMinMaxArray(array2, minArray2Value, maxArray2Value);

            DisplayArrayInfo(1, array1, minArray1Value, maxArray1Value, changedMinMaxArray1);
            DisplayArrayInfo(2, array2, minArray2Value, maxArray2Value, changedMinMaxArray2);
        }
    }
}
