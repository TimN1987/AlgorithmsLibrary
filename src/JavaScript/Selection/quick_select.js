class QuickSelect {
    /**
     * Returns the kth smallest element in the array.
     */
    static selectKthSmallest(array, k) {
        const length = array.length;
        if (k < 1 || k > length)
            return undefined;
        return this.quickSelect(array, 0, length - 1, k, true);
    }

    /**
     * Returns the kth largest element in the array.
     */
    static selectKthLargest(array, k) {
        const length = array.length;
        if (k < 1 || k > length)
            return undefined;
        return this.quickSelect(array, 0, length - 1, k, false);
    }

    static quickSelect(array, left, right, k, isSmallest) {
        if (left === k)
            return array[left];
        const pivotIndex = this.partition(array, left, right, isSmallest);
        const order = pivotIndex - left + 1;
        if (k === order)
            return array[pivotIndex];
        else if (k < order)
            return this.quickSelect(array, left, pivotIndex - 1, k, isSmallest);
        else
            return this.quickSelect(array, pivotIndex + 1, right, k - order, isSmallest);
    }

    static partition(array, left, right, isSmallest) {
        const pivot = array[right];
        let i = left - 1;
        for (let j = left; j < right; j++) {
            if ((isSmallest && array[j] <= pivot) || (!isSmallest && array[j] >= pivot)) {
                i++;
                this.swap(array, i, j);
            }
        }
        this.swap(array, i + 1, right);
        return i + 1;
    }

    static swap(array, i, j) {
        [array[i], array[j]] = [array[j], array[i]]
    }
}

module.exports = QuickSelect