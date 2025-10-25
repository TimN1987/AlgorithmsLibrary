import pytest
from src.Python.Selection.maximum import Maximum
from datetime import datetime

@pytest.mark.parametrize(
    ("array", "expected_maximum"),
    [
        ([], None),
        ([4], 4),
        ([0.6], 0.6),
        (["bus"], "bus"),
        ([datetime(2025, 12, 25)], datetime(2025, 12, 25)),
        ([3, 1, 2], 3),
        ([-5, 0, -10], 0),
        (range(0, 100), 99),
        ([9.6, 1.02, 5.34, 11.7], 11.7),
        (["cat", "dog", "ant"], "dog")
    ]
)
def test_find_maximum_returns_maximum(array, expected_maximum):
    # Arrange & Act
    min = Maximum.find_maximum(array)
    # Assert
    assert expected_maximum == min