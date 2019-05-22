using System;

namespace MortenJuulS1.While.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv (1) for at høre noget om køer");
                Console.WriteLine("Skriv (2) for at få resultatet af 2*4");
                Console.WriteLine("Skriv (3) for at afslutte programmet");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 3)
                {
                    break;
                }
            }
        }
    }
}
