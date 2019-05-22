using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Classes2.Ex2
{
    class Movie
    {
        private string titel;
        private string instructor;
        private string leadingActor;
        private int lenght;


        public string Titel { get => titel; set => titel = value; }
        public string Instructor { get => instructor; set => instructor = value; }
        public string LeadingActor { get => leadingActor; set => leadingActor = value; }
        public int Lenght { get => lenght; set => lenght = value; }

        public Movie(string titel, string instructor, string leadingActor, int length)
        {
            Titel = titel;
            Instructor = instructor;
            LeadingActor = leadingActor;
            Lenght = length;
        }

        public string GetLenghtInHoursAndMinutes()
        {
            TimeSpan time = TimeSpan.FromMinutes(Lenght);
            return time.ToString(@"hh\:mm");

        }

        public override string ToString()
        {
            return $"{Titel} ({Lenght} min.)";
        }
    }
}
