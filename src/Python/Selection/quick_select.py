class QuickSelect:

    @staticmethod
    def select_kth_smallest(array, k):
        """ Returns the kth smallest element in the array. """
        if k < 1 or len(array) < k:
            return None
        return QuickSelect.quick_select(array, 0, len(array) - 1, k , True)

    @staticmethod
    def select_kth_largest(array, k):
        """ Returns the kth largest element in the array. """
        if k < 1 or len(array) < k:
            return None
        return QuickSelect.quick_select(array, 0, len(array) - 1, k, False)
    
    @staticmethod
    def quick_select(array, left, right, k, is_smallest):
        if left == right:
            return array[left]
        pivot_index = QuickSelect.partition(array, left, right, is_smallest)
        order = pivot_index - left + 1
        if k == order:
            return array[pivot_index]
        if k < order:
            return QuickSelect.quick_select(array, left, pivot_index - 1, k, is_smallest)
        return QuickSelect.quick_select(array, pivot_index + 1, right, k - order, is_smallest)
    
    @staticmethod
    def partition(array, left, right, is_smallest):
        pivot = array[right]
        i = left - 1
        for j in range(left, right):
            if (is_smallest and array[j] <= pivot) or (not is_smallest and array[j] >= pivot):
                i += 1
                QuickSelect.swap(array, i, j)
        QuickSelect.swap(array, i + 1, right)
        return i + 1

    @staticmethod
    def swap(array, i, j):
        array[i], array[j] = array[j], array[i]