//Updates
//
//Gave the function a descriptive name, now it clearly conveys what the function is intended for. Was it supposed to sort numbers or do an alphabetical sort?
//Added validation and provided helpful error messages.
//Added a isAscending to make the function more reusable.


function sortCommaDelimitedNumericValues(input, isAscending = false) {
  if (typeof input !== 'string') {
    throw new Error('Input must be a string.');
  }

  const items = input.split(',').map(item => item.trim());

  if (items.some(item => isNaN(item))) {
    throw new Error('All items must be numeric for number sorting.');
  }

  const comparator = isAscending
    ? (a, b) => Number(a) - Number(b)
    : (a, b) => Number(b) - Number(a);

  return items
		 .sort(comparator)
		 .join(',');
}