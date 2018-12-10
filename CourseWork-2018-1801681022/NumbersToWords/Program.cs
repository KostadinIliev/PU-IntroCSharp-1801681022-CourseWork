using System;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
            // Задача 367: Съставето мето, който при зададена цифра връща записа на тази цифра с думи.
            //Например, при въведена цифра 8, резултатът е осем.
        {
            Console.WriteLine("Enter a  digit: ");
            int digit = int.Parse(Console.ReadLine());
            string result = "";
            switch (digit)
            {
                case 0:
                    result = "нула";
                    break;
                case 1:
                    result = "едно";
                    break;
                case 2:
                    result = "две";
                    break;
                case 3:
                    result = "три";
                    break;
                case 4:
                    result = "четири";
                    break;
                case 5:
                    result = "пет";
                    break;
                case 6:
                    result = "шест";
                    break;
                case 7:
                    result = "седем";
                    break;
                case 8:
                    result = "осем";
                    break;
                case 9:
                    result = "девет";
                    break;
                default:
                    result = "Invalid input!";
                    break;
            }
            Console.WriteLine(result);

        }
    }
}
