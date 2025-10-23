using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Sorting;

public static class InsertionSort
{
    /// <summary>
    /// Uses an insertion sort method to sort a collection of integers from smallest to largest.
    /// </summary>
    public static IEnumerable<int> SortAscending(IEnumerable<int> unsortedIntegers)
    {
        int[] sortingArray = unsortedIntegers.ToArray();
        int length = sortingArray.Length;

        if (length == 0)
            return Enumerable.Empty<int>();

        for (int j = 1; j < length; j++)
        {
            int key = sortingArray[j];
            int i = j - 1;

            while (i >= 0 && sortingArray[i] > key)
            {
                sortingArray[i + 1] = sortingArray[i];
                i--;
            }

            sortingArray[i + 1] = key;
        }

        return sortingArray;
    }

    /// <summary>
    /// Uses an insertion sort method to sort a collection of integers from largest to smallest.
    /// </summary>
    public static IEnumerable<int> SortDescending(IEnumerable<int> unsortedIntegers)
    {
        int[] sortingArray = unsortedIntegers.ToArray();
        int length = sortingArray.Length;

        if (length == 0)
            return Enumerable.Empty<int>();

        for (int j = 1; j < length; j++)
        {
            int key = sortingArray[j];
            int i = j - 1;

            while (i >= 0 && sortingArray[i] < key)
            {
                sortingArray[i + 1] = sortingArray[i];
                i--;
            }

            sortingArray[i + 1] = key;
        }

        return sortingArray;
    }

    /// <summary>
    /// Uses an insertion sort method to sort a collection of <see cref="IComparable"/> objects from smallest to largest.
    /// </summary>
    public static IEnumerable<T> SortAscending<T>(IEnumerable<T> unsortedNumbers) where T : IComparable<T>
    {
        var sortingArray = unsortedNumbers.ToArray();
        int length = sortingArray.Length;

        if (length == 0)
            return Enumerable.Empty<T>();

        for (int j = 1; j < length; j++)
        {
            T key = sortingArray[j];
            int i = j - 1;

            while (i >= 0 && sortingArray[i].CompareTo(key) > 0)
            {
                sortingArray[i + 1] = sortingArray[i];
                i--;
            }

            sortingArray[i + 1] = key;
        }

        return sortingArray;
    }

    /// <summary>
    /// Uses an insertion sort method to sort a collection of <see cref="IComparable"/> objects from largest to smallest.
    /// </summary>
    public static IEnumerable<T> SortDescending<T>(IEnumerable<T> unsortedNumbers) where T : IComparable<T>
    {
        var sortingArray = unsortedNumbers.ToArray();
        int length = sortingArray.Length;

        if (length == 0)
            return Enumerable.Empty<T>();

        for (int j = 1; j < length; j++)
        {
            T key = sortingArray[j];
            int i = j - 1;

            while (i >= 0 && sortingArray[i].CompareTo(key) < 0)
            {
                sortingArray[i + 1] = sortingArray[i];
                i--;
            }

            sortingArray[i + 1] = key;
        }

        return sortingArray;
    }
}