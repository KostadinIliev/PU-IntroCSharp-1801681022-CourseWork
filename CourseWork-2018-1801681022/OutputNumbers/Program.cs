using System;

namespace OutputNumbers
{
    class Program
    {
        static void Main(string[] args)
            // Задача 211 д) : Да се изведат числата от 1 до 100 по следния начин:
            //100, 1, 2, 99, 98, 3, 4, 97, ...,52, 49, 50, 51.
        {
            for (int i= 1, j = 100; i <=50;i+=2, j-=2)
            {
                Console.Write(j + "," + i + "," + (i + 1) + "," + (j - 1) + ",");
            }
        }
    }
}
