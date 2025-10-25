class QuickSort:

    def sort_ascending(self, array):
        """ Uses quick sort to order values in ascending order. """
        self.quick_sort(array, 0, len(array) - 1, True)
        return array

    def sort_descending(self, array):
        """ Uses quick sort to order values in descending order. """
        self.quick_sort(array, 0, len(array) - 1, False)
        return array

    def quick_sort(self, array, left, right, is_ascending):
        if left >= right:
            return array
        mid = self.partition(array, left, right, is_ascending)
        self.quick_sort(array, left, mid - 1, is_ascending)
        self.quick_sort(array, mid + 1, right, is_ascending)
        return array

    def partition(self, array, left, right, is_ascending):
        pivot = array[right]
        i = left - 1
        for j in range(left, right):
            if (is_ascending and array[j] <= pivot) or (not is_ascending and array[j] >= pivot):
                i += 1
                self.swap(array, i, j)
        self.swap(array, i + 1, right)
        return i + 1

    @staticmethod
    def swap(array, i, j):
        array[i], array[j] = array[j], array[i]