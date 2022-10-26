using Iterator.Collections;
using Iterator.Iterators;

var list1 = new IterableList<int>(typeof(SimpleIterator<int>), 1, 2, 3, 4, 5);
var iterator1 = list1.CreateIterator();
while (iterator1.HasMore()) Console.Write($"{iterator1.GetNext()}, ");

Console.WriteLine();

var list2 = new IterableList<int>(typeof(BackAndForthAlternatelyIterator<int>), 1, 2, 3, 4, 5);
var iterator2 = list2.CreateIterator();
while (iterator2.HasMore()) Console.Write($"{iterator2.GetNext()}, ");