using System;

namespace MortenJuulS1.Classes.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            box.Height = 40;
            box.Length = 60;
            box.Width = 20;

            //Console.WriteLine("Kassen har følgende mål");
            //Console.WriteLine($"Højde:\t{box.Height}");
            //Console.WriteLine($"Længde:\t{box.Length}");
            //Console.WriteLine($"Bredde:\t{box.Width}");

            box.PrintInfo();

            //rumfang vil blive vist 2 gange hvis man indsætter box.CalculateVolume(); her

        }
    }
}
