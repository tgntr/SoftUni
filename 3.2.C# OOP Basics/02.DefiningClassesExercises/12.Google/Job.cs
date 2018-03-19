public class Job
{
    public string Company { get; set; }

    public string Department { get; set; }

    public string Salary { get; set; }

    public Job()
    {
        Company = "";

        Department = "";

        Salary = "";
    }

    public Job(string company, string department, decimal salary)
    {
        Company = company;

        Department = department;

        Salary = salary.ToString("F2");
    }

    public override string ToString()
    {
        if (Company == "")
            return "";
        return $"\n{Company} {Department} {Salary}";
    }
}
