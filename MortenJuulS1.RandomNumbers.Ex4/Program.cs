using System;

namespace MortenJuulS1.RandomNumbers.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int highScore = 1000;
            Random rngNumber = new Random();
            int ansver;
            int numberOfguess;

            //delOpg.1
            //while (true)
            //{
            //    int theNumberToGuess = rngNumber.Next(0, 11);
            //    numberOfguess = 0;

            //    while (true)
            //    {
            //        Console.WriteLine("Gæt på et tal mellem 0 og 10: ");
            //        ansver = int.Parse(Console.ReadLine());
            //        numberOfguess++;

            //        if (ansver == theNumberToGuess)
            //        {
            //            if (highScore > numberOfguess)
            //            {
            //                highScore = numberOfguess;
            //            }
            //            Console.WriteLine("Bravo du gættede det rigtige tal!");
            //            Console.WriteLine($"Du brugte kun: {numberOfguess} gæt");
            //            Console.WriteLine($"Din highscore er: {highScore}");
            //            break;

            //        }
            //        else
            //        {
            //            Console.WriteLine("avv det var forkert prøv igen");
            //        }

            //    }
            //}

            //delOpg.2
            int lowerLimit;
            int upperLimit;

            while (true)
            {

                numberOfguess = 0;

                while (true)
                {
                    Console.WriteLine("du skal gætter på et tal mellem 2 værdier som du selv vælger dog skal det min. være mellem 0 og 10");
                    Console.WriteLine("skriv det mindste tal:");
                    lowerLimit = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv det højste tal:");
                    upperLimit = int.Parse(Console.ReadLine());
                    if ((lowerLimit < 0 || upperLimit < 10) || (lowerLimit > 0 || upperLimit < 10))
                    {
                        Console.WriteLine("husk det skal som minimum være mellem 0 og 10");
                    }
                    else
                    {
                        break;
                    }
                }
                int theNumberToGuess = rngNumber.Next(lowerLimit, upperLimit + 1);

                while (true)
                {
                    Console.WriteLine("Gæt på et tal mellem 0 og 10: ");
                    ansver = int.Parse(Console.ReadLine());
                    numberOfguess++;

                    if (ansver == theNumberToGuess)
                    {
                        if (highScore > numberOfguess)
                        {
                            highScore = numberOfguess;
                        }

                        Console.WriteLine("bravo du gættede det rigtige tal!");
                        Console.WriteLine($"du brugte kun: {numberOfguess} gæt");
                        Console.WriteLine($"Din highscore er: {highScore}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("avv det var forkert prøv igen");
                    }

                }
            }

        }
    }
}
