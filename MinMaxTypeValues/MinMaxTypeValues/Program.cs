using System;

namespace MinMaxTypeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    byte.MinValue.GetType().Name, byte.MinValue, byte.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    short.MinValue.GetType().Name, short.MinValue, short.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    int.MinValue.GetType().Name, int.MinValue, int.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    long.MinValue.GetType().Name, long.MinValue, long.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    float.MinValue.GetType().Name, float.MinValue, float.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    double.MinValue.GetType().Name, double.MinValue, double.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    uint.MinValue.GetType().Name, uint.MinValue, uint.MaxValue
                );

            Console.WriteLine
                (
                    "Minimal {0} data type value = {1},\nMaximal {0} data type value = {2}.\n",
                    ulong.MinValue.GetType().Name, ulong.MinValue, ulong.MaxValue
                );
        }
    }
}
