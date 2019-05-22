using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MortenJuulS1.Classes2.Ex3;

namespace MortenJuulS1.Classes2.Ex4
{
    class Playlist
    {
        private string name;
        private List<Ex3.Track> tracks;

        public string Name { get => name; set => name = value; }
        internal List<Track> Tracks { get => tracks; set => tracks = value; }


        public Playlist(string name, List<Track> tracks)
        {
            Name = name;
            Tracks = tracks;
        }

        public int CalculateLengthOfPlaylist()
        {
            int result = 0;
            foreach (var track in Tracks)
            {
                result = result + track.LenghtInSeconds();
            }
            return result;
        }

        public Track FindShortestTrack()
        {
            int shortest = Tracks[0].LenghtInSeconds();
            Track theTrack = Tracks[0];
            foreach (var track in Tracks)
            {
                if (shortest > track.LenghtInSeconds())
                {
                    shortest = track.LenghtInSeconds();
                    theTrack = track;
                }
            }
            return theTrack;
        }

        public override string ToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(CalculateLengthOfPlaylist());
            return $"{Name} indeholder {Tracks.Count} sange, Hvilken varer: {time.ToString(@"mm\:ss")}";
        }

    }
}
