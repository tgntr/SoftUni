using System;
using System.Collections.Generic;
using System.Linq;

class Hospital
{
    static void Main()
    {
        var patients = new List<Patient>();
        string input;
        while ((input = Console.ReadLine()) != "Output")
        {
            var patient = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (patients.Where(p=>p.Department == patient[0]).ToArray().Length < 60)
            {
                var patientDetals = new Patient
                {
                    Department = patient[0],
                    Doctor = patient[1] + " " + patient[2],
                    Name = patient[3]
                };
                patients.Add(patientDetals);
            }
        }
        while ((input = Console.ReadLine()) != "End")
        {
            var requestedInfo = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (requestedInfo.Length == 1)
            {
                patients
                    .Where(p => p.Department == requestedInfo[0])
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.Name));
            }
            else if (int.TryParse(requestedInfo[1], out int room))
            {
                var startIndex = (room - 1) * 3;
                var departmentPatients = patients
                    .Where(p => p.Department == requestedInfo[0])
                    .ToArray();
                var roomPatients = new List<Patient>();
                for (int i = startIndex; i < room * 3; i++)
                {
                    if (departmentPatients.Length <= i)
                        break;
                    roomPatients.Add(departmentPatients[i]);
                }
                roomPatients
                    .OrderBy(p => p.Name)
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.Name));
            } 
            else
            {
                patients
                    .Where(p => p.Doctor == requestedInfo[0] + " " + requestedInfo[1])
                    .OrderBy(p=>p.Name)
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.Name));
            }
        }
    }

    class Patient
    {
        public string Department { get; set; }
        public string Doctor { get; set; }
        public string Name { get; set; }
    }
}
