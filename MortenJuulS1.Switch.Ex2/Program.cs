using System;

namespace MortenJuulS1.Switch.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtaste et familemedlem (fx mor, bedstefar eller lignende):");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "mor":
                case "far":
                    Console.WriteLine("Du har indtastet et " + 
                        "2. generationdmedlem af familien");
                    break;
                case "mormor":
                case "farmor":
                case "bedstefar":
                case "bedstemor":
                case "farfar":
                    Console.WriteLine("Du har indtastet et " +
                        "3. generationdmedlem af familien");
                    break;
                default:
                    Console.WriteLine("Du har indtastet et ukendt familiemedlem");
                    break;
            }

        }
    }
}
