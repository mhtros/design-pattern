using System.Text.Json;

namespace Prototype.Models;

public class Person : ICloneable<Person>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public Address? Address { get; set; }

    public Person Clone()
    {
        return new Person
        {
            FirstName = FirstName,
            LastName = LastName,
            Age = Age,
            Address = Address?.Clone()
        };
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}