from typing import Any

class InsertionSort:

    def sort_ascending(self, array: Any) -> Any:
        """ Uses insertion sort to sort in ascending order. """
        length = len(array)
        if (length == 0):
            return []
        for j in range(1, length):
            key = array[j]
            i = j - 1
            while (i >= 0 and array[i] > key):
                array[i + 1] = array[i]
                i -= 1
            array[i + 1] = key
        return array
    
    def sort_descending(self, array: Any) -> Any:
        """ Uses insertion sort to sort in descending order. """
        length = len(array)
        if (length == 0):
            return []
        for j in range(1, length):
            key = array[j]
            i = j - 1
            while (i >= 0 and array[i] < key):
                array[i + 1] = array[i]
                i -= 1
            array[i + 1] = key
        return array