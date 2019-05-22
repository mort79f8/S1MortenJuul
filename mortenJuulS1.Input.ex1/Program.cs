using System;

namespace mortenJuulS1.Input.ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////delOpg.1
            //Console.WriteLine("Indtast dit navn");
            //string name = Console.ReadLine();
            //Console.WriteLine($"1: Hej {name}. Godt of se dig!");

            ////delOpg.2
            //Console.WriteLine("Indtast dit navn");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Indtast et bil mærke");
            //string carBrand = Console.ReadLine();
            //Console.WriteLine("Indtast navnet på en ven");
            //string friendName = Console.ReadLine();
            //Console.WriteLine($"2: {firstName} køre i en {carBrand} med {friendName} ud i det blå");

            ////delOpg.3
            //Console.WriteLine("Indtast et bogstav");
            //char aLetter = char.Parse(Console.ReadLine());
            //Console.WriteLine($"du tastede {aLetter}");

            //delOpg.4
            //Console.WriteLine("Indtaste din aldre");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"4: Utroligt! Er du virkelig kun {age} år??");

            //delOpg.5
            //Console.WriteLine("Indtaste temperaturen lige nu, du skal skrive det over 2 gange f.eks: 2.56 grader vil blive skrevet 2 og 0,56");
            //double temp = double.Parse(Console.ReadLine());
            //string location = Console.ReadLine();
            //Console.WriteLine($"5: {temp} er da en fin temperatur for {location}");

            //delOpg.6
            //Console.Write("Indtaste din vægt: ");
            //string input = Console.ReadLine();
            //double.TryParse(input, out double weight);
            //Console.WriteLine($"6: Din vægt er {weight} kg");

            //delOpg.7
            //Console.WriteLine("Indtaste din aldre");
            //string age = Console.ReadLine();
            //double.TryParse(age, out double myAge);
            //Console.WriteLine($"7.4: Utroligt! Er du virkelig kun {myAge} år??");

            //delOpg.7
            Console.WriteLine("Indtaste temperaturen lige nu, du skal skrive det over 2 gange f.eks: 2.56 grader vil blive skrevet 2 og ,56");
            double.TryParse(Console.ReadLine(), out double temp);
            string location = Console.ReadLine();
            Console.WriteLine($"7.5: {temp} er da en fin temperatur for {location}.");

        }
    }
}
