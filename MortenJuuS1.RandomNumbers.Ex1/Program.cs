using System;

namespace MortenJuulS1.RandomNumbers.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            //delOpg.1
            // der kan være et problem med at bruge 1 random til flere number hvis de bliver lavet med det samme da Random er baseret på tid.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"heltal number {i+1}: {randomNumber.Next(0,10)}");
            }
            Console.WriteLine();

            //delOpg.2
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"heltal number {1+1}: {randomNumber.Next(-10,10)}");
            }
            Console.WriteLine();

            //delOpg.3 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Komma tal {i+1}: {randomNumber.NextDouble()} ");
            }


        }
    }
}
