# Merge Sort

## General
Like quicksort, mergesort is a divide and conquer algorithm. It divides the array into 2 halves,
calls itself on the two halves, and then mergest 2 sorted halves.

This algorithm is useful for sorting linked lists in n*log(n) time.

It is more efficient then sorting through the whole array right away, because it breaks the problem
into smaller and smaller subproblems, reducing the input size by 2 for every operation.

This means that on every merge steps, we are merging arrays that are smaller then the original,
and are themselves sorted, reducing time complexity compared to doing a sort on the whole array.

## Time and Space
* Time Complexity: O(n*log(n))
* Aux Space: O(n)
  * We have to have an aux array because of the merge process, we cannot merge into the original
    array without having some sort of aux array to store info temporarily.

## Stability
* Mergesort is a stable sorting algorithm

## Visualization
* [Visualization](http://www.algomation.com/player?algorithm=58bb32885b2b830400b05123)

## Example

```
input: [38, 27, 43, 3, 9, 82, 10] => len = 7, so mid is 7 / 2 = 3.5 or 4, so we pick index 3 as mid.
s1: [38, 27, 43, 3] [9, 82, 10] => split into 2 arrays @ midpoint
s2: [38, 27] [43, 3] [9, 82] [10] => 10 is by itself so it is "sorted"
s3: [38] [27] [43] [3] [9] [82] [10] => each element is alone, sor "sorted", we start to merge
s4: [27, 38] [3, 43] [9, 82] [10] => merge 1 level
s5: [3, 27, 38, 43] [9, 10, 82] => merge 1 more level
s6: [3, 9, 10, 27, 38, 43] => we are done
```

## Links
* http://www.geeksforgeeks.org/merge-sort/ - Geeks for Geeks