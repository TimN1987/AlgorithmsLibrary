using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary.Sorting;

public static class QuickSort
{
    /// <summary>
    /// Uses a quick sort to order values in ascending order.
    /// </summary>
    public static IEnumerable<T> SortAscending<T>(
        IEnumerable<T> unsortedValues
    ) where T : IComparable<T>
    {
        T[] values = unsortedValues.ToArray();
        int length = values.Length;

        if (length <= 1)
            return values;

        ApplyQuickSort(values, 0, length - 1, true);
        return values;
    }

    /// <summary>
    /// Uses a quick sort to order values in descending order.
    /// </summary>
    public static IEnumerable<T> SortDescending<T>(
        IEnumerable<T> unsortedValues
    ) where T : IComparable<T>
    {
        T[] values = unsortedValues.ToArray();
        int length = values.Length;

        if (length <= 1)
            return values;

        ApplyQuickSort(values, 0, length - 1, false);
        return values;
    }

    private static void ApplyQuickSort<T>(
        T[] values,
        int left,
        int right,
        bool isAscending
    ) where T : IComparable<T>
    {
        if (left >= right)
            return;

        int mid = Partition(values, left, right, isAscending);
        ApplyQuickSort(values, left, mid - 1, isAscending);
        ApplyQuickSort(values, mid + 1, right, isAscending);
    }

    private static int Partition<T>(
        T[] values,
        int left,
        int right,
        bool isAscending
    ) where T : IComparable<T>
    {
        T pivot = values[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if ((isAscending && values[j].CompareTo(pivot) <= 0)
                || (!isAscending && values[j].CompareTo(pivot) >= 0))
            {
                i++;
                Swap(values, i, j);
            }
        }
        Swap(values, i + 1, right);
        return i + 1;
    }

    private static void Swap<T>(T[] array, int i, int j) where T : IComparable<T>
        => (array[i], array[j]) = (array[j], array[i]);
}