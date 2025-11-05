using System;
using System.Collections.Generic;

namespace AlgorithmsLibrary.Selection;

public static class Maximum
{
    /// <summary>
    /// Returns the maximum value in an unsorted collection of <see cref="IComparable"/> values.
    /// </summary>
    public static bool FindMaximum<T>(IEnumerable<T> unsortedValues, out T? maximum) where T : IComparable<T>
    {
        maximum = unsortedValues.FirstOrDefault();

        if (!unsortedValues.Any())
            return false;

        foreach (var value in unsortedValues)
            maximum = Max(maximum, value);

        return true;
    }

    private static T? Max<T>(T? x, T? y) where T : IComparable<T>
    {
        return x?.CompareTo(y) >= 0 ? x : y;
    }
}