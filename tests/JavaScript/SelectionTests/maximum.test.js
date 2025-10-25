const Maximum = require('../../../src/JavaScript/Selection/maximum');

const testCases = [
    {values: [], expectedMaximum: undefined},
    {values: [3], expectedMaximum: 3},
    {values: [1.9], expectedMaximum: 1.9},
    {values: [Number.MIN_VALUE], expectedMaximum: Number.MIN_VALUE},
    {values: [true], expectedMaximum: true},
    {values: [-9], expectedMaximum: -9},
    {values: [new Date(2025, 12, 25)], expectedMaximum: new Date(2025, 12, 25)},
    {values: ["cat"], expectedMaximum: "cat"},
    {values: [3, 1, 2], expectedMaximum: 3},
    {values: [-5, -10, 0], expectedMaximum: 0},
    {values: [1.87, 9.02, 0.01], expectedMaximum: 9.02},
    {values: ["mouse", "cat", "lion"], expectedMaximum: "mouse"},
    {values: [new Date(2025, 12, 25), new Date(2023, 12, 25), new Date(2024, 11, 11)], expectedMaximum: new Date(2025, 12, 25)},
    {values: [0, Number.MAX_VALUE, Number.MIN_VALUE], expectedMaximum: Number.MAX_VALUE},
    {values: Array(100).fill(1).map((n, i) => n + i), expectedMaximum: 100}
];

test.each(testCases)('finds maximum', ({values, expectedMaximum}) => {
    // Arrange & Act
    const result = Maximum.findMaximum(values);
    //Assert
    expect(result).toEqual(expectedMaximum);
});