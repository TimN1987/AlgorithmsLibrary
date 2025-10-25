class Minimum:
    @staticmethod
    def find_minimum(array):
        """ Returns the minimum value in an array of values. """
        if len(array) == 0:
            return None
        min = array[0] 
        if len(array) == 1:
            return min
        for value in array[1:]:
            if value < min:
                min = value
        return min
