using Strategy;
using Strategy.SortAlgorithms;

var list = MockData.RandomNumbers;
var measurer = new SortingTimeMeasurer();

var algorithms = new Dictionary<string, ISortAlgorithm>
{
    {"Bubble sort", new BubbleSort()},
    {"Merge sort", new MergeSort()},
    {"Quick sort", new QuickSort<int>()}
    //{"Bogo sort", new BogoSort()}  // uncomment at your own risk!
};

foreach (var pair in algorithms)
{
    Console.Write($"{pair.Key}: ");
    measurer.SortAlgorithm = pair.Value;
    measurer.Measure(list);
}