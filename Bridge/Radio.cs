using System.Text.Json;

namespace Bridge;

public class Radio : IDevice
{
    public Radio()
    {
        CurrentChannel = Channels[0];
    }

    public string[] Channels { get; } = {"SOK", "ENERGY", "RED", "ROCK"};

    public int Volume { get; set; } = 0;

    public string CurrentChannel { get; private set; }


    public void SetChannel(int number)
    {
        CurrentChannel = Channels[number];
    }

    public bool IsActive { get; private set; }

    public void PowerOff()
    {
        IsActive = false;
    }

    public void PowerOn()
    {
        IsActive = true;
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}