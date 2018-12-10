using System;
using System.Linq;

namespace Temperature
{
    class Program
        // Задача 395: Да се състави програма в която:
        // а) се дефинира метод CelF(f), в който формалния параметър f представлява температурата по Фаренхайт, а
        // резултатът от метода е същата температура, изчислена в Целзиеви градуси по формулата 5/9(f-32);
        // б) се въвежда масив от до 31 числа в интервала [-100,100]-средни дневни темпераури по Фаренхайт за даден месец;
        // в) се отпечатва на екрана максималната среднодневна температура 
        // - по Фаренхайт
        // - по Целзий
        // г) се извеждат на екрана тези среднодневни температури, които са по-малки от -10градуса по Целзий.
       
    {
        static void Main(string[] args)
        {
            double[] temps = new double[31];
            Console.WriteLine("Enter the average daily temperatures for the month [-100, 100]:");
            for (int i = 0; i < 31; i++)
            {
                double temperature = double.Parse(Console.ReadLine());
                if (temperature >= -100 && temperature <= 100)
                {
                    temps[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    i--;
                }
            }

            double max = temps.Max();

            Console.WriteLine($"\nThe maximum average daily temperature for the month is {max}°F -> {CelF(max):0.0}°C");

            Console.WriteLine("\nTemperatures below -10°C:");
            Console.WriteLine(string.Join(", ", temps.Where(x => CelF(x) < -10).Select(x => $"{CelF(x):0.0}")));
            Console.WriteLine();

        }
        static double CelF(double f)
        {
            double celC = (double)5 / 9 * (f - 32);
            return celC;

        }
    }
}
