using System;

namespace MinMaxTypeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string byteType = "BYTE";
            string shortType = "SHORT";
            string intType = "INT";
            string longType = "LONG";
            string floatType = "FLOAT";
            string doubleType = "DOUBLE";
            string uintType = "UINT";
            string ulongType = "ULONG";

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    byteType, byte.MinValue, byte.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    shortType, short.MinValue, short.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    intType, int.MinValue, int.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    longType, long.MinValue, long.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    floatType, float.MinValue, float.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    doubleType, double.MinValue, double.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    uintType, uint.MinValue, uint.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    ulongType, ulong.MinValue, ulong.MaxValue
                );
        }
    }
}
