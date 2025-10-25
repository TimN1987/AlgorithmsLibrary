class QuickSort {
    /**
     * Uses quick sort to order values in ascending order.
     */
    sortAscending(array) {
        this.quickSort(array, 0, array.length - 1, true);
        return array;
    }

    /**
     * Uses quick sort to order values in descending order.
     */
    sortDescending(array) {
        this.quickSort(array, 0, array.length - 1, false);
        return array;
    }

    quickSort(array, left, right, isAscending) {
        if (left >= right)
            return array;
        const mid = this.partition(array, left, right, isAscending);
        this.quickSort(array, left, mid - 1, isAscending);
        this.quickSort(array, mid + 1, right, isAscending);
    }

    partition(array, left, right, isAscending) {
        const pivot = array[right];
        let i = left - 1;
        for (let j = left; j < right; j++) {
            if ((isAscending && array[j] <= pivot) || (!isAscending && array[j] >= pivot)) {
                i++;
                this.swap(array, i, j);
            }
        }
        this.swap(array, i + 1, right);
        return i + 1;
    }

    swap(array, i, j) {
        const temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

module.exports = QuickSort