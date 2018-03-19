using System;

public class Startup
{
    static void Main(string[] args)
    {
        var manager = new CarManager();

        var input = "";

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            var details = input.Split();

            var command = details[0];

            var id = int.Parse(details[1]);

            if (command == "register")
            {
                var type = details[2];

                var brand = details[3];

                var model = details[4];

                var year = int.Parse(details[5]);

                var hp = int.Parse(details[6]);

                var acc = int.Parse(details[7]);

                var sus = int.Parse(details[8]);

                var dur = int.Parse(details[9]);

                manager.Register(id, type, brand, model, year, hp, acc, sus, dur);
            }

            else if (command == "check")
            {
                Console.WriteLine(manager.Check(id));
            }

            else if (command == "open")
            {
                var type = details[2];

                var length = int.Parse(details[3]);

                var route = details[4];

                var prize = int.Parse(details[5]);

                if (details.Length > 6)
                {
                    var param = int.Parse(details[6]);

                    manager.Open(id, type, length, route, prize, param);
                }
                else
                {
                    manager.Open(id, type, length, route, prize);
                }
            }

            else if(command == "participate")
            {
                var raceId = int.Parse(details[2]);

                manager.Participate(id, raceId);
            }

            else if (command == "start")
            {
                Console.WriteLine(manager.Start(id));
            }

            else if (command == "park")
            {
                manager.Park(id);
            }

            else if (command == "unpark")
            {
                manager.Unpark(id);
            }

            else if (command == "tune")
            {
                var addOn = details[2];

                manager.Tune(id, addOn);


            }
        }

    }
}
