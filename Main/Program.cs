using System.Collections;
using System.Diagnostics;
using Main;

int[] array = createArray(20000);

Stopwatch st = new Stopwatch();
Timing t = new Timing();

t.Start();
st.Start();

Sorting.BubleSort(array);
t.Stop();
st.Stop();
Console.WriteLine($"BubleSort: {st.Elapsed}");
Console.WriteLine($"BubleSort: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Sorting.SortInsertion(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortInsertion: {st.Elapsed}");
Console.WriteLine($"SortInsertion: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Sorting.SortBinInsert(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortBinInsert: {st.Elapsed}");
Console.WriteLine($"SortBinInsert: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Sorting.SortInsertion(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortInsertion: {st.Elapsed}");
Console.WriteLine($"SortInsertion: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Sorting.SortSelection(array);
t.Stop();
st.Stop();
Console.WriteLine($"SortSelection: {st.Elapsed}");
Console.WriteLine($"SortSelection: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Searching.SimpleSearch(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SimpleSearch: {st.Elapsed}");
Console.WriteLine($"SimpleSearch: {t.Elapsed()}\n");

array = createArray(20000);

st.Start();
t.Start();
Searching.SerchBinary(array, 3);
t.Stop();
st.Stop();
Console.WriteLine($"SerchBinary: {st.Elapsed}");
Console.WriteLine($"SerchBinary: {t.Elapsed()}\n");


var table = createHashtable(20000);

st.Start();
t.Start();
table.ContainsValue(3);
t.Stop();
st.Stop();
Console.WriteLine($"Hashtable: {st.Elapsed}");
Console.WriteLine($"Hashtable: {t.Elapsed()}\n");


int[] createArray(int N)
{
    var array = new List<int>();

    Random random = new Random();

    for(int i = 0; i < N; i++)
    {

        array.Add(random.Next());
    }

    return array.ToArray();
}

Hashtable createHashtable(int N)
{
    var table = new Hashtable();

    Random random = new Random();

    for (int i = 0; i < N; i++)
    {

        table.Add(i, random.Next());
    }

    return table;
}

