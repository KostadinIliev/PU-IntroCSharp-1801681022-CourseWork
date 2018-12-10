using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Numbers
{
    class Program
        // Задача 376: Да се въведът от клавиатурата прозиволно число k и произволен брой ненулеви числа( за край на въвеждането служи числото 0).
        //Да се отпечата среадноаритметичното на тези от тях, които са положителни.
        //2. Да се въведат от клавиатурата 7 числа.Да се намери и да се отпечата на екрана сумата от тези от тях, които отговарят на следното условие :
        // да са отрицателни или по-големи от 300.
        //3. ДА се създаде метод Sred(k), който генерира k на брой случайни цели числа и като резултат връща средноаритметичното на тези от тях
        // които са в интервала [10,100]. В главния метод да се въведат 3 цели положителни числа a, b и c. 
        // Да се намери и отпечата: Sred(|c-b|) - Sred (c+a).
    {
        static void Main(string[] args)
        {
            Task376_1();
            Task376_2();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double exprResult = Sred(Math.Abs(c - b)) - Sred(c + a);

            Console.WriteLine("The result of the expression Sred(|c - b|) - Sred(c + a) is " + exprResult);
        }

        private static void Task376_1()
        {
            double k = double.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();

            while (true)
            {
                double input = double.Parse(Console.ReadLine());

                if (input == 0)
                {
                    break;
                }
                else if (input > 0)
                {
                    numbers.Add(input);
                }
            }

            double result = numbers.Average();

            Console.WriteLine($"The average of all positive numbers of this sequence is " + result);

        }

        private static void Task376_2()
        {
            List<double> numbers = new List<double>();

            for (int i = 0; i < 7; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0 || input > 300)
                {
                    numbers.Add(input);
                }
            }
            double result = numbers.Sum();
            Console.WriteLine("The sum of all negative or bigger than 300 numbers is " + result);
        }

        private static double Sred(int k)
        {
            Random rnd = new Random();

            List<double> numbers = new List<double>();
            for (int i = 0; i < k; i++)
            {
                int generatedNumer = rnd.Next(1000);
                if (generatedNumer >= 10 && generatedNumer <= 100)
                {
                    numbers.Add(generatedNumer);
                }
            }

            if (numbers.Count == 0)
            {
                return 0;
            }

            double result = numbers.Average();
            return result;
        }
    }
}