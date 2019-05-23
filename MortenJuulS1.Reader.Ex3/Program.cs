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
            OldestPerson(ConvertPersonInfoToListOfPerson(GetPersonInfoFromFile(path)));
            YoungestPerson(ConvertPersonInfoToListOfPerson(GetPersonInfoFromFile(path)));
            LongestFirstName((ConvertPersonInfoToListOfPerson(GetPersonInfoFromFile(path))));
            ShortestFirstName((ConvertPersonInfoToListOfPerson(GetPersonInfoFromFile(path))));
        }

        private static List<string> GetPersonInfoFromFile(string path)
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

        private static void OldestPerson(List<Person> personList)
        {
            Person oldestPerson = new Person("untitled", "untitled", 0);

            foreach (var person in personList)
            {
                if (oldestPerson.Age < person.Age)
                {
                    oldestPerson = person;
                }
            }
            Console.WriteLine($"Den ældste person er {oldestPerson.FirstName} {oldestPerson.LastName}");

        }
        private static void YoungestPerson(List<Person> personList)
        {
            Person youngestPerson = new Person("untitled", "untitled", 1000);

            foreach (var person in personList)
            {
                if (youngestPerson.Age > person.Age)
                {
                    youngestPerson = person;
                }
            }
            Console.WriteLine($"Den yngest person er {youngestPerson.FirstName} {youngestPerson.LastName}");

        }

        private static void LongestFirstName(List<Person> personList)
        {
            int longest = 0;
            Person personLongest = new Person();
            foreach (var person in personList)
            {
                if(longest < person.FirstName.Length)
                {
                    personLongest = person;
                    longest = person.FirstName.Length;
                }
            }
            Console.WriteLine($"Personen med det længest fornavn er: {personLongest.FirstName}");
        }

        private static void ShortestFirstName(List<Person> personList)
        {
            int shortest = 1000;
            Person personshortest = new Person();
            foreach (var person in personList)
            {
                if (shortest > person.FirstName.Length)
                {
                    personshortest = person;
                    shortest = person.FirstName.Length;
                }
            }
            Console.WriteLine($"Personen med det mindste fornavn er: {personshortest.FirstName}");
        }
    }
}
