# Selection Sort

## General

The sort algorithm has a sorted and unsorted sections. Simple and most intuitive.
The algorithm moves through the unsorted sections and moves items from the unsorted portion to the sorted portion, until the list is sorted.

### Space and Time
Time Complexity: O(n^2) because of two nested loops.
Auxilary Space:  O(1), it never makes more than n swaps and is used whe memory is a concern since done in place.

### Example
Input: [23, 42, 4, 16, 8, 15]

```
        |------ unsorted -----|
Pass 1: [23,  42, 4, 16, 8, 15] => Find the minimum number in the unsorted array, which is 4,  move to sorted portion of list, swapping element at 0 with smallest element.
        |srt||------unrtd-----|
Pass 2: [4, |42, 23, 16, 8, 15] => Find the minimum number in the unsorted portion of the array, which is 8.  
                                    Swap 8 with the first element in unsorted portion and move up sorted section.
        |-srt--| |---unsrtd----|
Pass 3: [4, 8 ,| 23, 16, 42, 15] => min = 15
        |----srt---| |-unsrtd--|
Pass 4: [4, 8, 15, | 16, 42, 23] => min = 16
        |----srted----| |unsrtd|
Pass 5: [4, 8, 15, 16 |, 42, 23] => min = 23
        |-------srted-----||uns|
Pass 6: [4, 8, 15, 16, 23,|  42] => since we are down to just one element in the unsorted section, we can skip this pass since we are already sorted.
```

## Links
* https://www.youtube.com/watch?v=f8hXR_Hvybo - CS50 explanation
* https://www.youtube.com/watch?v=GUDLRan2DWM - my code school explanation
* https://www.youtube.com/watch?v=xWBP4lzkoyM - selection sort G4G
* http://www.geeksforgeeks.org/selection-sort/ - G4G Explanation