using System;

namespace NumeralSystem
{
    class Program
    {
        static void Main(string[] args)
            // Превърнете в 2, 8 и 16 ична.
        {
            int value = 2022;
            string binary = Convert.ToString(value, 2);
            string binary2 = Convert.ToString(value, 8);
            string binary3 = Convert.ToString(value, 16);
            Console.WriteLine(binary);
            Console.WriteLine(binary2);
            Console.WriteLine(binary3);
        }
    }
}
