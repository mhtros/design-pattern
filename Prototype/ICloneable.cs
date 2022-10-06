namespace Prototype;

public interface ICloneable<out T> where T : class
{
    public T Clone();
}