using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        var users = new SortedDictionary<string, Dictionary<string, int>>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            var details = input.Split().Select(x=>x.Split('=')[1]).ToList();
            string ip = details[0];
            string user = details[2];
            if (!users.ContainsKey(user))
            {
                users[user] = new Dictionary<string, int>();

            }
            if (!users[user].ContainsKey(ip))
            {
                users[user][ip] = 1;
            }
            else
            {
                users[user][ip]++;
            }
            input = Console.ReadLine();
        }
        var stats = new List<string>();
        foreach (var user in users.Keys)
        {
            Console.WriteLine($"{user}: ");
            foreach (var ip in users[user].Keys)
            {
               stats.Add(ip + " => " + users[user][ip]);
            }
            Console.WriteLine(string.Join(", ", stats) + ".");
            stats = new List<string>();
        }
    }
}
