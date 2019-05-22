using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Classes2.Ex3
{
    class Track
    {
        private string artist;
        private string title;
        private int minutes;
        private int seconds;

        public string Artist { get => artist; set => artist = value; }
        public string Title { get => title; set => title = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Seconds { get => seconds; set => seconds = value; }

        public Track(string artist, string title, int minutes, int seconds)
        {
            Artist = artist;
            Title = title;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int LenghtInSeconds()
        {
            return (Minutes * 60) + Seconds;
        }

        public override string ToString()
        {
            var time = TimeSpan.FromSeconds(LenghtInSeconds());
            string converted = time.ToString(@"m\:ss");
            return $"{Title}: {Artist} ({converted})";
        }
    }
}
