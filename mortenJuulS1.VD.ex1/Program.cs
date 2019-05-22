using System;
using System.Collections.Generic;
using System.Linq;

namespace mortenJuulS1.VD.ex1
{
    class Car
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //delOpg.1
            string fullName = "Morten Juul";
            Console.WriteLine("1: " + fullName);
            //delOpg.2
            string address = "Ringholmsvej 18,1,tv 9420 Nørresundby";
            Console.WriteLine("2: " + address);
            //delOpg.3
            string aspitEmail = "mort79f8@edu.campusvejle.dk";
            Console.WriteLine("3: " + aspitEmail);
            //delOpg.4
            int number = 25;
            var cars = new List<Car>() { new Car() { Name = "Opel" }, new Car() { Name = "Mercedes" } };
            var results = cars.OrderBy(c => c.Name ).ToList();
            cars[0].Name = "VW";
            Console.WriteLine("Results[0]: " + results[0].Name);
            Console.WriteLine("Cars[0]: " + cars[0].Name);
            //var results = strings.Where(item => item.Contains("kød")).ToList();
            //results.Sort();
            string solutionPath = @"d:\\S1\\Code\\S1MortenJuul\\";
            Console.WriteLine("4: " + solutionPath);
            //delOpg.5
            string quoteString = "\"String\"";
            Console.WriteLine($"5: {quoteString}");
            //delOpg.6
            int age = 42;
            Console.WriteLine($"6: {age}");
            //delOpg.7
            int yearOfBirth = 1976;
            Console.WriteLine($"7: {yearOfBirth}");
            //delOpg.8
            int currentMinut = 1;
            Console.WriteLine($"8: {currentMinut}");
            //delOpg.9
            double promille = 0.3;
            Console.WriteLine($"9: {promille}");
            //delOpg.10
            double hundrePercent = 1;
            Console.WriteLine($"10: {hundrePercent}");
            //delOpg.11
            double hundreTwentyFivePercent = 1.25;
            Console.WriteLine($"11: {hundreTwentyFivePercent}");
            //delOpg.12
            double twentyFivePercent = 0.25;
            Console.WriteLine($"12: {twentyFivePercent}");
            //delOpg.13
            double tempTylstrupNow = 8.9;
            Console.WriteLine($"13: {tempTylstrupNow}");
            //delOpg.14
            char firstLetter = 'M';
            char secondLetter = 'o';
            char thirdLetter = 'r';
            char fourthLetter = 't';
            char fifthLetter = 'e';
            char sixthLetter = 'n';
            string firstName = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString() + fourthLetter.ToString() + fifthLetter.ToString() + sixthLetter.ToString();
            Console.WriteLine($"14: {firstLetter}{secondLetter}{thirdLetter}{fourthLetter}{fifthLetter}{sixthLetter} as chars");
            Console.WriteLine($"14: Converted char to string: {firstName}");
            //delOpg.15
            bool falseValue = false;
            bool trueValue = true;
            Console.WriteLine($"15: False state: {falseValue}, True state: {trueValue}");
            //delOpg.16
            Console.WriteLine("16: " + fullName + yearOfBirth + twentyFivePercent + firstLetter + trueValue);
            //delOpg.17
            Console.WriteLine("17: " + fullName +" "+ yearOfBirth +" "+ twentyFivePercent +" "+ firstLetter +" "+ trueValue);
            //delOpg.18
            Console.WriteLine("18: " + fullName + "\n" + yearOfBirth + "\n" + twentyFivePercent + "\n" + firstLetter + "\n" + trueValue);
            //delOpg.19
            Console.WriteLine($"19: {fullName} {yearOfBirth} {twentyFivePercent} {firstLetter} {trueValue}");


        }
    }
}
