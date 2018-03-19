class RaceFactory
{
    public static Race CreateRace (string type, int length, string route, int prizePool)
    {
        if (type == "Casual")
        {
            return new CasualRace(length, route, prizePool);
        }
        else if (type == "Drag")
        {
            return new DragRace(length, route, prizePool);
        }
        else if (type == "TimeLimit")
        {
            
        }
        return new DriftRace(length, route, prizePool);
    }

    public static Race CreateRace(string type, int length, string route, int prizePool, int parameter)
    {
        if (type == "TimeLimit")
        {
            return new TimeLimitRace(length, route, prizePool, parameter);
        }
        return new CircuitRace(length, route, prizePool, parameter);
    }
}