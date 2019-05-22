using System;
using System.Linq;

namespace MortenJuulS1.BoolAlg.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            int number1 = 3;
            if (number1> 0 && number1<10)
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

            //delOpg.2
            double number2 = 3.0;
            if (number2 > 0 && number2 < 1)
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

            //delOpg.3
            int number3= 20;
            if (number3 < -10 && number3 > 0 || number3 > 0 && number3 < 10)
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

            //delOpg.4
            char aCharacter = 'e';
            if (aCharacter == 'a' || aCharacter == 'e' || aCharacter == 'u' || aCharacter == 'i' || aCharacter == 'o' || aCharacter == 'å' || aCharacter == 'æ' || aCharacter == 'ø')
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

            //delOpg.5
            if (aCharacter != 'a' && aCharacter != 'e' && aCharacter != 'u' && aCharacter != 'i' && aCharacter != 'o' && aCharacter != 'å' && aCharacter != 'æ' && aCharacter != 'ø')
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }
            
            //delOpg.6
            if (aCharacter == '0' || aCharacter == '1' || aCharacter == '2' || aCharacter == '3' || aCharacter == '4' || aCharacter == '5' || aCharacter == '6' || aCharacter == '7' || aCharacter == '8' || aCharacter == '9')
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

            //delOpg.7
            string exitOrQuit = "exit";
            if (exitOrQuit == "exit" || exitOrQuit == "quit")
            {
                Console.WriteLine("Opgaven er løst");
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }

        }
    }
}
