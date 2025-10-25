class Minimum {
    /**
     * Finds the minimum value in an array.
     */
    static findMinimum(array) {
        const length = array.length;
        if (length == 0)
            return undefined;
        let minimum = array[0];
        if (length == 1)
            return minimum;
        for (let i = 1; i < length; i++)
            minimum = this.minimum(minimum, array[i]);
        return minimum;
    }

    static minimum(i, j) {
        if (i < j)
            return i;
        return j;
    }
}

module.exports = Minimum