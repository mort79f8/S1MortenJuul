using System;

namespace MortenJuulS1.Classes.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Make = "Davia", Model = "Logan", Color = "Beige", Price = 170000, IsSold = false };
            Car car2 = new Car() { Make = "Toyota", Model = "Yaris", Color = "Rød", Price = 89000, IsSold = true };

            car1.PrintInfo();
            car2.PrintInfo();

            Car myCar = new Car("Honda", "Civic", "Hvid", 199000, false);

            myCar.PrintInfo();

            Console.WriteLine(myCar);
            myCar.PutOnSale();
            myCar.PrintInfo();
            myCar.PutOnSale();
            myCar.PrintInfo();

        }
    }
}
