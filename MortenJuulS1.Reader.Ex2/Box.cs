using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Reader.Ex2
{
    class Box
    {
        private int length;
        private int width;
        private int height;
        private int volume;
        private int surface;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Volume { get => volume; set => volume = value; }
        public int Surface { get => surface; set => surface = value; }


        public Box()
        {

        }
        public Box(int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;

        }
        public void PrintInfo()
        {
            Console.WriteLine("Kassen har følgende mål");
            Console.WriteLine($"Højde:\t\t{Height}");
            Console.WriteLine($"Længde:\t\t{Length}");
            Console.WriteLine($"Bredde:\t\t{Width}");
            CalculateVolume();
            CalculateSurface();
        }

        public void CalculateVolume()
        {
            Volume = Length * Height * Width;
            Console.WriteLine($"Rumfang:\t{Volume}");
        }

        private void CalculateSurface()
        {
            Surface = (2 * Length) + (2 * Height) + (2 * Width);
            Console.WriteLine($"Overflade:\t{Surface}");
        }
    }
}
