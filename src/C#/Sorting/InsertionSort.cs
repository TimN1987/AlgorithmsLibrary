using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Sorting;

public class InsertionSort
{
    /// <summary>
    /// Uses an insertion sort method to sort a collection of integers from smallest to largest.
    /// </summary>
    public IEnumerable<int> SortAscending(IEnumerable<int> unsortedIntegers)
    {
        int[] sortingArray = unsortedIntegers.ToArray();

        if (sortingArray.Length == 0)
            return Enumerable.Empty<int>();

        for (int j = 1; j < sortingArray.Length; j++)
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
    public IEnumerable<int> SortDescending(IEnumerable<int> unsortedIntegers)
    {
        return Enumerable.Empty<int>();
    }

    public IEnumerable<T> SortAscending<T>(IEnumerable<T> unsortedNumbers)
    {
        return Enumerable.Empty<T>();
    }

    public IEnumerable<T> SortDescending<T>(IEnumerable<T> unsortedNumbers)
    {
        return Enumerable.Empty<T>();
    }
}