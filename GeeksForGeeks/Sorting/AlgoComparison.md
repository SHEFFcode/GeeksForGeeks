# Algo Comparison

## Selection Sort

* In place
* n^2
* Not Stable
* Sorted + unsorted sections
  * Find min right of the wall and swap with first left of the wall
* [Visualization](http://www.algomation.com/player?algorithm=58b449db0e406f04000c7133)

## Stable Selection Sort
* In place
* n^2
* Stable
* Sorted + unsorted sections
  * Find min right of the wall and remember it in temp
  * Move items from left of the wall to min to the right
  * Plop the temp left of the wall

## Insertion Sort
* In place
* n^2
* Stable
* Bad when in reverse order, good when almost sorted
* More efficient then selection sort
* Similar to playing cards
* Move the wall, and find the right place to put the first element left of the wall
  * Does not use min, just first element left of the wall, find its home rigt of wall
* [Visualization](http://www.algomation.com/player?algorithm=58b58043905a180400745cf3)

## Quick Sort
* In place 
* n^2
* Want to use tail recursion
* Not stable
* Humpty dumpty on the wall, oh how **quickly** they will fall
* Keep splitting the array similar to merge sort, BUT
  * You pivot is the last element in the array, and you want to put elements smaller to right
  * Elements bigger to left
  * and place the pivot element on the wall.
  * Then recurse down the two sections to its left and right doing the same thing
* [Visualization](http://www.algomation.com/player?algorithm=58bb2ef75b2b830400b05118)

## Merge Sort
* O(n) spae (not in place)
* nlogn runtime
* stable
* split array until u get to a single element based off a midpoint
  * We do not care about the pivot element or comparison here, just split, which gets logn
  * Once all are single element, merge them back up two at a time (O(n) space)
* [Visualization](http://www.algomation.com/player?algorithm=58bb32885b2b830400b05123)