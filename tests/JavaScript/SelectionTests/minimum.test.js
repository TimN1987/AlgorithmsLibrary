const Minimum = require('../../../src/JavaScript/Selection/minimum');

const testCases = [
    {values: [], expectedMinimum: undefined},
    {values: [3], expectedMinimum: 3},
    {values: [1.9], expectedMinimum: 1.9},
    {values: [Number.MIN_VALUE], expectedMinimum: Number.MIN_VALUE},
    {values: [true], expectedMinimum: true},
    {values: [-9], expectedMinimum: -9},
    {values: [new Date(2025, 12, 25)], expectedMinimum: new Date(2025, 12, 25)},
    {values: ["cat"], expectedMinimum: "cat"},
    {values: [3, 1, 2], expectedMinimum: 1},
    {values: [-5, -10, 0], expectedMinimum: -10},
    {values: [1.87, 9.02, 0.01], expectedMinimum: 0.01},
    {values: ["mouse", "cat", "lion"], expectedMinimum: "cat"},
    {values: [new Date(2025, 12, 25), new Date(2023, 12, 25), new Date(2024, 11, 11)], expectedMinimum: new Date(2023, 12, 25)},
    {values: [0, Number.MAX_VALUE, Number.MIN_VALUE], expectedMinimum: 0},
    {values: Array(100).fill(1).map((n, i) => n + i), expectedMinimum: 1}
];

test.each(testCases)('finds minimum', ({values, expectedMinimum}) => {
    // Arrange & Act
    const result = Minimum.findMinimum(values);
    //Assert
    expect(result).toEqual(expectedMinimum);
});