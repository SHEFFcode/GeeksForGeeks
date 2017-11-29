# Interpolation Search

## General
* Interpolation search is an optimization of binary search that is used when array is both sorted and uniformly distrubuted.

## Space and Time
* Runtime Complexity: O(log(log(n))) in favorable cases
  * O(n) in worst case.
* Space Complexity: O(1)

## Implementation: 
* Uses linear interpolation function for find pos (instead of mid)
* pos = start + ((end - start) / (A[end] - A[start]) * (element - A[start]))
* after that you use pos as you would have used a mid variable in binary search.

## Example
```
i: [1, 2, 4, 6, 7, 10, 11, 14, 15] => sorted && uniformly distrubuted array, find 4.
p1:[1, *2*, 4, 6, 7, 10, 11, 14, 15] => pos = 0 + ((8 - 0) / (15 - 1) * (4 - 1)) = 8 / 14 * 3 = 1.71 or 1. => check A[1] = 2, is smaller then 4, so we do start = pos + 1 = 2
p2:[1, 2, *4*, 6, 7, 10, 11, 14, 15] => pos = 2 + ((8 - 2) / (15 - 4) * (4 - 4)) = 2 + ((6 / 11) * 0) = 2 + 0 = 2, check A[2], is equal to 4, so we return it's position, which is 2.
```

## Links:
* http://www.geeksforgeeks.org/interpolation-search/ - g4g explanation
* https://www.youtube.com/watch?v=-MPTAD4z0gY - code whoop explanation