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
            string path = @"D:\S1\Code\S1MortenJuul\MortenJuulS1.Reader.Ex2\boxInfo.txt";
            List<string> boxInfoList = new List<string>();

            boxInfoList = GetBoxInfoFromFile(path);
            boxes = ConvertBoxInfoToListOfBox(boxInfoList);

            foreach (var box in boxes)
            {
                box.PrintInfo();
                Console.WriteLine();
            }
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

        private static Box CreateABoxFromStringArray(string[] input)
        {
            int.TryParse(input[0], out int height);
            int.TryParse(input[1], out int length);
            int.TryParse(input[2], out int width);

            return new Box(height, length, width);
        }

        private static List<Box> ConvertBoxInfoToListOfBox(List<string> listOfBoxInfo)
        {
            string[] split = new string[3];
            List<Box> boxList = new List<Box>();
            foreach (var box in listOfBoxInfo)
            {
                split = SplitBoxInfo(box);
                boxList.Add(CreateABoxFromStringArray(split));
            }
            return boxList;
        }
    }
}
