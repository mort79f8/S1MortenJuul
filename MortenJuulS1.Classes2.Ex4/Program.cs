using MortenJuulS1.Classes2.Ex3;
using System;
using System.Collections.Generic;

namespace MortenJuulS1.Classes2.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Track track1 = new Track("Beatles", "Yesterday", 2, 5);
            Track track2 = new Track("Pentatonix", "Can't hold us", 3, 19);
            Track track3 = new Track("Alan Walker", "All Falls Down", 3, 20);
            List<Track> tracks = new List<Track>() { track1, track2, track3};
            Playlist album = new Playlist("nået musik", tracks);

            Console.WriteLine(album.ToString());
            Console.WriteLine(album.FindShortestTrack());

        }
    }
}
