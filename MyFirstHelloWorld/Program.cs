using System;

namespace MyFirstHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloMessage = "Hej verden fra en variable";
            int age = 42;

            Console.WriteLine(helloMessage);
            Console.WriteLine(age);

            age = 29 + 3;

            Console.WriteLine(age);
        }
    }
}
