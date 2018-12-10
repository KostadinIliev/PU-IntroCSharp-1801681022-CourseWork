using System;

namespace Cone
{
    class Program
    {
        static void Main(string[] args)
        // Задача 7 (I-група) :
        // Да се състави програма, която изчислява и извежда на екрана обема V на пресечен конус,
        //като се зададат височината H и радиусите на доланата и горна основа, съответно R и r,
        // по формулата V = π.H.(R2 + R.r +r2) / 3.
        {
            Console.WriteLine("Enter the height:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the upper base:");
            double rUpperBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the radius of the lower base:");
            double rLowerBase = double.Parse(Console.ReadLine());

            double result = Math.PI * height * (rUpperBase * rUpperBase + rUpperBase * rLowerBase + rLowerBase * rLowerBase) / 3;

            Console.WriteLine("The volume is: " + result);
        }
    }
}
