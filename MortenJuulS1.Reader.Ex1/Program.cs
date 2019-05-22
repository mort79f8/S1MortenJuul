using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MortenJuulS1.Reader.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\C# - Skole\git\S1MortenJuul\MortenJuulS1.Reader.Ex1\RandomNumbers.txt";

            //int sumOfNumbers = 0;
            //int amountOfNumbers = 0;
            List<int> myListOfNumbers = new List<int>();

            //using (StreamReader reader = new StreamReader(path, Encoding.Default))
            //{
            //    string n = "";
            //    while ((n = reader.ReadLine()) != null)
            //    {
            //        int.TryParse(n, out int aNumber);
            //        sumOfNumbers += aNumber;
            //        amountOfNumbers++;
            //    }
            //}
            //Console.WriteLine($"Sum of all the numbers: {sumOfNumbers}");
            //Console.WriteLine($"Average of all the numbers: {sumOfNumbers / amountOfNumbers}");
            //Console.WriteLine();

            if (GetNumbersFromFile(path, out myListOfNumbers))
            {
                Console.WriteLine("the File is here!!");
                foreach (var number in myListOfNumbers)
                {
                    Console.WriteLine(number);
                }

            }

        }

        private static bool GetNumbersFromFile(string path, out List<int> listOfNumbers)
        {
            List<int> numbers = new List<int>();
            if (File.Exists(path))
            {

            
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string n = "";
                while ((n = reader.ReadLine()) != null)
                {
                    if(int.TryParse(n, out int aNumber))
                    {
                        numbers.Add(aNumber);
                    }
                    else
                    {
                        Console.WriteLine("Woops not a whole number!");
                    }
                    
                }
            }
            listOfNumbers = numbers;
            return File.Exists(path);
            }
            else
            {
                Console.WriteLine("The file aint there mate");
                listOfNumbers = numbers;
                return File.Exists(path);
            }
        }
    }
}
