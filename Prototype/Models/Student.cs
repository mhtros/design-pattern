using System.Text.Json;

namespace Prototype.Models;

public sealed class Student : Person, ICloneable<Student>
{
    public string StudentId { get; set; } = string.Empty;

    public new Student Clone()
    {
        return new Student
        {
            FirstName = FirstName,
            LastName = LastName,
            Age = Age,
            StudentId = StudentId,
            Address = Address?.Clone()
        };
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}