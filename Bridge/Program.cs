using Bridge;

var tv = new Tv();
var radio = new Radio();

var tvRemote = new Remote(tv);
var radioRemote = new Remote(radio);

Console.WriteLine(tv);
Console.WriteLine(radio);

tvRemote.TogglePower();
radioRemote.TogglePower();

tvRemote.VolumeUp();
tvRemote.VolumeUp();
tvRemote.VolumeUp();
tvRemote.VolumeDown();

radioRemote.VolumeUp();
radioRemote.VolumeUp();
radioRemote.VolumeUp();
radioRemote.VolumeDown();

tvRemote.ChannelDown();
tvRemote.ChannelDown();
tvRemote.ChannelDown();

radioRemote.ChannelUp();
radioRemote.ChannelUp();
radioRemote.ChannelUp();
radioRemote.ChannelUp();
radioRemote.ChannelUp();

Console.WriteLine("\n");

Console.WriteLine(tv);
Console.WriteLine(radio);