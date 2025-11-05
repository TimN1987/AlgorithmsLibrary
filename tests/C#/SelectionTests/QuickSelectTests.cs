using System;
using AlgorithmsLibrary.Selection;
using Xunit;

public class QuickSelectTests
{
    [Theory]
    [MemberData(nameof(MemberDataKthSmallest))]
    public void SelectKthSmallest_UnsortedValues_ReturnsKthSmallest<T>(
        IEnumerable<T> unsortedValues,
        int k,
        bool isKthSmallestExpected,
        T? expectedValue
    ) where T : IComparable<T>
    {
        // Arrange & Act
        bool isKthSmallest = QuickSelect.SelectKthSmallest(unsortedValues, k, out T? kthSmallest);

        // Assert
        Assert.Equal(isKthSmallestExpected, isKthSmallest);
        Assert.Equal(expectedValue, kthSmallest);
    }

    [Theory]
    [MemberData(nameof(MemberDataKthLargest))]
    public void SelectKthLargest_UnsortedValues_ReturnsKthLargest<T>(
        IEnumerable<T> unsortedValues,
        int k,
        bool isKthLargestExpected,
        T? expectedValue
    ) where T : IComparable<T>
    {
        // Arrange & Act
        bool isKthLargest = QuickSelect.SelectKthLargest(unsortedValues, k, out T? kthLargest);

        // Assert
        Assert.Equal(isKthLargestExpected, isKthLargest);
        Assert.Equal(expectedValue, kthLargest);
    }

    public static IEnumerable<object[]> MemberDataKthSmallest()
    {
        yield return new object[] { Array.Empty<int>(), 5, false, default(int) };
        yield return new object[] { Array.Empty<DateTime>(), 3, false, default(DateTime) };
        yield return new object[] { new List<bool>(), 10, false, false };
        yield return new object[] { new string[] { "cat" }, 1, true, "cat" };
        yield return new object[] { new int[] { 2 }, 4, false, default(int) };
        yield return new object[] { new List<double>() { 8.796 }, 1, true, 8.796 };
        yield return new object[] { new int[] { int.MinValue, int.MaxValue, 0 }, 2, true, 0 };
        yield return new object[] { Enumerable.Range(0, 100), 17, true, 16 };
        yield return new object[] { new List<short>() { 2, 1, 5, 3 }, 3, true, 3 };
        yield return new object[] { new int[] { -5, -10, -3, -6 }, 2, true, -6 };
        yield return new object[] { new long[] { 17L, 42L }, 2, true, 42L };
        yield return new object[] { new List<float>() { 4.2f, 1.7f, -9.2f }, 1, true, -9.2f };
        yield return new object[] { new char[] { 'c', 'g', 'a', 'd', 'b' }, 4, true, 'd' };
    }

    public static IEnumerable<object[]> MemberDataKthLargest()
    {
        yield return new object[] { Array.Empty<int>(), 5, false, default(int) };
        yield return new object[] { Array.Empty<DateTime>(), 3, false, default(DateTime) };
        yield return new object[] { new List<bool>(), 10, false, false };
        yield return new object[] { new string[] { "cat" }, 1, true, "cat" };
        yield return new object[] { new int[] { 2 }, 4, false, default(int) };
        yield return new object[] { new List<double>() { 8.796 }, 1, true, 8.796 };
        yield return new object[] { new int[] { int.MinValue, int.MaxValue, 0 }, 2, true, 0 };
        yield return new object[] { Enumerable.Range(0, 100), 17, true, 83 };
        yield return new object[] { new List<short>() { 2, 1, 5, 3 }, 3, true, 2 };
        yield return new object[] { new int[] { -5, -10, -3, -6 }, 2, true, -5 };
        yield return new object[] { new long[] { 17L, 42L }, 2, true, 17L };
        yield return new object[] { new List<float>() { 4.2f, 1.7f, -9.2f }, 1, true, 4.2f };
        yield return new object[] { new char[] { 'c', 'g', 'a', 'd', 'b' }, 4, true, 'b' };
    } 
} 