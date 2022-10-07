using System.Collections;
using System.Diagnostics;
using Main;

int[] array = new int[] { 1, 4, 3, 5, 6, 7, 8};

Stopwatch st = new Stopwatch();
Timing t = new Timing();

t.Start();
st.Start();

Sorting.BubleSort(array);
t.Stop();
st.Stop();
Console.WriteLine($"BubleSort: {st.Elapsed}");
Console.WriteLine($"BubleSort: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Sorting.SortInsertion(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortInsertion: {st.Elapsed}");
Console.WriteLine($"SortInsertion: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Sorting.SortBinInsert(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortBinInsert: {st.Elapsed}");
Console.WriteLine($"SortBinInsert: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Sorting.SortInsertion(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortInsertion: {st.Elapsed}");
Console.WriteLine($"SortInsertion: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Sorting.SortSelection(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortSelection: {st.Elapsed}");
Console.WriteLine($"SortSelection: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Searching.SimpleSearch(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SimpleSearch: {st.Elapsed}");
Console.WriteLine($"SimpleSearch: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
t.Start();
Searching.SerchBinary(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SerchBinary: {st.Elapsed}");
Console.WriteLine($"SerchBinary: {t.Elapsed()}\n");


var table = new Hashtable();
table.Add(0, 1);
table.Add(1, 4);
table.Add(2, 3);
table.Add(3, 5);
table.Add(4, 6);
table.Add(5, 7);
table.Add(6, 8);

st.Start();
t.Start();
table.ContainsValue(3);
t.Stop();
st.Stop();
Console.WriteLine($"Hashtable: {st.Elapsed}");
Console.WriteLine($"Hashtable: {t.Elapsed()}\n");



