using System;

namespace MortenJuulS1.While.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            //while (true)
            //{
            //    Console.WriteLine("Skriv exit for at stoppe");
            //    String input = Console.ReadLine();
            //    if (input == "exit")
            //    {
            //        break;
            //    }
            //}

            //delOpg.2
            while (true)
            {
                Console.WriteLine("Indtast et tal mellem 0 og 11");
                int input = int.Parse(Console.ReadLine());

                if (input <= 0)
                {
                    break;
                }
                else if (input >= 11)
                {
                    break;
                }
            }

        }
    }
}
