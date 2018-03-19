using System;
using System.Linq;

public class Song
{
    private string artist;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string input)
    {
        var details = input.Split(";");

        ValidateSong(details);

        Artist = details[0];

        SongName = details[1];

        var length = details[2].Split(":");
        ValidateLength(length);

        Minutes = int.Parse(length[0]);

        Seconds = int.Parse(length[1]);
    }

    private void ValidateSong(string[] details)
    {
        if (details.Length != 3)
        {
            throw new InvalidSongException("Invalid song.");
        }
    }

    private static void ValidateLength(string[] length)
    {
        

        if (length.Length != 2 || !int.TryParse(length[0], out int n) || !int.TryParse(length[1], out int s))
        {
            throw new InvalidSongLengthException("Invalid song length.");
        }
    }

    public string Artist
    {
        get
        {
            return artist;
        }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
            }
            artist = value;
        }
    }

    public string SongName
    {
        get
        {
            return songName;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
            }
            minutes = value;
        }
    }


    public int Seconds
    {
        get
        {
            return seconds;
        }
        set
        {
            if (value < 0 || value >= 60)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }
            seconds = value;
        }
    }


}
