using System;

namespace mortenJuulS1.Arithmetic.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du kan indtaste 4 personers højde i cm.");
            Console.Write("Person 1: ");
            int person1Height = int.Parse(Console.ReadLine());
            Console.Write("Person 2: ");
            int person2Height = int.Parse(Console.ReadLine());
            Console.Write("Person 3: ");
            int person3Height = int.Parse(Console.ReadLine());
            Console.Write("Person 4: ");
            int person4Height = int.Parse(Console.ReadLine());
            double average = (person1Height + person2Height + person3Height + person4Height) / 4;
            Console.WriteLine($"Gennemsnit højde for dem alle er: {average}");

        }
    }
}
