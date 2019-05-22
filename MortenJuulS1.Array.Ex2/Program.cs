using System;

namespace MortenJuulS1.Array.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            //string[] names = new string[5];
            //Console.WriteLine("Du skal nu indtaste 5 drenge navne.");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Indtast et dreng navn: ");
            //    names[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //delOpg.2
            //int[] wholeNumbers = new int[10];
            //double average = 0;

            //Console.WriteLine("Du skal nu indtaste højden på 10 personer i cm.");
            //for (int i = 0; i < wholeNumbers.Length; i++)
            //{
            //    Console.Write("Indtast højde: ");
            //    wholeNumbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < wholeNumbers.Length; i++)
            //{
            //    average = average + wholeNumbers[i];
            //}

            //Console.WriteLine($"Gennemsnitte er: {average / wholeNumbers.Length}");

            //delOpg.3
            //bool[] isCarParked = new bool[10];
            //int parkingSpaceAvail = 0;

            //for (int i = 0; i < isCarParked.Length; i++)
            //{
            //    Console.WriteLine($"Holder der er bil parkeret på plads {i + 1} y/n: ");
            //    char yesNo = Console.ReadKey().KeyChar;
            //    Console.WriteLine();
            //    if (yesNo == 'y')
            //    {
            //        isCarParked[i] = true;
            //    }
            //    else
            //    {
            //        isCarParked[i] = false;
            //    }
            //}

            //for (int i = 0; i < isCarParked.Length; i++)
            //{
            //    if (isCarParked[i] == false)
            //    {
            //        parkingSpaceAvail++;
            //    }
            //}

            //Console.WriteLine($"Der er {parkingSpaceAvail} pladser ledig");

            //delOpg.4
            // man kan bruge Syste.Array.Reverse( navn på array );
            double[] decimalTal = new double[5];

            for (int i = 0; i < decimalTal.Length; i++)
            {
                Console.WriteLine("Indtast et decimal tal med 2 decimaler: ");
                decimalTal[i] = double.Parse(Console.ReadLine());

            }
       

            for (int i = decimalTal.Length - 1; i > -1; i--)
            {
                Console.WriteLine(decimalTal[i]);
            }

        }
    }
}
