using System;

namespace AreaFigures
{
    class Program
    {
        static void Main(string[] args)
            //Задача 64: Да се състави програма, която да пресмята лицето на едно от фигурите:
            // кръг, триъгълник или правоъгълник.
        {

            Console.WriteLine("Select figure: circle, triangle, rectangle");
            string figure = Console.ReadLine();

            if (figure == "circle")
            {
                Console.WriteLine("Enter radius:");
                double radius = double.Parse(Console.ReadLine());
                double result = Math.PI * radius * radius;
                Console.WriteLine("The result is: " + result);

            }
            else if (figure == "triangle")
            {
                Console.WriteLine("Enter height:");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the side:");
                double side = double.Parse(Console.ReadLine());

                double result = side * height / 2;
                Console.WriteLine("The result is: " + result);

            }
            else if (figure == "rectangle")
            {
                Console.WriteLine("Enter side A:");
                double sideA = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter side B:");
                double sideB = double.Parse(Console.ReadLine());

                double result = sideA * sideB;
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                Console.WriteLine("Ïnvalid figure!");
            }
        }
    }
}