using System;

namespace _3ArraysIndexIndex2Index3Average
{
    class Program
    {
        /// <summary>
        /// Create array with set array length and degree for array index
        /// </summary>
        /// <param name="arrayLength">length of new array</param>
        /// <param name="degree">degree for the array index</param>
        /// <returns>array</returns>
        static int[] CreateArray(int arrayLength, int degree)
        {
            int[] array = new int[arrayLength];
            for (int index = 0; index < arrayLength; index++)
            {
                array[index] = (int)Math.Pow(index, degree);
            }
            return array;
        }

        /// <summary>
        /// Get average value of the array
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>arrayAverage</returns>
        static float GetArrayAverage(int[] array)
        {
            float sumArray = 0f;
            for (int index = 0; index < array.Length; index++)
            {
                sumArray += array[index];
            }
            float arrayAverage = sumArray / array.Length;
            return arrayAverage;
        }

        /// <summary>
        /// Display array info: array, average array value
        /// </summary>
        /// <param name="array">array</param>
        /// <param name="degree">degree for the array index</param>
        /// <param name="arrayAverage">Average value of the array</param>
        static void DisplayArrayInfo(int[] array, int degree, float arrayAverage)
        {
            Console.WriteLine("Array fulfilled by indexes in {0} degree: [{1}]", degree, String.Join(", ", array));
            Console.WriteLine("Average array index value: {0}", arrayAverage);
        }

        static void Main(string[] args)
        {
            int degree1 = 1;
            int degree2 = 2;
            int degree3 = 3;
            int[] array1 = CreateArray(10, degree1);
            int[] array2 = CreateArray(5, degree2);
            int[] array3 = CreateArray(7, degree3);
            float array1Average = GetArrayAverage(array1);
            float array2Average = GetArrayAverage(array2);
            float array3Average = GetArrayAverage(array3);
            DisplayArrayInfo(array1, degree1, array1Average);
            DisplayArrayInfo(array2, degree2, array2Average);
            DisplayArrayInfo(array3, degree3, array3Average);
        }
    }
}
