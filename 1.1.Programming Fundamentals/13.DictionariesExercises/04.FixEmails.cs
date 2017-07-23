using System;
using System.Collections.Generic;
using System.Linq;

class FixEmails
{
    static void Main()
    {
        var resources = new Dictionary<string, string>();
        string input = Console.ReadLine();
        string name = "";
        string email = "";
        int inputCount = 1;
        while (input != "stop")
        {
            if (inputCount % 2 == 1)
            {
                name = input;
            }
            else
            {
                email = input;
                var getDomain = input.ToLower().Split('.').ToList();
                string domain = getDomain[getDomain.Count - 1];
                bool validDomain = domain != "us" && domain != "uk";
                if (validDomain)
                {
                    resources[name] = email;
                }
            }
            input = Console.ReadLine();
            inputCount++;
        }
        foreach (var metal in resources.Keys)
        {
            Console.WriteLine($"{metal} -> {resources[metal]}");
        }
    }
}
