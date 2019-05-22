using System;

namespace MortenJuulS1.Array.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] wholeNumbers = new int[7] { -4, 5, 34, -21, 30, 1, -22};


            //for (int i = 0; i < wholeNumbers.Length; i++)
            //{
            //    Console.WriteLine(wholeNumbers[i]);
            //}

            //string[] cities = new string[5] { "københavn", "Aarhus", "Odense", "Aalborg", "Esbjerg" };

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //double[] tempAverage = new double[] { 5.7, 4.9, 4.5, 4.1, 3.6, 3, 0, 2.9, 4.5, 7.4, 9.9, 11.3, 12.3, 13.0, 13.5, 13.8 };
            //for (int i = 0; i < tempAverage.Length; i++)
            //{
            //    Console.WriteLine(tempAverage[i]);
            //}

            string[] studentName = new string[] { "Kian", "Anton", "Morten" };
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(studentName[i]);
            }

        }
    }
}
