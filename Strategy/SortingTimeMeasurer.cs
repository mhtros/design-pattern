using Strategy.SortAlgorithms;

namespace Strategy;

public class SortingTimeMeasurer
{
    public SortingTimeMeasurer(ISortAlgorithm? sortAlgorithm = null)
    {
        SortAlgorithm = sortAlgorithm;
    }

    public ISortAlgorithm? SortAlgorithm { private get; set; }


    public void Measure<T>(IList<T> list) where T : IComparable
    {
        if (SortAlgorithm is null) return;

        var watch = System.Diagnostics.Stopwatch.StartNew();
        SortAlgorithm.Sort(list);
        watch.Stop();

        var elapsedMs = watch.ElapsedMilliseconds;

        Console.WriteLine($"Execution time ({elapsedMs}ms)");
    }
}