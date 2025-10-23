const MergeSort = require('../../../src/JavaScript/Sorting/merge_sort');

const ascendingTestCases = [
  { input: [3, 1, 2], expected: [1, 2, 3] },
  { input: [2, 2, 2], expected: [2, 2, 2] },
  { input: [5, 4, 4, 1], expected: [1, 4, 4, 5] },
  { input: [-3, -6, -1, -5], expected: [-6, -5, -3, -1] },
  { input: [], expected: [] },
  { input: [4.2, 6.9, 17.03, 1.002, -5.9], expected: [-5.9, 1.002, 4.2, 6.9, 17.03] },
  { input: ['mouse', 'frog', 'cat'], expected: ['cat', 'frog', 'mouse'] }
];

test.each(ascendingTestCases)('sorts %o to %o', ({ input, expected }) => {
  // Arrange
  const sorter = new MergeSort();
  // Act
  const result = sorter.sortAscending(input);
  //Assert
  expect(result).toEqual(expected);
});

const descendingTestCases = [
  { input: [3, 1, 2], expected: [3, 2, 1] },
  { input: [2, 2, 2], expected: [2, 2, 2] },
  { input: [5, 4, 4, 1], expected: [5, 4, 4, 1] },
  { input: [-3, -6, -1, -5], expected: [-1, -3, -5, -6] },
  { input: [], expected: [] },
  { input: [4.2, 6.9, 17.03, 1.002, -5.9], expected: [17.03, 6.9, 4.2, 1.002, -5.9] },
  { input: ['cat', 'frog', 'mouse'], expected: ['mouse', 'frog', 'cat'] }
];

test.each(descendingTestCases)('sorts %o to %o', ({ input, expected }) => {
  // Arrange
  const sorter = new MergeSort();
  // Act
  const result = sorter.sortDescending(input);
  // Assert
  expect(result).toEqual(expected);
});