import pytest
from src.Python.Sorting.insertion_sort import InsertionSort
from datetime import datetime

@pytest.mark.parametrize(
    ("unsorted_input", "expected_output"),
    [
        ([3, 1, 2], [1, 2, 3]),
        ([0, -3, -1, -5, -4, -2], [-5, -4, -3, -2, -1, 0]),
        ([3, 4, 3, 2, 3, 3, 1], [1, 2, 3, 3, 3, 3, 4]),
        ([5, 4, 3, 2, 1], [1, 2, 3, 4, 5]),
        ([], []),
        ([6.98], [6.98]),
        ([6.5, 2.3, 1.09, -4, 29.04], [-4, 1.09, 2.3, 6.5, 29.04]),
        ([i for i in range(100)][::-1], [i for i in range(100)]),
        (["mouse", "dog", "frog", "lion"], ["dog", "frog", "lion", "mouse"]),
        ([datetime(2023, 11, 14), datetime(2025, 12, 25), datetime(2022, 10, 8)], 
         [datetime(2022, 10, 8), datetime(2023, 11, 14), datetime(2025, 12, 25)])
    ]  
)
def test_sort_ascending_integers_sorted(unsorted_input, expected_output):
    # Arrange
    sort = InsertionSort()
    # Act
    result = sort.sort_ascending(unsorted_input)
    # Assert
    assert result == expected_output

@pytest.mark.parametrize(
    ("unsorted_input", "expected_output"),
    [
        ([3, 1, 2], [3, 2, 1]),
        ([0, -3, -1, -5, -4, -2], [0, -1, -2, -3, -4, -5]),
        ([3, 4, 3, 2, 3, 3, 1], [4, 3, 3, 3, 3, 2, 1]),
        ([1, 2, 3, 4, 5], [5, 4, 3, 2, 1]),
        ([], []),
        ([6.98], [6.98]),
        ([6.5, 2.3, 1.09, -4, 29.04], [29.04, 6.5, 2.3, 1.09, -4]),
        ([i for i in range(100)], [i for i in range(100)][::-1]),
        (["mouse", "dog", "frog", "lion"], ["mouse", "lion", "frog", "dog"]),
        ([datetime(2023, 11, 14), datetime(2025, 12, 25), datetime(2022, 10, 8)], 
         [datetime(2025, 12, 25), datetime(2023, 11, 14), datetime(2022, 10, 8)])
    ]  
)
def test_sort_descending_integers_sorted(unsorted_input, expected_output):
    # Arrange
    sort = InsertionSort()
    # Act
    result = sort.sort_descending(unsorted_input)
    # Assert
    assert result == expected_output