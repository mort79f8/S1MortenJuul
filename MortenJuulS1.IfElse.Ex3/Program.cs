using System;

namespace MortenJuulS1.IfElse.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight;
            int price;
            bool express = false;
            char expressAnsver;


            Console.Write("Indtast vægten på dit brev i gram: ");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Skal dit brev sendes ekspres? y/n: ");
            expressAnsver = Console.ReadKey().KeyChar;

            if (weight <= 20)
            {
                price = 5;
            }
            else if(weight <= 50)
            {
                price = 7;
            }
            else if(weight <= 100)
            {
                price = 12;
            }
            else if (weight <= 250)
            {
                price = 15;
            }
            else
            {
                price = 30;
            }

            if(expressAnsver == 'y')
            {
                price = price + 5;
            }

            Console.WriteLine();
            Console.WriteLine($"Prisen er: {price:C}");
        }
    }
}
