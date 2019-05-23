using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MortenJuulS1.Writing.Ex1
{
    class Log
    {
        private string filePath;

        public string FilePath { get => filePath; set => filePath = value; }

        public Log(string filepath)
        {
            FilePath = filepath;
        }

        public void WriteLine(string pathToFile, string message)
        {
            using (StreamWriter writer = new StreamWriter(pathToFile, false, Encoding.Default))
            {
                writer.WriteLine(DateTime.Now +": " + message);
            }
        }
    }
}
