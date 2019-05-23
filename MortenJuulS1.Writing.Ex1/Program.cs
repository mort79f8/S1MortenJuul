using System;
using System.IO;

namespace MortenJuulS1.Writing.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\S1\Code\S1MortenJuul\MortenJuulS1.Writing.Ex1\";

            Console.WriteLine("Indtast file navn:");
            string fileName = Console.ReadLine();
            if (CheckfileExists(path,fileName))
            {
                Console.WriteLine($"der er en file som hedder: {fileName}");
            }
            else
            {
                Console.WriteLine($"Kan ikke finde en file som hedder: {fileName}");
            }
        }


        private static bool CheckfileExists(string path, string fileName)
        {
            string combine = path + fileName + ".txt";
            return File.Exists(combine);
        }
    }
}
