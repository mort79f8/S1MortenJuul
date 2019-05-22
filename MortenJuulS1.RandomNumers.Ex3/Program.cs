using System;
using System.Linq;

namespace MortenJuulS1.RandomNumbers.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            Random randomNumber = new Random();

            int[] collectionOfNumbers = new int[10001];

            for (int i = 0; i < collectionOfNumbers.Length; i++)
            {
                collectionOfNumbers[i] = randomNumber.Next(-100, 100);
            }

            //delOpg.1a
            int average = 0;

            for (int i = 0; i < collectionOfNumbers.Length; i++)
            {
                average = average + collectionOfNumbers[i];
            }

            average = average / 10001;

            //delOpg.1b
            int highestValueBuildIn = collectionOfNumbers.Max();

            //delOpg.1c
            int lowestValueBuildIn = collectionOfNumbers.Min();

            //delOpg.1d
            int highestValueLoop = 0;

            for (int i = 0; i < collectionOfNumbers.Length; i++)
            {
                if (highestValueLoop < collectionOfNumbers[i])
                {
                    highestValueLoop = collectionOfNumbers[i];
                }
            }

            //delOpg.1e
            int lowestValueLoop = 100;

            for (int i = 0; i < collectionOfNumbers.Length; i++)
            {
                if (lowestValueLoop > collectionOfNumbers[i])
                {
                    lowestValueLoop = collectionOfNumbers[i];
                }
            }

            // printout of the Array
            //for (int i = 0; i < collectionOfNumbers.Length; i++)
            //{
            //    Console.WriteLine(collectionOfNumbers[i]);
            //}

            Console.WriteLine($"Highest value found by buildin metode: {highestValueBuildIn}");
            Console.WriteLine($"Lowest value found by buildin metode: {lowestValueBuildIn}");
            Console.WriteLine($"Highest value found by loop: {highestValueLoop}");
            Console.WriteLine($"Lowest value found by loop: {lowestValueLoop}");


        }
    }
}
