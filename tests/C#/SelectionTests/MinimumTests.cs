using System;
using System.Security.Authentication.ExtendedProtection;
using AlgorithmsLibrary.Selection;
using Xunit;

public class MinimumTests
{
    [Theory]
    [MemberData(nameof(MemberDataFindMinimum))]
    public void FindMinimum_UnsortedValues_ReturnsMinimum<T>(
        IEnumerable<T> unsortedValues,
        bool isMinimumExpected,
        T? expectedMinimum
    ) where T : IComparable<T>
    {
        // Arrange & Act
        bool isMinimum = Minimum.FindMinimum(unsortedValues, out T? minimum);

        // Assert
        Assert.Equal(isMinimumExpected, isMinimum);
        Assert.Equal(expectedMinimum, minimum);
    }

    public static IEnumerable<object[]> MemberDataFindMinimum()
    {
        yield return new object[] { Array.Empty<int>(), false, default(int) };
        yield return new object[] { Array.Empty<DateTime>(), false, default(DateTime) };
        yield return new object[] { new List<bool>(), false, false };
        yield return new object[] { new string[] { "cat" }, true, "cat" };
        yield return new object[] { new int[] { 2 }, true, 2 };
        yield return new object[] { new List<double>() { 8.796 }, true, 8.796 };
        yield return new object[] { new int[] { int.MinValue, int.MaxValue, 0 }, true, int.MinValue };
        yield return new object[] { Enumerable.Range(0, 100), true, 0 };
        yield return new object[] { new List<short>() { 2, 1, 5, 3 }, true, 1 };
        yield return new object[] { new int[] { -5, -10, -3, -6 }, true, -10 };
        yield return new object[] { new long[] { 17L, 42L }, true, 17L };
        yield return new object[] { new List<float>() { 4.2f, 1.7f, -9.2f }, true, -9.2f };
        yield return new object[] { new char[] { 'c', 'g', 'a' }, true, 'a' };
    } 
} 