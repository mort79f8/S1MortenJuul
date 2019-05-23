using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MortenJuulS1.Reader.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\S1\Code\S1MortenJuul\MortenJuulS1.Reader.Ex3\persons.txt";

        }

        private static List<string> GetBoxInfoFromFile(string path)
        {
            List<string> personinfo = new List<string>();

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string n = "";
                while ((n = reader.ReadLine()) != null)
                {
                    personinfo.Add(n);
                }
            }
            return personinfo;

        }

        private static string[] SplitPersonInfo(string input)
        {
            string[] splittedInput = input.Split(',');
            return splittedInput;
        }

        private static Person CreateAPersonFromStringArray(string[] input)
        {
            int.TryParse(input[2], out int age);

            return new Person(input[0], input[1], age);
        }

        private static List<Person> ConvertPersonInfoToListOfPerson(List<string> listOfPersonInfo)
        {
            string[] split = new string[3];
            List<Person> personList = new List<Person>();
            foreach (var box in listOfPersonInfo)
            {
                split = SplitPersonInfo(box);
                personList.Add(CreateAPersonFromStringArray(split));
            }
            return personList;
        }

        private static int OldestPerson(List<Person> personList)
        {
            List<int> ages = new List<int>();
            foreach (var person in personList)
            {
                ages.Add(person.Age);
            }
            return ages.Max();
        }
        private static int YoungesttPerson(List<Person> personList)
        {
            List<int> ages = new List<int>();
            foreach (var person in personList)
            {
                ages.Add(person.Age);
            }
            return ages.Min();
        }
    }
}
