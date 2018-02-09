using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ParkingSystem
{
    class ParkingSystem
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = rowsCols[0];
            var cols = rowsCols[1];
            var busySpots = new Dictionary<int, List<int>>();

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                var parkAttempt = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var entry = parkAttempt[0];
                var row = parkAttempt[1];
                var col = parkAttempt[2];

                if (!busySpots.ContainsKey(row))
                    busySpots[row] = new List<int>();

                if (busySpots[row].Contains(col))
                {
                    var closestSpot = 0;
                    var closestDistance = int.MaxValue;
                    for (int currentSpot = 1; currentSpot < cols; currentSpot++)
                    {
                        var currentDistance = Math.Abs(currentSpot - col);
                        if (!busySpots[row].Contains(currentSpot) && currentDistance < closestDistance)
                        {
                            closestDistance = currentDistance;
                            closestSpot = currentSpot;
                        }
                    }
                    if (closestSpot > 0)
                        col = closestSpot;
                    else
                        col = 0;
                }
                if (col == 0)
                    Console.WriteLine($"Row {row} full");
                else
                {
                    busySpots[row].Add(col);
                    var distance = Math.Abs(row - entry) + col + 1;
                    Console.WriteLine(distance);
                }
            }
        }
    }
}
