using System.Text.Json;

namespace Bridge;

public class Tv : IDevice
{
    public Tv()
    {
        CurrentChannel = Channels[0];
    }

    public string[] Channels { get; } = {"MEGA", "START", "ANT1", "ERT1"};

    public int Volume { get; set; } = 0;

    public string CurrentChannel { get; private set; }
    public bool IsActive { get; private set; }

    public void SetChannel(int number)
    {
        CurrentChannel = Channels[number];
    }

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