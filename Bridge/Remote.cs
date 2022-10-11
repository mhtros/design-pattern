namespace Bridge;

public sealed class Remote
{
    private readonly IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }

    public void VolumeUp()
    {
        _device.Volume++;
    }

    public void VolumeDown()
    {
        _device.Volume--;
    }

    public void TogglePower()
    {
        if (_device.IsActive) _device.PowerOff();
        else _device.PowerOn();
    }

    public void ChannelUp()
    {
        var index = Array.IndexOf(_device.Channels, _device.CurrentChannel) + 1;
        if (index > _device.Channels.Length - 1) index = 0;
        _device.SetChannel(index);
    }

    public void ChannelDown()
    {
        var index = Array.IndexOf(_device.Channels, _device.CurrentChannel) - 1;
        if (index < 0) index = _device.Channels.Length - 1;
        _device.SetChannel(index);
    }
}