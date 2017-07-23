using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        var parameters = Console.ReadLine().Split().ToList();
        var contacts = new Dictionary<string, string>();
        while (parameters[0] != "END")
        {
            string contactName = parameters[1];

            if (parameters[0] == "A")
            {
                contacts[contactName] = parameters[2];
            }
            else if (parameters[0] == "S")
            {
                if (!contacts.ContainsKey(contactName))
                {
                    Console.WriteLine($"Contact {contactName} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{contactName} -> {contacts[contactName]}");
                }
            }
            parameters = Console.ReadLine().Split().ToList();
        }
    }
}
