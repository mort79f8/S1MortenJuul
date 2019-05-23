using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            //boxInfoList = GetBoxInfoFromFile(path);
            //boxes = ConvertBoxInfoToListOfBox(boxInfoList);
            
            // Console.WriteLine($"Box info text file findes: {GetBoxesFromFile(path, out boxes)}");
            if (GetBoxesFromFile(path, out boxes))
            {
                foreach (var box in boxes)
                {
                    box.PrintInfo();
                    Console.WriteLine();
                }

                Console.WriteLine($"Det mindste volume er: {LowestVolume(boxes)}");
                Console.WriteLine($"Det højeste volume er: {HighestVolume(boxes)}");
                Console.WriteLine($"Det mindste rumfang er: {LowestSurfaceArea(boxes)}");
                Console.WriteLine($"Det højeste rumfang er: {HighestSurfaceArea(boxes)}");
            }
            else
            {
                Console.WriteLine("Der er ingen fil til at få data fra");
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

        private static int LowestVolume(List<Box> listOfBoxes)
        {
            List<int> volumeList = new List<int>();
            foreach (var box in listOfBoxes)
            {
                box.CalculateVolume();
                volumeList.Add(box.Volume);
            }
            return volumeList.Min();
        }
        private static int HighestVolume(List<Box> listOfBoxes)
        {
            List<int> volumeList = new List<int>();
            foreach (var box in listOfBoxes)
            {
                box.CalculateVolume();
                volumeList.Add(box.Volume);
            }
            return volumeList.Max();
        }

        private static int LowestSurfaceArea(List<Box> listOfBoxes)
        {
            List<int> surfaceList = new List<int>();
            foreach (var box in listOfBoxes)
            {
                box.CalculateSurface();
                surfaceList.Add(box.Surface);
            }
            return surfaceList.Min();
        }

        private static int HighestSurfaceArea(List<Box> listOfBoxes)
        {
            List<int> surfaceList = new List<int>();
            foreach (var box in listOfBoxes)
            {
                box.CalculateSurface();
                surfaceList.Add(box.Surface);
            }
            return surfaceList.Max();
        }

        private static bool GetBoxesFromFile(string path, out List<Box> boxes)
        {
            if(File.Exists(path))
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
                boxes = ConvertBoxInfoToListOfBox(numbers);
                return true;
            }
            else
            {
                boxes = new List<Box>();
                return false;
            }
        }
    }
}
