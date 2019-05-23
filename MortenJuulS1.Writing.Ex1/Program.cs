using System;
using System.IO;

namespace MortenJuulS1.Writing.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\test\";



            while (true)
            {
                Console.WriteLine("Indtast file navn (/exit for at afslutte):");
                string fileName = Console.ReadLine();

                if (!CheckfileExists(path, fileName))
                {
                    Log logBook = new Log(path + fileName + ".txt");
                    if (fileName == "/exit")
                    {
                        System.Environment.Exit(0);
                    }
                    bool writingLog = true;
                    Console.Clear();
                    while (writingLog)
                    {
                        Console.WriteLine("Indtast din log line (/end for at stoppe med at skriv til loggen):");
                        string logentry = Console.ReadLine();

                        if (logentry != "/end")
                        {
                            logBook.WriteLine(logentry);
                        }
                        else
                        {
                            writingLog = false;
                        }
                    }
                    Console.Clear();
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
