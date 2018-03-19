using System;

public class InvalidSongException 
    : Exception
{
    public InvalidSongException()
        :base()
    {

    }

    public InvalidSongException(string message)
        : base(message)
    {

    }
}

public class InvalidArtistNameException
    : Exception
{
    public InvalidArtistNameException()
        :base()
    {

    }

    public InvalidArtistNameException(string message)
        : base(message)
    {

    }
}

public class InvalidSongNameException
    : Exception
{
    public InvalidSongNameException()
        :base()
    {

    }

    public InvalidSongNameException(string message)
        : base(message)
    {

    }
}

public class InvalidSongLengthException
    : Exception
{
    public InvalidSongLengthException()
        :base()
    {

    }

    public InvalidSongLengthException(string message)
        : base(message)
    {

    }
}

public class InvalidSongMinutesException
    : Exception
{
    public InvalidSongMinutesException()
        :base()
    {

    }

    public InvalidSongMinutesException(string message)
        : base(message)
    {

    }
}

public class InvalidSongSecondsException
    : Exception
{
    public InvalidSongSecondsException()
        :base()
    {

    }

    public InvalidSongSecondsException(string message)
        : base(message)
    {

    }
}
