class Maximum {
    /**
     * Finds the maximum value in an array.
     */
    static findMaximum(array) {
        const length = array.length;
        if (length == 0)
            return undefined;
        let maximum = array[0];
        if (length == 1)
            return maximum;
        for (let i = 1; i < length; i++)
            maximum = this.maximum(maximum, array[i]);
        return maximum;
    }

    static maximum(i, j) {
        if (i > j)
            return i;
        return j;
    }
}

module.exports = Maximum