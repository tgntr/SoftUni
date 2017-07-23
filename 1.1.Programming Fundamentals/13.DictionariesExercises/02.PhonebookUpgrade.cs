using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade
{
    static void Main()
    {
        var parameters = Console.ReadLine().Split().ToList();
        string command = parameters[0];
        var contacts = new SortedDictionary<string, string>();
        while (command != "END")
        {           
            if (command == "A")
            {
                string contactName = parameters[1];
                contacts[contactName] = parameters[2];
            }
            else if (command == "S")
            {
                string contactName = parameters[1];
                if (!contacts.ContainsKey(contactName))
                {
                    Console.WriteLine($"Contact {contactName} does not exist.");
                }
                else
                {
                    Console.WriteLine($"{contactName} -> {contacts[contactName]}");
                }
            }
            else if(command=="ListAll")
            {
                foreach (var contact in contacts.Keys)
                {
                    Console.WriteLine($"{contact} -> {contacts[contact]}");
                }
            }
            parameters = Console.ReadLine().Split().ToList();
            command = parameters[0];
        }
    }
}
