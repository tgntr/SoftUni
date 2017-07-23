using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class Data
    {
        public string FirstQuery { get; set; }
        public string SecondQuery { get; set; }
    }
    class Program
    {
        // used regex to catch situations with whitespaces, cuz they say "May consist any ASCII character"
        static void Main()
        {
            var messages = new List<Data>();
            var broadcasts = new List<Data>();
            var broadcastPattern = new Regex(@"^([^\d]+) <-> ([0-9a-zA-Z]+)$");
            var messagePattern = new Regex(@"^([\d]+) <-> ([0-9a-zA-Z]+)$");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                if (broadcastPattern.IsMatch(input))
                {
                    var match = broadcastPattern.Match(input);
                    broadcasts.Add(new Data { FirstQuery = match.Groups[1].Value.ToString(), SecondQuery = match.Groups[2].Value.ToString() });
                }
                else if (messagePattern.IsMatch(input))
                {
                    var match = messagePattern.Match(input);

                    messages.Add(new Data { FirstQuery = match.Groups[1].Value.ToString(), SecondQuery = match.Groups[2].Value.ToString() });
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    broadcast.SecondQuery = DecryptBroadcast(broadcast.SecondQuery);
                    Console.WriteLine($"{broadcast.SecondQuery} -> {broadcast.FirstQuery}");
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    message.FirstQuery = string.Join("", message.FirstQuery.ToCharArray().Reverse());
                    Console.WriteLine($"{message.FirstQuery} -> {message.SecondQuery}");
                }
            }
        }
        static string DecryptBroadcast(string input)
        {
            var elements = input.ToCharArray();
            for (int i = 0; i < elements.Length; i++)
            {
                if (Char.IsLetter(elements[i]))
                {

                    if (Char.IsUpper(elements[i]))
                    {
                        elements[i] = Char.ToLower(elements[i]);
                    }
                    else
                    {
                        elements[i] = Char.ToUpper(elements[i]);
                    }
                }
            }
            return string.Join("", elements);
        }
    }
}
