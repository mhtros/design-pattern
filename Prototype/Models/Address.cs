using System.Text.Json;

namespace Prototype.Models;

public class Address : ICloneable<Address>
{
    public string Street { get; set; } = string.Empty;
    public string PostCode { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public ushort Number { get; set; }

    public Address Clone()
    {
        return new Address
        {
            PostCode = PostCode,
            District = District,
            Number = Number,
            Street = Street
        };
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}