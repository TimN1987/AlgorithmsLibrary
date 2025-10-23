class MergeSort {
    /**
     * Uses Merge Sort to sort an array into ascending order.
     */
    sortAscending(array) {
        if (array.length <= 1)
            return array;
        this.mergeSortAscending(array, 0, array.length - 1);
        return array;
    }

    mergeSortAscending(array, left, right) {
        if (left >= right)
            return;
        const mid = Math.floor(left + (right - left) / 2);
        this.mergeSortAscending(array, left, mid);
        this.mergeSortAscending(array, mid + 1, right);
        this.mergeAscending(array, left, mid, right);
    }

    mergeAscending(array, left, mid, right) {
        let n1 = mid - left + 1;
        let n2 = right - mid;

        const L = new Array(n1);
        const R = new Array(n2);

        for (let i = 0; i < n1; i++)
            L[i] = array[left + i];

        for (let i = 0; i < n2; i++)
            R[i] = array[mid + 1 + i];

        let i = 0, j = 0;
        let k = left;

        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                array[k] = L[i];
                i++;
            } else {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1) {
            array[k++] = L[i++];
        }

        while (j < n2) {
            array[k++] = R[j++];
        }
    }

    /**
     * Uses Merge Sort to sort an array into descending order.
     */
    sortDescending(array) {
        if (array.length <= 1)
            return array;
        this.mergeSortDescending(array, 0, array.length - 1);
        return array;
    }

    mergeSortDescending(array, left, right) {
        if (left >= right)
            return;
        const mid = Math.floor(left + (right - left) / 2);
        this.mergeSortDescending(array, left, mid);
        this.mergeSortDescending(array, mid + 1, right);
        this.mergeDescending(array, left, mid, right);
    }

    mergeDescending(array, left, mid, right) {
        let n1 = mid - left + 1;
        let n2 = right - mid;

        const L = new Array(n1);
        const R = new Array(n2);

        for (let i = 0; i < n1; i++)
            L[i] = array[left + i];

        for (let i = 0; i < n2; i++)
            R[i] = array[mid + 1 + i];

        let i = 0, j = 0;
        let k = left;

        while (i < n1 && j < n2) {
            if (L[i] >= R[j]) {
                array[k] = L[i];
                i++;
            } else {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1) {
            array[k++] = L[i++];
        }

        while (j < n2) {
            array[k++] = R[j++];
        }
    }
}

module.exports = MergeSort