using System;
using System.Collections.Generic;

namespace MortenJuulS1.Lists.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSERT
            //delOpg.1
            List<string> names = new List<string>() { "Hans", "Gerda", "Knud", "Karsten", "Irene" };

            //delOpg.2
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //delOpg.3
            names.Insert(3, "Anders");
            names.Insert(4, "Johanne");

            //delOpg.4
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            // REMOVE
            //delOpg.1
            List<int> ages = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };
            
            //delOpg.2
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            //delOpg.3
            ages.Remove(13);
            ages.Remove(15);
            Console.WriteLine();
            //delOpg.4
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine();

            //delOpg.5
            ages.RemoveAt(2);

            //delOpg.6
            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
