using System;
using System.IO;

namespace MortenJuulS1.Writing.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\test\";
            Log logBook = new Log(path);


            while (true)
            {
                Console.WriteLine("Indtast file navn:");
                string fileName = Console.ReadLine();

                if (!CheckfileExists(path, fileName))
                {
                    Console.WriteLine("Indtast din log line:");
                    string logentry = Console.ReadLine();
                    logBook.WriteLine(path + fileName + ".txt", logentry);
                }
                else
                {
                    Console.WriteLine("der er allerede en fil med det navn");
                }
            }
        }


        private static bool CheckfileExists(string path, string fileName)
        {
            string combine = path + fileName + ".txt";
            return File.Exists(combine);
        }
    }
}
