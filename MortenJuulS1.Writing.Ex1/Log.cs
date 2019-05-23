using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MortenJuulS1.Writing.Ex1
{
    enum LogType
    {
        Message,
        Critical,
        Warning
    }
    class Log
    {
        private string filePath;

        public string FilePath { get => filePath; set => filePath = value; }


        public Log(string filepath)
        {
            FilePath = filepath;
        }

        //public void WriteLine(int errorCode)
        //{
        //    string outputMessage = $"Fejl {errorCode}: Vær forsigtig!!";
        //    WriteLine(outputMessage, LogType.Critical);
        //}

        public void WriteLine( string message)
        {
            //if (logType == LogType.Critical)
            //{
            //    message = message.ToUpper();
            //}
            using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.Default))
            {
                writer.WriteLine(DateTime.Now +": " + message);
            }
        }
    }
}
