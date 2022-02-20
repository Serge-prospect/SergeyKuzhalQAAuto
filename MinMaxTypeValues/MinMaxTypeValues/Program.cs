using System;

namespace MinMaxTypeValues
{
    class Program
    {        
        static void Main(string[] args)
        {
            string byteType = "BYTE";
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;

            string shortType = "SHORT";
            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;

            string intType = "INT";
            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;

            string longType = "LONG";
            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;

            string floatType = "FLOAT";
            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;

            string doubleType = "DOUBLE";
            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            string uintType = "UINT";
            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;

            string ulongType = "ULONG";
            ulong ulongMinValue = ulong.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    byteType, byteMinValue, byteMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    shortType, shortMinValue, shortMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    intType, intMinValue, intMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    longType, longMinValue, longMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    floatType, floatMinValue, floatMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    doubleType, doubleMinValue, doubleMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    uintType, uintMinValue, uintMaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\n" +
                    "Maximal {0} data type value = {2}.\n",
                    ulongType, ulongMinValue, ulongMaxValue
                );
        }
    }
}
