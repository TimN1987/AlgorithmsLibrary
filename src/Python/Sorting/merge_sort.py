import math

class MergeSort():
    
    def sort_ascending(self, array):
        array = self.merge_sort(array, 0, len(array) - 1, True)
        return array

    def sort_descending(self, array):
        array = self.merge_sort(array, 0, len(array) - 1, False)
        return array

    def merge_sort(self, array, left, right, is_ascending):
        if (left >= right):
            return array
        mid = math.floor(left + (right - left) / 2)
        self.merge_sort(array, left, mid, is_ascending)
        self.merge_sort(array, mid + 1, right, is_ascending)
        self.merge(array, left, mid, right, is_ascending)
        return array

    def merge(self, array, left, mid, right, is_ascending):
        L = array[left : mid + 1]
        R = array[mid + 1 : right + 1]

        i = 0
        j = 0
        k = left

        while (i < len(L) and j < len(R)):
            if ((is_ascending and L[i] <= R[j]) or (not is_ascending and L[i] >= R[j])):
                array[k] = L[i]
                i += 1
            else:
                array[k] = R[j]
                j += 1
            k += 1

        while i < len(L):
            array[k] = L[i]
            i += 1
            k += 1

        while j < len(R):
            array[k] = R[j]
            j += 1
            k += 1

        return array