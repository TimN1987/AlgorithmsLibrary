import pytest
from src.Python.Selection.quick_select import QuickSelect
from datetime import datetime

@pytest.mark.parametrize(
    ("values", "k", "expected"),
    [
        ([], 0, None),
        ([], 5, None),
        ([1, 2, 3], 2, 2),
        ([1, 2, 3], 4, None),
        ([3, 2, 5, 1, 4], 4, 4),
        ([3, 2, 4, 1, 4], 10, None),
        ([1.78, 2.901, -3.49, 0.1], 3, 1.78),
        ([-1, -2, -3, -4, -5, -6, -7], 5, -3),
        (['a', 'b', 'c', 'd'], 2, 'b'),
        (['dog', 'ant', 'mouse', 'cat'], 1, 'ant'),
        ([datetime(2025, 12, 25), datetime(2012, 11, 11), datetime(2017, 12, 25)], 3, datetime(2025, 12, 25))
    ]
)
def test_select_kth_smallest_returns_expected(values, k, expected):
    # Arrange & Act
    result = QuickSelect.select_kth_smallest(values, k)
    # Assert
    assert result == expected

@pytest.mark.parametrize(
    ("values", "k", "expected"),
    [
        ([], 0, None),
        ([], 5, None),
        ([1, 2, 3], 2, 2),
        ([1, 2, 3], 4, None),
        ([2, 2, 2, 2, 2, 2, 2], 3, 2),
        ([3, 2, 4, 1, 4], 10, None),
        ([1.78, 2.901, -3.49, 0.1], 3, 0.1),
        ([-1, -2, -3, -4, -5, -6, -7], 5, -5),
        (['a', 'b', 'c', 'd', 'b'], 3, 'b'),
        (['dog', 'ant', 'mouse', 'cat'], 1, 'mouse'),
        ([datetime(2025, 12, 25), datetime(2012, 11, 11), datetime(2017, 12, 25)], 3, datetime(2012, 11, 11))
    ]
)
def test_select_kth_largest_returns_expected(values, k, expected):
    # Arrange & Act
    result = QuickSelect.select_kth_largest(values, k)
    # Assert
    assert result == expected