using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Classes.Ex2
{
    class Car
    {
        private string make;
        private string model;
        private string color;
        private int price;
        private bool isSold;
        private bool isOnSale;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
        public bool IsSold { get => isSold; set => isSold = value; }
        public bool IsOnSale { get => isOnSale; set => isOnSale = value; }

        public void PrintInfo()
        {
            if (IsSold)
            {
                Console.WriteLine($"SOLGT! Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
            else
            {
                Console.WriteLine($"Bilen er en {Make} {Model} i farven {Color}. Prisen er {Price} DKK.");
            }
        }

        public Car()
        {

        }
        public Car(string Make, string Model, string Color, int Price, bool IsSold)
        {
            make = Make;
            model = Model;
            color = Color;
            price = Price;
            isSold = IsSold;
            isOnSale = false;
        }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }

        public void PutOnSale()
        {
            if (!IsOnSale)
            {
                IsOnSale = true;
                Price = Convert.ToInt32(Price - (Price * 0.1));
            }
        }

    }
}
