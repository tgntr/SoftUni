using System;
using System.Collections.Generic;
using System.Linq;

class ParkingValidation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var database = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().ToList();
            var command = input[0];
            var user = input[1];
            if (command == "register")
            {
                var licenseNumber = input[2];
                bool licenseIsValid = LicensePlateValidation(licenseNumber);
                if (!database.ContainsKey(user))
                {
                    if (licenseIsValid)
                    {
                        if (!database.ContainsValue(licenseNumber))
                        {
                            Console.WriteLine($"{user} registered {licenseNumber} successfully");
                            database[user] = licenseNumber;
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: license plate {licenseNumber} is busy");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseNumber}");
                    }
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {database[user]}");
                }
            }
            else
            {
                if (database.ContainsKey(user))
                {
                    Console.WriteLine($"user {user} unregistered successfully");
                    database.Remove(user);
                }
                else
                {
                    Console.WriteLine($"ERROR: user {user} not found");
                }
            }
        }
        foreach (var user in database.Keys)
        {
            Console.WriteLine($"{user} => {database[user]}");
        }
    }
    static bool LicensePlateValidation(string licenseNumber)
    {
        bool isValid = true;
        if (licenseNumber.Length != 8)
        {
            isValid = false;
            return isValid;
        }
        var characters = licenseNumber.ToCharArray();
        var left = characters[0] + "" + characters[1];
        var numbers = characters[2] + "" + characters[3] + "" + characters[4] + "" + characters[5];
        var right = characters[6] + "" + characters[7];
        var checkIfLetters = !left.Any(char.IsDigit) && !right.Any(char.IsDigit);
        var checkIfUpper =  left == left.ToUpper() && right == right.ToUpper();
        if (!checkIfLetters || !checkIfUpper)
        {
            isValid = false;
            return isValid;
        }
        var checkNumbers = numbers.All(char.IsDigit);
        if (!checkNumbers)
        {
            isValid = false;
            return isValid;
        }
        return isValid;
    }
}
