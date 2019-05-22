using System;

namespace mortenJuulS1.VD.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            string fruit = "Pære";
            Console.WriteLine($"1: {fruit}");
            fruit = "Banan";
            Console.WriteLine($"1: {fruit}");

            //delOpg.2
            string firstName = "Morten";
            string lastName = "Juul";
            Console.WriteLine("2.a: " + firstName + " " + lastName);
            Console.WriteLine($"2.b: {firstName} {lastName}");
            Console.WriteLine("2.c: {0} {1}", firstName, lastName);

            //delOpg.3
            int aNumber = 0;
            aNumber = 1;
            Console.WriteLine($"3: {aNumber}");
            //delOpg.4
            aNumber = 10;
            Console.WriteLine($"4: {aNumber}");
            aNumber = aNumber + 5;
            Console.WriteLine($"4: {aNumber}");
            aNumber = 100 - 50;
            Console.WriteLine($"4: {aNumber}");

            //delOpg. 5
            double decimalNumberVariable = 3.14159265359;
            char aCharVariable = 'a';
            bool booleanVariable = true;
            Console.WriteLine($"5: {decimalNumberVariable} {aCharVariable} {booleanVariable}");
            decimalNumberVariable = 6.5359;
            aCharVariable = 'b';
            booleanVariable = false;
            Console.WriteLine($"5: {decimalNumberVariable} {aCharVariable} {booleanVariable}");
            decimalNumberVariable = 10.3452;
            aCharVariable = 'c';
            booleanVariable = true;
            Console.WriteLine($"5: {decimalNumberVariable} {aCharVariable} {booleanVariable}");



        }
    }
}
