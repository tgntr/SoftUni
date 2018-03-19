using System;
using System.Linq;

public class Startup
{
    static void Main(string[] args)
    {
        var draft = new DraftManager();
        while (true)
        {
            var input = Console.ReadLine().Split();

            var command = input[0];

            var details = input.Skip(1).ToList();

            if (command == "Shutdown")
            {
                Console.WriteLine(draft.ShutDown());
                return;
            }
            else if (command == "RegisterHarvester")
            {
                Console.WriteLine(draft.RegisterHarvester(details));
            }
            else if(command == "RegisterProvider")
            {
                Console.WriteLine(draft.RegisterProvider(details));
            }
            else if(command == "Day")
            {
                Console.WriteLine(draft.Day());
            }
            else if(command == "Mode")
            {
                Console.WriteLine(draft.Mode(details));
            }
            else if(command == "Check")
            {
                Console.WriteLine(draft.Check(details));
            }
        }
    }
}
