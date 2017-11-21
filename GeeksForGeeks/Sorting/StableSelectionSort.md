# Stable Selection Sort

## General
A sorting algorithm is stable if two objects with the same keys appear in the same order after the 
sort as they were before the sort.

Any comparison based sorting algorithm which is not stable by nature can be converted into a stable
algorithm by tweaking the comparison operation to respect initial object order.

In the case of selection sort, it is not inherently stable by nature, so we need to optimize it.
To make selection sort stable, instead of swapping, we can move elements forward, and palce the min
it the newly "opened" spot like a sliding puzzle.

## Space and Time
* Time Complexity: O(n^2) because of two nested loops.
* Auxilary Space:  O(1), is used whe memory is a concern since done in place.

## Example

```
Input : 4A 5 3 2 4B 1
Selection Sort Output : 1 2 3 4B 4A 5 => you can see 4A and 4B here are 'swapped'
Stable Selection Sort Output : 1 2 3 4A 4B 5 => here 4A and 4B are in same relative position.
```

```
input: [38, 27, 43, 3, 9, 82, 10] => len = 7
        i   j1  j2 j3 j4  j5  j6
p1:    [38, 27, 43, 3, 9, 82, 10] => lowestItemIndex = i, j1, j2, j3 aka 3. liiValue = input[lii] = 3
p2:    [38, 27, 43, 3, 9, 82, 10] => while lii < i, move items to the right
p2.5:  [38, 38, 27, 43, 9, 82, 10] => 2 38s here because we moved items to the right, but original is still 38
p3:    [3, 38, 27, 43, 9, 82, 10] => replace item at i with the liiValue, move i
            i  j1  j2 j3  j4  j5 
p4:    [3, 38, 27, 43, 9, 82, 10] => repeat this process untill ur i is at j4 position. At that point you should be stable sorted.
```

**Notice: The 4A and 4B retain their order relative to one another before and after the sort.**

## Links
* http://www.geeksforgeeks.org/stable-selection-sort/ - Geeks for Geeks