const Minimum = require('../../../src/JavaScript/Selection/minimum');

const testCases = [
    {values: [], expectedMinimum: Infinity}
];

test.each(testCases)('finds minimum', ({values, expectedMinimum}) => {
    // Arrange & Act
    const result = Minimum.findMinimum(values);
    //Assert
    expect(result).toEqual(expectedMinimum);
});