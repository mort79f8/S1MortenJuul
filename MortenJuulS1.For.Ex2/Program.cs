using System;

namespace MortenJuulS1.For.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            //for (int i = 3; i < 11*3; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //delOpg.2
            //for (int i = 7; i < 11*7; i += 7)
            //{
            //    Console.WriteLine(i);
            //}

            //delOpg.3
            while (true)
            {
                Console.WriteLine("Indtast et heltal fra 1 til 20 og du vil få tabelen for det tal eller skriv (exit) for at afslutte");
                string whatNumber = Console.ReadLine();

                if (whatNumber == "exit")
                {
                    break;
                }

                Console.WriteLine("Indtast et heltal fra 10 til 20 og den tabel du har valg vil op til valt tal gange med det tal du vælger");
                int howHigh = int.Parse(Console.ReadLine());

                if (int.Parse(whatNumber) < 1 )
                {
                    Console.WriteLine("forkert tal");
                }
                else if (int.Parse(whatNumber) > 20)
                {
                    Console.WriteLine("forkert tal");
                }                
                else
                {
                    for (int i = int.Parse(whatNumber); i < (howHigh * int.Parse(whatNumber)) +1; i += int.Parse(whatNumber))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
