using System;
using System.Collections.Generic;

namespace MortenJuulS1.Lists.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            List<int> ages = new List<int>();
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(91);

            //delOpg.2
            List<string> names = new List<string>() { "Morten", "Kian", "Anton", "Daniel" };

            //delOpg.3
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.69, 0.17 };

            //delOpg.4
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            //delOpg.5

            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            foreach (var percent in percentages)
            {
                Console.WriteLine(percent);
            }

            foreach (var married in areMarried)
            {
                Console.WriteLine(married);
            }

        }
    }
}
