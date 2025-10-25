using System;
using AlgorithmsLibrary.Selection;
using Xunit;

public class MaximumTests
{
    [Theory]
    [MemberData(nameof(MemberDataFindMaximum))]
    public void FindMaximum_UnsortedValues_ReturnsMaximum<T>(
        IEnumerable<T> unsortedValues,
        bool isMaximumExpected,
        T? expectedMaximum
    ) where T : IComparable<T>
    {
        // Arrange & Act
        bool isMaximum = Maximum.FindMaximum(unsortedValues, out T? maximum);

        // Assert
        Assert.Equal(isMaximumExpected, isMaximum);
        Assert.Equal(expectedMaximum, maximum);
    }

    public static IEnumerable<object[]> MemberDataFindMaximum()
    {
        yield return new object[] { Array.Empty<int>(), false, default(int) };
        yield return new object[] { Array.Empty<DateTime>(), false, default(DateTime) };
        yield return new object[] { new List<bool>(), false, false };
        yield return new object[] { new string[] { "cat" }, true, "cat" };
        yield return new object[] { new int[] { 2 }, true, 2 };
        yield return new object[] { new List<double>() { 8.796 }, true, 8.796 };
        yield return new object[] { new int[] { int.MinValue, int.MaxValue, 0 }, true, int.MaxValue };
        yield return new object[] { Enumerable.Range(0, 100), true, 99 };
        yield return new object[] { new List<short>() { 2, 1, 5, 3 }, true, 5 };
        yield return new object[] { new int[] { -5, -10, -3, -6 }, true, -3 };
        yield return new object[] { new long[] { 17L, 42L }, true, 42L };
        yield return new object[] { new List<float>() { 4.2f, 1.7f, -9.2f }, true, 4.2f };
        yield return new object[] { new char[] { 'c', 'g', 'a' }, true, 'g' };
    } 
} 