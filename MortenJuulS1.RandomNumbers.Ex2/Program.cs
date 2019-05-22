using System;

namespace MortenJuulS1.RandomNumbers.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int dice = 6;
            int numberOfDice;

            //delOpg.1
            //Console.WriteLine($"Du ruller en sekssidet terning og slår: {randomNumber.Next(1,Dice+1)}");

            //delOpg.2
            //while (true)
            //{
            //    Console.WriteLine("Hvor mange terning vil du slå (1-6)?");
            //    numberOfDice = int.Parse(Console.ReadLine());

            //    if (numberOfDice < 1 || numberOfDice > 6)
            //    {
            //        Console.WriteLine("Du skal vælge et tal fra 1 til 6");
            //    }
            //    else
            //    {
            //        for (int i = 0; i < numberOfDice; i++)
            //        {
            //            Console.WriteLine($"rul {i+1}: {randomNumber.Next(1,Dice)}");
            //        }
            //        break;
            //    }
            //}

            //delOpg.3
            while (true)
            {
                Console.WriteLine("Hvor mange terning vil du slå (1-6)?");
                numberOfDice = int.Parse(Console.ReadLine());
                Console.WriteLine("hvor mange sider skal terning havde (2-10)?");
                dice = int.Parse(Console.ReadLine());

                if ((numberOfDice < 1 || numberOfDice > 6) || (dice < 2 || dice > 10))
                {
                    Console.WriteLine("Du skal vælge et tal fra 1 til 6 og et fra 1 til 10");
                }
                else
                {
                    for (int i = 0; i < numberOfDice; i++)
                    {
                        Console.WriteLine($"rul {i + 1}: {randomNumber.Next(1, dice+1)}");
                    }
                    break;
                }
            }


        }
    }
}
