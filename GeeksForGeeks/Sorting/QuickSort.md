# Quick Sort		
    
## General
Type of algorithm: divide and conquer
Picks and element as a pivot and partitions the given array around the picked pivot.

The pivot is usually one of the following:
First element | Last element | Random element | Median
Sorts the elements in such a way that elements to the left are smaller then pivot, and on the right are larger then pivot

Often most practical choice for sorting, in fact the sort function given to us by most languages is
a quicksort implementation.

## Runtime Complexity
* Runtime Complexity: O(n^2) at worst, but O(nlogn) on average.  
* We can be pretty sure that it will not hit it's worst time complexity if we randomize.
* Space Complexity: O(1), algorithm is done in place, and does not require any extra memory. 
  * But because it creates recursive calls, it will have O(n) extra space for stack frames.

### Additional Notes:
* Doing tail recursion optimization can limit that auxilary space to O(logn).
* The algorithm is tail recursive.

## Stability 
* Quicksort is not a stable sort.

## Visualization
* [Visualization](http://www.algomation.com/player?algorithm=58bb2ef75b2b830400b05118)

## Example
input: [|7, 2, 1, 6, 8, 5, 3, 4] => first we pick a pivot element position, in this case it will be the last element. i is the first element right of wall   ^ pivot

```
[|*7*, 2, 1, 6, 8, 5, 3, 4] => 7 is bigger then 4 so we continue, and keep the wall where it is
[|7, *2*, 1, 6, 8, 5, 3, 4] => 2 is smaller then 4, so we swap first element to the right of the wall with it, and increase the wall
[2, |7, *1*, 6, 8, 5, 3, 4] => 1 is smaller then 4, so we swap it with first element to the irght of the wall, and increase the wall
[2, 1, |7, *6*, 8, 5, 3, 4] => 6 is bigger then 4, so we continue, keep wall where it is
[2, 1, |7, 6, *8*, 5, 3, 4] => 8 is bigger then 4, so we continue, keep wall where it is
[2, 1, |7, 6, 8, *5*, 3, 4] => 5 is bigger then 4, so we continue, keep wall where it is
[2, 1, |7, 6, 8, 5, *3*, 4] => 3 is smaller then 4, so we swap with first element to the right of the wall, which is still 7, and increase the wall
[2, 1, 3, |6, 8, 5, 7, *4*] => now we get to 4 itself, so we swap 4 and first element to the right of the wall, and we have 2 sub problems to look at.
[2, 1, 3][4][6, 8, 5, 7] => we pick the two indecies, 3 and 7
[|*2*, 1, 3] => 2 is smaller then 3, so we swap it with itself, and move the wall
[2, |*1*, 3] => 1 issmaller then 3, so we swap it with first element to the right of wall, so we swap it with itself, increase wall
[2, 1, |*3*] => we swap 3 with first el to the right of wall, which is itself, so we move on to its subproblem
[|*2*, 1] => 1 is the pivot, 2 is bigger then 1, so we continue
[|2, *1*] => 1 is itself, so we swap with the element to the right of the pivot, which is itself and continue tp the subproblem
[1] [2] => 1 is now the pivot in the correct position, 2 is the subproblem
[2] => 2 is a subproblem, but onely has one element, so we end the recursion here. Similar thing happens in the other side of the array at first pivot.
```

**Note: The key here, is that we continue to manipulate the original array, so even though we have 
array [2, 1, 3][4][6, 8, 5, 7] listed here, it's really a single array in that order. We can see
that once the recursion reaches a single item on both branches, we will be sure that each element
in the original array is in the correct order**

## Links
* PS: See this article for space optimization: http://www.geeksforgeeks.org/quicksort-tail-call-optimization-reducing-worst-case-space-log-n/
* https://www.youtube.com/watch?v=COk73cpQbFQ - mycodeschool
* https://www.youtube.com/watch?v=aQiWF4E8flQ - CS50
* http://www.geeksforgeeks.org/quick-sort/ - G4G written explanation
* https://www.youtube.com/watch?v=PgBzjlCcFvc - G4g video explanation