class InsertionSort {

    /**
     * Uses insertion sort to sort an array into ascending order.
     */
    sortAscending(array) {
        const length = array.length;
        if (length === 0)
            return [];
        for (let j = 1; j < length; j++) {
            const key = array[j];
            let i = j - 1;
            while (i >= 0 && array[i] > key) {
                array[i + 1] = array[i];
                i--;
            }
            array[i + 1] = key;
        }
        return array;
    }

    /**
     * Uses insertion sort to sort an array into descending order.
     */
    sortDescending(array) {
        const length = array.length;
        if (length === 0)
            return [];
        for (let j = 1; j < length; j++) {
            const key = array[j];
            let i = j - 1;
            while (i >= 0 && array[i] < key) {
                array[i + 1] = array[i];
                i--;
            }
            array[i + 1] = key;
        }
        return array;
    }
}

module.exports = InsertionSort;