using System;
using System.Collections.Generic;
using System.Linq;

class Files
{
    static void Main()
    {
        //learned for String.EndsWith and to not use Regex or Classes if not needed
        var n = int.Parse(Console.ReadLine());
        var roots = new Dictionary<string, Dictionary<string, long>>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Trim().Split('\\').Select(x => x.Trim()).ToList();
            var root = input[0];
            var fileAndSize = input.Last().Split(';').Select(x => x.Trim()).ToArray();
            var fileName = fileAndSize[0];
            var size = long.Parse(fileAndSize[1]);
            if (!roots.ContainsKey(root))
            {
                roots[root] = new Dictionary<string, long>();
            }
            roots[root][fileName] = size; 
        }
        var inputOutput = Console.ReadLine().Split();
        var format = inputOutput[0];
        var inRoot = inputOutput[2];
        if (!roots.ContainsKey(inRoot) || !roots[inRoot].Keys.Any(x=>x.EndsWith(format)))
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (var file in roots[inRoot].Keys
                .Where(x=>x.EndsWith(format))
                .OrderByDescending(x=>roots[inRoot][x])
                .ThenBy(x=>x))
            {
                Console.WriteLine($"{file} - {roots[inRoot][file]} KB");
            }
        }
    }
}
