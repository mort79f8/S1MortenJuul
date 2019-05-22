using System;

namespace mortenJuulS1.Output.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //delOpg.1
            Console.WriteLine("delOpg.1");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hello World");

            //delOpg.2
            // **** reset background and forground ****
            Console.ResetColor();
            // **** reset done ****
            Console.WriteLine("delOpg.2");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Error!");
            Console.WriteLine("Der skete en fejl. Genstart computeren...");

            //delOpg.3
            // **** reset background and forground ****
            Console.ResetColor();
            // **** reset done ****
            Console.WriteLine("delOpg.3");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("GRØN");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("BLÅ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("GUL");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("RØD");


        }
    }
}
