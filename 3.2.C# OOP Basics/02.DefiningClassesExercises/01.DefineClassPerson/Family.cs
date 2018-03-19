using System.Collections.Generic;
using System.Linq;

public class Family
{
    List<Person> Members = new List<Person>();

    public void AddMember(Person person)
    {
        Members.Add(person);
    }

    public Person GetOldestMember()
    {
        return Members.OrderByDescending(p => p.Age).First();
    }
}
