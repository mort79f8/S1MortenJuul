using System;

namespace MortenJuulS1.Switch.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal;

            Console.Write("Indtast et af følgne dyr, gris, hund, kat eller ko: ");
            animal = Console.ReadLine();

            switch (animal.ToLower())
            {
                case "gris":
                    Console.WriteLine("Grisen har en grisehale og levere bacon");
                    break;
                case "hund":
                    Console.WriteLine("hunden er menneskets bedste ven og elsker at blive kløet på maven");
                    break;
                case "kat":
                    Console.WriteLine("Katten er huset hersker, og mennesker er der for at give den mad og klø den bag øret");
                    break;
                case "ko":
                    Console.WriteLine("Ko'en har 4 maver og laver mælk, der er rygter om at køer fra Chernobil levere kærnemælk!");
                    break;
                default:
                    Console.WriteLine("Ukendt dyr");
                    break;
            }

            // spørgsmål: ja der er en forskel på store og små bogstaver.

        }
    }
}
