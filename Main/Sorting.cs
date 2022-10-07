namespace Main;

public class Sorting
{
    public static void SortSelection(int[] a)
    {
        int N = a.Length;
        int min = 0, imin = 0, i;
        for (i = 0; i < N - 1; i++)
        {
            min = a[i];
            imin = i;

            for (int j = i + 1; j < N; j++)
            {
                if (a[j] < min)
                {
                    min = a[j]; imin = j;
                }

                if (i != imin)
                {
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
        }
    }

    public static void SortInsertion(int[] a)
    {
        int tmp = a[0];
        int N = a.Length;
        for (int i = 0; i < N; i++)
        {
            int j = i - 1;
            while (j >= 0 && tmp < a[j])
                a[j + 1] = a[j--];
            a[j + 1] = tmp;
        }
    }

    public static void SortBinInsert(int[] a)
    {
        int N = a.Length;
        for (int i = 0; i <= N - 1; i++)
        {
            int tmp = a[i], left = 1, right = i - 1;
            while (left <= right)
            {
                int m = (left + right) / 2;
                if (tmp < a[m])
                    right = m - 1;
                else left = m + 1;
            }

            for (int j = i - 1; j >= left; j--)
                a[j + 1] = a[j];
            a[left] = tmp;
        }
    }

    public static void BubleSort(int[] a)
    {
        int N = a.Length;
        for (int i = 1; i <= N; i++)
        {
            for (int j = N - 1; j >= i; j--)
            {
                if (a[j - 1] > a[j])
                {
                    int t = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t;
                }
            }
        }
    }
}