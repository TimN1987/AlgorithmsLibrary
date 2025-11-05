using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace AlgorithmsLibrary.Selection;

public static class QuickSelect
{
    /// <summary>
    /// Finds the kth smallest element from an unsorted collection of <see cref="IComparable"/> values. 
    /// </summary>
    /// <returns>True if a kth smallest value exists; false, if not.</returns>
    public static bool SelectKthSmallest<T>(IEnumerable<T> values, int k, out T? kthSmallest) where T : IComparable<T>
    {
        kthSmallest = default;

        if (k < 1 || values.Count() < k)
            return false;

        return ComputeQuickSelect(values.ToArray(), 0, values.Count() - 1, k, true, out kthSmallest);
    }

    /// <summary>
    /// Finds the kth largest element from an unsorted collection of <see cref="IComparable"/> values. 
    /// </summary>
    /// <returns>True if a kth largest value exists; false, if not.</returns>
    public static bool SelectKthLargest<T>(IEnumerable<T> values, int k, out T? kthLargest) where T : IComparable<T>
    {
        kthLargest = default;

        if (k < 1 || values.Count() < k)
            return false;

        return ComputeQuickSelect(values.ToArray(), 0, values.Count() - 1, k, false, out kthLargest);
    }

    private static bool ComputeQuickSelect<T>(T[] values, int left, int right, int k, bool isSmallest, out T value) where T : IComparable<T>
    {
        if (left == right)
        {
            value = values[left];
            return true;
        }

        int pivot_index = Partition(values, left, right, isSmallest);
        int order = pivot_index - left + 1;

        if (k == order)
        {
            value = values[pivot_index];
            return true;
        }

        if (k < order)
        {
            return ComputeQuickSelect(values, left, pivot_index - 1, k, isSmallest, out value);
        }

        return ComputeQuickSelect(values, pivot_index + 1, right, k - order, isSmallest, out value);
    }

    private static int Partition<T>(T[] values, int left, int right, bool isSmallest) where T : IComparable<T>
    {
        T pivot = values[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if ((isSmallest && values[j].CompareTo(pivot) <= 0) || (!isSmallest && values[j].CompareTo(pivot) >= 0))
            {
                i++;
                Swap(values, i, j);
            }
        }
        Swap(values, i + 1, right);
        return i + 1;
    }
    
    private static void Swap<T>(T[] values, int i, int j) where T : IComparable<T> => (values[i], values[j]) = (values[j], values[i]);
}