import pytest
from src.Python.Selection.minimum import Minimum
from datetime import datetime

@pytest.mark.parametrize(
    ("array", "expected_minimum"),
    [
        ([], None),
        ([4], 4),
        ([0.6], 0.6),
        (["bus"], "bus"),
        ([datetime(2025, 12, 25)], datetime(2025, 12, 25)),
        ([3, 1, 2], 1),
        ([-5, 0, -10], -10),
        (range(0, 100), 0),
        ([9.6, 1.02, 5.34, 11.7], 1.02),
        (["cat", "dog", "ant"], "ant")
    ]
)
def test_find_minimum_returns_minimum(array, expected_minimum):
    # Arrange & Act
    min = Minimum.find_minimum(array)
    # Assert
    assert expected_minimum == min