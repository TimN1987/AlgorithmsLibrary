const QuickSelect = require('../../../src/JavaScript/Selection/quick_select');

const testCasesSmallest = [
    {values: [], k: 0, expected: undefined},
    {values: [], k: 3, expected: undefined},
    {values: [1, 2, 3, 4, 5], k: 10, expected: undefined},
    {values: [1, 2, 3, 4, 5], k: 1, expected: 1},
    {values: [3, 1, 5, 2, 4], k: 4, expected: 4},
    {values: [-7, 3, -10, 5, 9], k: 3, expected: 3},
    {values: ["ant", "mouse", "dog", "car"], k: 2, expected: "car"},
    {values: [3.75, 1.04, 9.66], k: 1, expected: 1.04},
    {values: Array(100).fill(1).map((n, i) => n + i), k: 87, expected: 87},
    {values: [true, false, false, true], k: 3, expected: true},
    {values: [-6.5, -6.5, -6.5, 2], k: 2, expected: -6.5},
    {values: [new Date(2025, 12, 25), new Date(2023, 11, 11), new Date(2024, 12, 25)], k: 2, expected: new Date(2024, 12, 25)},
    {values: [2, 4, 6, 8, 10, -2, -4, -6, -8, -10, 0], k: 7, expected: 2},
    {values: [Number.MAX_VALUE, Number.MIN_VALUE, 0], k: 2, expected: Number.MIN_VALUE}
];

test.each(testCasesSmallest)('finds kth smallest element', ({values, k, expected}) => {
    // Arrange & Act
    const result = QuickSelect.selectKthSmallest(values, k);
    // Assert
    expect(result).toEqual(expected);
});

const testCasesLargest = [
    {values: [], k: 3, expected: undefined},
    {values: [], k: 3, expected: undefined},
    {values: [1, 2, 3, 4, 5], k: 10, expected: undefined},
    {values: [1, 2, 3, 4, 5], k: 1, expected: 5},
    {values: [2, 1, 5, 3, 4], k: 2, expected: 4},
    {values: [-7, 3, -10, 5, 9], k: 3, expected: 3},
    {values: ["ant", "mouse", "dog", "car"], k: 2, expected: "dog"},
    {values: [3.75, 1.04, 9.66], k: 1, expected: 9.66},
    {values: Array(100).fill(1).map((n, i) => n + i), k: 87, expected: 14},
    {values: [true, false, false, true], k: 3, expected: false},
    {values: [-6.5, -6.5, -6.5, 2], k: 2, expected: -6.5},
    {values: [new Date(2025, 12, 25), new Date(2023, 11, 11), new Date(2024, 12, 25)], k: 2, expected: new Date(2024, 12, 25)},
    {values: [2, 4, 6, 8, 10, -2, -4, -6, -8, -10, 0], k: 7, expected: -2},
    {values: [Number.MAX_VALUE, Number.MIN_VALUE, 0], k: 2, expected: Number.MIN_VALUE}
];

test.each(testCasesLargest)('finds kth largest element', ({values, k, expected}) => {
    // Arrange & Act
    const result = QuickSelect.selectKthLargest(values, k);
    // Assert
    expect(result).toEqual(expected);
});