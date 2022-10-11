namespace Bridge;

public interface IDevice
{
    public string[] Channels { get; }

    public int Volume { get; set; }

    public string CurrentChannel { get; }

    public bool IsActive { get; }

    public void SetChannel(int number);

    public void PowerOff();

    public void PowerOn();
}