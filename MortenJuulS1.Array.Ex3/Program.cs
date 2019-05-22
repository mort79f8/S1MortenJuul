using System;

namespace MortenJuulS1.Array.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGoods;

            while (true)
            {

                Console.WriteLine("Hvor mange vare ønsker du at indtaste priserne på? (antal fra 1 til 25");
                numberOfGoods = int.Parse(Console.ReadLine());

                if (numberOfGoods < 1)
                {
                    Console.WriteLine("Du skal indtaste en værdie fra 1 til 25");
                }
                else if (numberOfGoods > 25)
                {
                    Console.WriteLine("Du skal indtaste en værdie fra 1 til 25");
                }
                else
                {
                    break;
                }

            }

            double[] priceOfGoods = new double[numberOfGoods];
            

            for (int i = 0; i < priceOfGoods.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("Indtast pris på varen (skal være imellem 0.00 og 20000): ");
                    double priceHoldingSpace = double.Parse(Console.ReadLine());

                    if (priceHoldingSpace <= 0.00)
                    {
                        Console.WriteLine("Du skal indtaste en pris mellem 0.00 og 20000");
                    }
                    else if (priceHoldingSpace >= 20000)
                    {
                        Console.WriteLine("Du skal indtaste en pris mellem 0.00 og 20000");
                    }
                    else
                    {
                        priceOfGoods[i] = priceHoldingSpace;
                        break;
                    }
                }
            }

            double totalPriceOfGoods = 0;

            for (int i = 0; i < priceOfGoods.Length; i++)
            {
                totalPriceOfGoods = totalPriceOfGoods + priceOfGoods[i];
            }

            double averagePriceOfGoods = totalPriceOfGoods / priceOfGoods.Length;
            double saleTax = totalPriceOfGoods * 0.25;

            Console.WriteLine($"Total pris for alle vare:\t{totalPriceOfGoods}");
            Console.WriteLine($"Gennemsnit pris for varene:\t{averagePriceOfGoods}");
            Console.WriteLine($"Den samlede moms for varene:\t{saleTax}");
            Console.WriteLine($"Total pris med moms:\t\t{totalPriceOfGoods + saleTax}");
           
        }
    }
}
