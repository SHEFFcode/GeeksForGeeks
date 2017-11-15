# Stable Selection Sort

## General
A sorting algorithm is stable if two objects with the same keys appear in the same order after the 
sort as they were before the sort.

Any comparison based sorting algorithm which is not stable by nature can be converted into a stable
algorithm by tweaking the comparison operation to respect initial object order.

In the case of selection sort, it is not inherently stable by nature, so we need to optimize it.
To make selection sort stable, instead of swapping, we can move elements forward, and palce the min
it the newly "opened" spot like a sliding puzzle.

## Example

```
Input : 4A 5 3 2 4B 1
Selection Sort Output : 1 2 3 4B 4A 5 => you can see 4A and 4B here are 'swapped'
Stable Selection Sort Output : 1 2 3 4A 4B 5
```

**Notice: The 4A and 4B retain their order relative to one another before and after the sort.**

## Links
* http://www.geeksforgeeks.org/stable-selection-sort/ - Geeks for Geeks