using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator
{
    static void Main()
    {
        var users = new SortedDictionary<string, SortedDictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string log = Console.ReadLine();
            string ip = log.Split()[0];
            string user = log.Split()[1];
            int duration = int.Parse(log.Split()[2]);
            if (!users.ContainsKey(user))
            {
                users[user] = new SortedDictionary<string, int>();
            }
            if(!users[user].ContainsKey(ip))
            {
                users[user][ip] = duration;
            }
            else
            {
                users[user][ip] += duration;
            }
        }
        foreach (var user in users.Keys)
        {
            int totalDuration = users[user].Values.Sum();
            var ipList = string.Join(", ", users[user].Keys.Distinct().ToList());
            Console.WriteLine($"{user}: {totalDuration} [{ipList}]");
        }
    }
}
