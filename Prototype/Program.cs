using Prototype.Models;

Student student = new()
{
    StudentId = Guid.NewGuid().ToString(),
    FirstName = "John",
    LastName = "Doe",
    Age = 33,
    Address = new Address
    {
        District = "Old Cey",
        Number = 420,
        Street = "Blue Raspberry",
        PostCode = "1938 95"
    }
};

var studentClone = student.Clone();
student.Age = 88;

Console.WriteLine(student);
Console.WriteLine(studentClone);