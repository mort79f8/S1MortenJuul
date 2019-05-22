using System;

namespace MortenJuulS1.Switch.Ex4
{
    class Program
    {

        enum Importance
        {
            None,
            Trivial,
            Regular,
            Importent,
            Critical
        }
        static void Main(string[] args)
        {
            string error;

            Console.Write("Skriv hvor vigtigt din fejl er (None, Trivial, Regular, Importent, Critical): ");
            error = Console.ReadLine();
            Console.WriteLine();

            Enum.TryParse(error, true, out Importance importance);

            switch (importance)
            {
                case Importance.None:
                    Console.WriteLine("None: Det lyder ligegyldigt");
                    break;
                case Importance.Trivial:
                    Console.WriteLine("Trivial: Det sætter jeg praktikanten til at ordne");
                    break;
                case Importance.Regular:
                    Console.WriteLine("Regular: Mon ikke der nok går...");
                    break;
                case Importance.Importent:
                    Console.WriteLine("Importent: Jeg drikker lige en kop kaffe, så er jeg der");
                    break;
                case Importance.Critical:
                    Console.WriteLine("Critical: Oh shit...");
                    break;
                default:
                    break;
            }

            //spørgsmål: Hvis man indtaste en ukendt enum tekst så får den værdien 0. 
        }
    }
}
