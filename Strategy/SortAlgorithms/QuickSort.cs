// This implementation was taken form https://rosettacode.org/

using System.Diagnostics;

namespace Strategy.SortAlgorithms;

public class QuickSort<T> : ISortAlgorithm where T : IComparable
{
    #region Constants

    private const uint InsertionLimitDefault = 12;
    private const int SamplesMax = 19;

    #endregion

    #region Properties

    private uint InsertionLimit { get; }
    private T[] Samples { get; }
    private int Left { get; set; }
    private int Right { get; set; }
    private int LeftMedian { get; set; }
    private int RightMedian { get; set; }

    #endregion

    #region Constructors

    public QuickSort(uint insertionLimit = InsertionLimitDefault)
    {
        InsertionLimit = insertionLimit;
        Samples = new T[SamplesMax];
    }

    #endregion

    #region Sort Methods

    public void Sort<T1>(IList<T1> entries) where T1 : IComparable
    {
        Sort(entries as IList<T> ?? Array.Empty<T>(), 0, entries.Count - 1);
    }

    private void Sort(IList<T> entries, int first, int last)
    {
        var length = last + 1 - first;

        while (length > 1)
        {
            if (length < InsertionLimit)
            {
                InsertionSort.Sort(entries, first, last);
                return;
            }

            Left = first;
            Right = last;
            var median = Pivot(entries);
            Partition(median, entries);
            //[Note]Right < Left

            var leftLength = Right + 1 - first;
            var rightLength = last + 1 - Left;

            //
            // First recurse over shorter partition, then loop
            // on the longer partition to elide tail recursion.
            //
            if (leftLength < rightLength)
            {
                Sort(entries, first, Right);
                first = Left;
                length = rightLength;
            }
            else
            {
                Sort(entries, Left, last);
                last = Right;
                length = leftLength;
            }
        }
    }

    /// <summary>Return an odd sample size proportional to the log of a large interval size.</summary>
    private static int SampleSize(int length, int max = SamplesMax)
    {
        var logLen = (int) Math.Log10(length);
        var samples = Math.Min(2 * logLen + 1, max);
        return Math.Min(samples, length);
    }

    /// <summary>Estimate the median value of entries[Left:Right]</summary>
    /// <remarks>A sample median is used as an estimate the true median.</remarks>
    private T Pivot(IList<T> entries)
    {
        var length = Right + 1 - Left;
        var samples = SampleSize(length);

        // Sample Linearly:
        for (var sample = 0; sample < samples; sample++)
        {
            // Guard against Arithmetic Overflow:
            var index = (long) length * sample / samples + Left;
            Samples[sample] = entries[(int) index];
        }

        InsertionSort.Sort(Samples, 0, samples - 1);
        return Samples[samples / 2];
    }

    private void Partition(T median, IList<T> entries)
    {
        int first;
        int last;

#if Tripartite
      LeftMedian = first;
      RightMedian = last;
#endif

        while (true)
        {
            //[Assert]There exists some index >= Left where entries[index] >= median
            //[Assert]There exists some index <= Right where entries[index] <= median
            // So, there is no need for Left or Right bound checks
            while (median.CompareTo(entries[Left]) > 0) Left++;
            while (median.CompareTo(entries[Right]) < 0) Right--;

            //[Assert]entries[Right] <= median <= entries[Left]
            if (Right <= Left) break;

            Swap(entries, Left, Right);
            SwapOut(median, entries);
            Left++;
            Right--;
            //[Assert]entries[first:Left - 1] <= median <= entries[Right + 1:last]
        }

        if (Left == Right)
        {
            Left++;
            Right--;
        }

        //[Assert]Right < Left
        SwapIn(entries, first, last);

        //[Assert]entries[first:Right] <= median <= entries[Left:last]
        //[Assert]entries[Right + 1:Left - 1] == median when non-empty
    }

    #endregion

    #region Swap Methods

    [Conditional("Tripartite")]
    private void SwapOut(T median, IList<T> entries)
    {
        if (median.CompareTo(entries[Left]) == 0) Swap(entries, LeftMedian++, Left);
        if (median.CompareTo(entries[Right]) == 0) Swap(entries, Right, RightMedian--);
    }

    [Conditional("Tripartite")]
    private void SwapIn(IList<T> entries, int first, int last)
    {
        // Restore Median entries
        while (first < LeftMedian) Swap(entries, first++, Right--);
        while (RightMedian < last) Swap(entries, Left++, last--);
    }

    /// <summary>Swap entries at the left and right indices.</summary>
    private static void Swap(IList<T> entries, int left, int right)
    {
        var comparable = entries[left];
        var entry = entries[right];

        Swap(ref comparable, ref entry);
    }

    /// <summary>Swap two entities of type T.</summary>
    private static void Swap(ref T e1, ref T e2)
    {
        (e1, e2) = (e2, e1);
    }

    #endregion

    #region Insertion Sort

    private static class InsertionSort
    {
        public static void Sort(IList<T> entries, int first, int last)
        {
            for (var next = first + 1; next <= last; next++)
                Insert(entries, first, next);
        }

        /// <summary>Bubble next entry up to its sorted location, assuming entries[first:next - 1] are already sorted.</summary>
        private static void Insert(IList<T> entries, int first, int next)
        {
            var entry = entries[next];
            while (next > first && entries[next - 1].CompareTo(entry) > 0)
                entries[next] = entries[--next];
            entries[next] = entry;
        }
    }

    #endregion
}