using System;
using System.Collections.Generic;

namespace MortenJuulS1.ObjectTraining.Ex1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // CarHandler
            //CarHandler.Car car = new CarHandler.Car("Ford", "Mustang", 1966, "Rød");

            //Console.WriteLine(car.GetInfo());
            //Console.WriteLine(car.ToString());

            //car.Color = "Blå";
            //Console.WriteLine(car.GetInfo());

            ////Svar: Man kan ændre make,model,productionYear og color
            //Console.WriteLine(car.StartCar()); // den retunere en Bool.

            //List<CarHandler.Car> cars = new List<CarHandler.Car>();

            //CarHandler.Car car1 = new CarHandler.Car("Dacia", "Logan", 2014, "Champagne");
            //CarHandler.Car car2 = new CarHandler.Car("Ford", "Focus", 2008, "Navyblue");

            //cars.Add(car1);
            //cars.Add(car2);

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            //Bilforhandlerprogram

            List<CarHandler.Car> cars = new List<CarHandler.Car>();

            while (true)
            {
                MainMenu();
                char request = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (request)
                {
                    case '1':
                        cars.Add(AddCar());
                        break;
                    case '2':
                        Console.WriteLine("Du ønsker at se information om alle bilerne");
                        foreach (var car in cars)
                        {
                            Console.WriteLine(car.GetInfo());
                        }
                        Console.WriteLine();
                        break;
                    case '3':
                        BrandSearch(cars);
                        break;
                    default:
                        break;
                }
                //if (request == '1')
                //{
                //    cars.Add(AddCar());
                //}
                //else if (request == '2')
                //{
                //    Console.WriteLine("Du ønsker at se information om alle bilerne");
                //    foreach (var car in cars)
                //    {
                //        Console.WriteLine(car.GetInfo());
                //    }
                //    Console.WriteLine();
                //}

            }

            
        }

        public static void MainMenu()
        {
            Console.WriteLine("Hej og velkommen til biladministrationen version 1997");
            Console.WriteLine("Du har nu 2 muligheder. Ønsker du at:");
            Console.WriteLine("Indtast en bil (1)");
            Console.WriteLine("Se informationer om alle biler (2)");
            Console.WriteLine("Søge efter et bilmærke (3)");
        }

        public static CarHandler.Car AddCar()
        {
            Console.WriteLine("Du ønsker at oprette en bil");
            Console.WriteLine("Indtast mærket:");
            string brand = Console.ReadLine();
            Console.WriteLine("indtast model:");
            string make = Console.ReadLine();
            Console.WriteLine("Indtast årgang:");
            int pYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast farve:");
            string color = Console.ReadLine();
            CarHandler.Car car = new CarHandler.Car(brand, make,pYear,color);
            bool notStarted = true;
            int startAttempt = 0;
            while (notStarted)
            {
                if (car.StartCar())
                {
                    startAttempt++;
                    notStarted = false;
                }
                else
                {
                    startAttempt++;
                }
            }
            Console.WriteLine($"{car.ToString()} brugte {startAttempt} forsøg for at starte.");
            return car;
        }

        public static void BrandSearch(List<CarHandler.Car> list)
        {
            Console.WriteLine("Indtast mærke:");
            string brand = Console.ReadLine();
            List<CarHandler.Car> searchResult = list.FindAll(
               delegate (CarHandler.Car car)
               {
                   return car.Make.ToLower() == brand.ToLower();
               });

            foreach (var car in searchResult)
            {
                Console.WriteLine(car.GetInfo());
            }
            Console.WriteLine("tryk enter for at komme tilbage til menuen");
            Console.ReadLine();
        }


    }
}
