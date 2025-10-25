using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AlgorithmsLibrary.Selection;

public static class Minimum
{
    /// <summary>
    /// Returns the minimum value in an unsorted collection of <see cref="IComparable"/> values.
    /// </summary>
    public static bool FindMinimum<T>(IEnumerable<T> unsortedValues, out T? minimum) where T : IComparable<T>
    {
        minimum = unsortedValues.FirstOrDefault();

        if (!unsortedValues.Any())
            return false;

        foreach (var value in unsortedValues)
            minimum = Min(minimum, value);

        return true;
    }

    private static T? Min<T>(T? x, T? y) where T : IComparable<T>
    {
        return x?.CompareTo(y) <= 0 ? x : y;
    }
}