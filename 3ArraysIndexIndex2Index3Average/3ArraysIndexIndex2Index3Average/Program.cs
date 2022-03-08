using System;

namespace _3ArraysIndexIndex2Index3Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array fulfilled by indexes
            int[] array1Degree = new int[10];
            float sumArray1Degree = 0f;            
            for (int index = 0; index < array1Degree.Length; index++)
            {
                array1Degree[index] = (int)Math.Pow(index, 1);
                sumArray1Degree += array1Degree[index];
            }
            float averageArray1Degree = sumArray1Degree / array1Degree.Length;
            Console.WriteLine("Array fulfilled by indexes: [{0}]", String.Join(", ", array1Degree));
            Console.WriteLine("Average array index value: {0}",averageArray1Degree);

            //Array fulfilled by indexes in 2 degree
            int[] array2Degree = new int[10];
            float sumArray2Degree = 0f;
            for (int index = 0; index < array2Degree.Length; index++)
            {
                array2Degree[index] = (int)Math.Pow(index, 2);
                sumArray2Degree += array2Degree[index];
            }
            float averageArray2Degree = sumArray2Degree / array2Degree.Length;
            Console.WriteLine("Array fulfilled by indexes in 2 degree: [{0}]", String.Join(", ", array2Degree));
            Console.WriteLine("Average array index value: {0}", averageArray2Degree);

            //Array fulfilled by indexes in 3 degree
            int[] array3Degree = new int[10];
            float sumArray3Degree = 0f;
            for (int index = 0; index < array3Degree.Length; index++)
            {
                array3Degree[index] = (int)Math.Pow(index, 3);
                sumArray3Degree += array3Degree[index];
            }
            float averageArray3Degree = sumArray3Degree / array3Degree.Length;
            Console.WriteLine("Array fulfilled by index in 3 degree: [{0}]", String.Join(", ", array3Degree));
            Console.WriteLine("Average array index value: {0}", averageArray3Degree);
        }
    }
}
