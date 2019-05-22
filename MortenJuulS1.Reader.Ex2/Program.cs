using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MortenJuulS1.Reader.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string path = @"F:\C# - Skole\git\S1MortenJuul\MortenJuulS1.Reader.Ex2\boxInfo.txt";

        }

        private static List<string> GetBoxInfoFromFile(string path)
        {
            List<string> numbers = new List<string>();

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string n = "";
                while ((n = reader.ReadLine()) != null)
                {
                    numbers.Add(n);
                }
            }
            return numbers;
            
        }

        private static string[] SplitBoxInfo(string input)
        {
            string[] splittedInput = input.Split(',');
            return splittedInput;
        }

    }
}
