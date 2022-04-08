using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 1, 5, 10, 20, 60, 80, 90, 120, 140, 200, 240, 300, 380, 420, 570, 690, 720, 800, 850, 900, 1024 };
            int[] unsortedArray = { 5, 100, 90, 10, 25, 6, 17, 71, 98, 120, 351 };
            Algorithm alg = new Algorithm(unsortedArray);
            StringShower stringShower = new StringShower(unsortedArray);
            Console.WriteLine(stringShower.GetArrayText());
            alg.InsertionSort();
            Console.WriteLine(stringShower.GetArrayText());
            Console.WriteLine(alg.Factorial(7));

        }
    }
}
