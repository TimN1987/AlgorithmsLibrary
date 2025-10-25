class Maximum:
    @staticmethod
    def find_maximum(array):
        """ Returns the maximum value in an array of values. """
        if len(array) == 0:
            return None
        max = array[0] 
        if len(array) == 1:
            return max
        for value in array[1:]:
            if value > max:
                max = value
        return max