using System;
using AlgorithmsLibrary.Sorting;
using Xunit;

namespace Tests.SortingTests;

public class MergeSortTests
{
    [Theory]
    [MemberData(nameof(MemberDataSortAscendingGeneric))]
    public void SortAscending_GenericInputs_ExpectedSortedOutputReturned<T>(IEnumerable<T> unsortedInput, IEnumerable<T> expectedResult) where T : IComparable<T>
    {
        //Arrange & Act
        var result = InsertionSort.SortAscending(unsortedInput);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [MemberData(nameof(MemberDataSortDescendingGeneric))]
    public void SortDescending_GenericInputs_ExpectedSortedOutputReturned<T>(IEnumerable<T> unsortedInput, IEnumerable<T> expectedResult) where T : IComparable<T>
    {
        //Arrange & Act
        var result = InsertionSort.SortDescending(unsortedInput);

        //Assert
        Assert.Equal(expectedResult, result);
    } 
       
    public static IEnumerable<object[]> MemberDataSortAscendingGeneric()
    {
        yield return new object[] { new int[] { 3, 1, 5, 2, 4 }, new int[] { 1, 2, 3, 4, 5 } };
        yield return new object[] { new int[] { 87, 13, -89, 0, 42, -176 }, new int[] { -176, -89, 0, 13, 42, 87 } };
        yield return new object[] { new int[] { -3, -1, 0, -5, -2, -4 }, new int[] { -5, -4, -3, -2, -1, 0 } };
        yield return new object[] { new float[] { 5.1f, 5.1f, 5.1f, 5.1f, 5.1f }, new float[] { 5.1f, 5.1f, 5.1f, 5.1f, 5.1f } };
        yield return new object[] { new double[] { 3.76, 7.42, 3.55, 6.99, 3.55, 5.27, 3.76 }, new double[] { 3.55, 3.55, 3.76, 3.76, 5.27, 6.99, 7.42 } };
        yield return new object[] { new List<string>(), new List<string>() };
        yield return new object[] { Array.Empty<decimal>(), Array.Empty<decimal>() };
        yield return new object[] { new List<decimal>() { -402.38m }, new List<decimal>() { -402.38m } };
        yield return new object[] { new double[] { 5.03, 4.22, 3.1, 2, 1.78 }, new double[] { 1.78, 2, 3.1, 4.22, 5.03 } };
        yield return new object[] { new short[] { 0, -2, -4, -6, -8, -10 }, new short[] { -10, -8, -6, -4, -2, 0 } };
        yield return new object[] { new long[] { 50, 40, 30, 20, 10 }, new long[] { 10, 20, 30, 40, 50 } };
        yield return new object[] { new double[] { double.MaxValue, 0, double.MinValue }, new double[] { double.MinValue, 0, double.MaxValue } };
        yield return new object[] { Enumerable.Range(0, 100).Reverse(), Enumerable.Range(0, 100) };
        yield return new object[] { new List<string> { "cat", "dog", "ant", "zebra", "mouse" }, new List<string> { "ant", "cat", "dog", "mouse", "zebra" } };
        yield return new object[] { new string[] { "monkey", "money", "monday", "monk" }, new string[] { "monday", "money", "monk", "monkey" } };
        yield return new object[] { new DateTime[] { new(2025, 12, 25, 12, 30, 0), new(2023, 12, 24, 12, 30, 0), new(2025, 12, 25, 11, 30, 0)},
                                    new DateTime[] {new(2023, 12, 24, 12, 30, 0), new(2025, 12, 25, 11, 30, 0), new(2025, 12, 25, 12, 30, 0)} };
    }

    public static IEnumerable<object[]> MemberDataSortDescendingGeneric()
    {
        yield return new object[] { new int[] { 3, 1, 5, 2, 4 }, new int[] { 5, 4, 3, 2, 1 } };
        yield return new object[] { new int[] { 87, 13, -89, 0, 42, -176 }, new int[] { 87, 42, 13, 0, -89, -176 } };
        yield return new object[] { new int[] { -3, -1, 0, -5, -2, -4 }, new int[] { 0, -1, -2, -3, -4, -5 } };
        yield return new object[] { new float[] { 5.1f, 5.1f, 5.1f, 5.1f, 5.1f }, new float[] { 5.1f, 5.1f, 5.1f, 5.1f, 5.1f } };
        yield return new object[] { new double[] { 3.76, 7.42, 3.55, 6.99, 3.55, 5.27, 3.76 }, new double[] { 7.42, 6.99, 5.27, 3.76, 3.76, 3.55, 3.55 } };
        yield return new object[] { new List<string>(), new List<string>() };
        yield return new object[] { Array.Empty<decimal>(), Array.Empty<decimal>() };
        yield return new object[] { new List<decimal>() { -402.38m }, new List<decimal>() { -402.38m } };
        yield return new object[] { new double[] { 5.03, 4.22, 3.1, 2, 1.78 }, new double[] { 5.03, 4.22, 3.1, 2, 1.78 } };
        yield return new object[] { new short[] { 0, -2, -4, -6, -8, -10 }, new short[] { 0, -2, -4, -6, -8, -10 } };
        yield return new object[] { new long[] { 10, 20, 30, 40, 50 }, new long[] { 50, 40, 30, 20, 10 } };
        yield return new object[] { new double[] { double.MinValue, 0, double.MaxValue }, new double[] { double.MaxValue, 0, double.MinValue } };
        yield return new object[] { Enumerable.Range(0, 100), Enumerable.Range(0, 100).Reverse() };
        yield return new object[] { new List<string> { "cat", "dog", "ant", "zebra", "mouse" }, new List<string> { "zebra", "mouse", "dog", "cat", "ant" } };
        yield return new object[] { new string[] { "monkey", "money", "monday", "monk" }, new string[] { "monkey", "monk", "money", "monday" } };
        yield return new object[] { new DateTime[] { new(2025, 12, 25, 12, 30, 0), new(2023, 12, 24, 12, 30, 0), new(2025, 12, 25, 11, 30, 0)},
                                    new DateTime[] {new(2025, 12, 25, 12, 30, 0), new(2025, 12, 25, 11, 30, 0), new(2023, 12, 24, 12, 30, 0)} };
    }
}