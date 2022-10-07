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
st.Start();
Sorting.SortSelection(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortSelection: {st.Elapsed}");
Console.WriteLine($"SortSelection: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
st.Start();
Searching.SimpleSearch(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SimpleSearch: {st.Elapsed}");
Console.WriteLine($"SimpleSearch: {t.Elapsed()}\n");

array = new int[] { 1, 4, 3, 5, 6, 7, 8};

st.Start();
st.Start();
Searching.SerchBinary(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SerchBinary: {st.Elapsed}");
Console.WriteLine($"SerchBinary: {t.Elapsed()}\n");



