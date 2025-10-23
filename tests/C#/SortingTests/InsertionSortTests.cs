using System.Reflection;
using AlgorithmsLibrary.Sorting;
using Xunit;

namespace Tests.SortingTests;

public class InsertionSortTests
{
    private InsertionSort _sort = new InsertionSort();
    
    [Theory]
    [MemberData(nameof(MemberDataSortAscendingIntegers))]
    public void SortAscending_IntegersInput_SortedIntegersReturned(IEnumerable<int> unsortedIntegers, IEnumerable<int> sortedIntegers)
    {
        //Arrange & Act
        var result = _sort.SortAscending(unsortedIntegers);

        //Assert
        Assert.Equal(sortedIntegers, result);
    }

    public static IEnumerable<object[]> MemberDataSortAscendingIntegers()
    {
        yield return new object[] { new int[] { 3, 1, 5, 2, 4 }, new int[] { 1, 2, 3, 4, 5 } };
        yield return new object[] { new int[] { 10, 4, 0, 6, 8, 2 }, new int[] { 0, 2, 4, 6, 8, 10 } };
        yield return new object[] { new int[] { 87, 13, -89, 0, 42, -176 }, new int[] { -176, -89, 0, 13, 42, 87 } };
        yield return new object[] { new int[] { -3, -1, 0, -5, -2, -4 }, new int[] { -5, -4, -3, -2, -1, 0 } };
        yield return new object[] { new int[] { 5, 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5, 5 } };
        yield return new object[] { new int[] { 3, 7, 3, 6, 3, 5, 3 }, new int[] { 3, 3, 3, 3, 5, 6, 7 } };
        yield return new object[] { new List<int>(), new List<int>() };
        yield return new object[] { Array.Empty<int>(), Array.Empty<int>() };
        yield return new object[] { new List<int>() { 42 }, new List<int>() { 42 } };
        yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 } };
        yield return new object[] { new int[] { -10, -8, -6, -4, -2, 0 }, new int[] { -10, -8, -6, -4, -2, 0 } };
        yield return new object[] { new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 } };
        yield return new object[] { new int[] { int.MaxValue, 0, int.MinValue }, new int[] { int.MinValue, 0, int.MaxValue } };
        yield return new object[] { Enumerable.Range(0, 100).Reverse(), Enumerable.Range(0, 100) };
    }
}