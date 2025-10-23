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
        Assert.Equal(unsortedIntegers, sortedIntegers);
    }

    public static IEnumerable<object[]> MemberDataSortAscendingIntegers()
    {
        yield return [Enumerable.Empty<int>(), Enumerable.Empty<int>()];
    }
}