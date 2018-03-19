using System;

internal class FactionFactory
{

    internal static Faction CreateFaction(string name)
    {
        if (name != "Java" && name != "CSharp")
        {
            throw new ArgumentException($"Invalid faction \"{name}\"!");
            
        }
        return (Faction)Enum.Parse(typeof(Faction), name);
    }
}