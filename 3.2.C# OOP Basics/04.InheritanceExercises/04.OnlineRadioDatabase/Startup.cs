using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();

            try
            {
                songs.Add(new Song(input));
                Console.WriteLine("Song added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        var playlistLength = songs.Sum(s => (s.Minutes * 60) + s.Seconds);
        var hours = playlistLength / 60 / 60;
        var minutes = playlistLength / 60 % 60;
        var seconds = playlistLength % 60;
        Console.WriteLine($"Songs added: {songs.Count}\nPlaylist length: {hours}h {minutes}m {seconds}s");
    }
}
