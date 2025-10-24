using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AlgorithmsLibrary.Sorting;

public static class MergeSort
{
    /// <summary>
    /// Uses a merge sort to order values in ascending order.
    /// </summary>
    public static IEnumerable<T> SortAscending<T>(
        IEnumerable<T> unsortedValues
        ) where T : IComparable<T>
    {
        T[] values = unsortedValues.ToArray();
        int length = values.Length;
        return DivideAndSort(values, 0, length - 1, true);
    }

    /// <summary>
    /// Uses a merge sort to order values in descending order.
    /// </summary>
    public static IEnumerable<T> SortDescending<T>(
        IEnumerable<T> unsortedValues
        ) where T : IComparable<T>
    {
        T[] values = unsortedValues.ToArray();
        int length = values.Length;
        return DivideAndSort(values, 0, length - 1, false);
    }

    /// <summary>
    /// Splits the array in half, sorts each half and then merges together.
    /// </summary>
    public static T[] DivideAndSort<T>(
        T[] values,
        int left,
        int right,
        bool isAscending
        ) where T : IComparable<T>
    {
        if (left >= right)
            return values;

        int mid = left + (right - left) / 2;

        DivideAndSort(values, left, right, isAscending);
        DivideAndSort(values, mid + 1, right, isAscending);
        Merge(values, left, mid, right, isAscending);

        return values;
    }
    
    /// <summary>
    /// Merges the two halves of the array in the desired order.
    /// </summary>
    private static T[] Merge<T>(
        T[] values,
        int left,
        int mid,
        int right,
        bool isAscending
        ) where T : IComparable<T>
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        T[] L = values
            .Skip(left)
            .Take(n1)
            .ToArray();
        T[] R = values
            .Skip(mid + 1)
            .Take(n2)
            .ToArray();

        int i = 0;
        int j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if ((isAscending && L[i].CompareTo(R[j]) <= 0)
                || (!isAscending && L[i].CompareTo(R[j]) >= 0))
                values[k++] = L[i++];
            else
                values[k++] = R[j++];
        }

        while (i < n1)
        {
            values[k++] = L[i++];
        }

        while (j < n2)
        {
            values[k++] = R[j++];
        }

        return values;
    }
}