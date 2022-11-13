namespace Strategy.SortAlgorithms;

public interface ISortAlgorithm
{
    public void Sort<T>(IList<T> list) where T : IComparable;
}