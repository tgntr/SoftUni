using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        string input = Console.ReadLine();
        var countries = new Dictionary<string, Dictionary<string, decimal>>();
        while (input != "report")
        {
            string country = input.Split('|')[1];
            string town = input.Split('|')[0];
            decimal population = decimal.Parse(input.Split('|')[2]);
            if (!countries.ContainsKey(country))
            {
                countries[country] = new Dictionary<string, decimal>();
            }
            countries[country][town] = population;
            input = Console.ReadLine();
        }
        foreach (var country in countries.Keys.OrderByDescending(x=>countries[x].Values.Sum()))
        {
            decimal totalPopulation = countries[country].Values.Sum();
            Console.WriteLine($"{country} (total population: {totalPopulation})");
            foreach (var town in countries[country].Keys.OrderByDescending(x => countries[country][x]))
            {
                Console.WriteLine($"=>{town}: {countries[country][town]}");
            }
        }
    }
}
