# Binary Search

## General
Always deals with a sorted set, where are are tasked to find a specific item (does it exist, and what is its position).
We do this by constantly dividing the array in half at the midpoint and checking that value against the 
value we are looking for. If the midpoint is larger then the number we are trying to find, look left,
if it is smaller, look right.

## Runtime
* Runtime Complexity: log(n)
* Auxilary Space: O(1)
* Algorithmic paradigm: divide and conquer
* To prevent integer overflow mid = low + (high - low) / 2

**NOTE: Beware of midpoint integer overflow, you can do something like this https://stackoverflow.com/questions/27167943/why-leftright-left-2-will-not-overflow**

## Visualization
* [Visualization](http://www.algomation.com/player?algorithm=56d893695abd0c03007cbf40)

## Example:

```
Input:  [0, 2, 3, 4, 10, 40, 44] => determine whether 2 is in the array
         0  1  2   3    4   5   6
Pass 1: [0, 2, 3, |4|, 10, 40, 44] => mid = 7 / 2 = 3. Look at index 3, which is value 4. 4 > 2, so look left
         0   1   2
Pass 2: [0, |2|, 3] => mid = 2 / 2 = 1. Look at index 1 = 2. 2 == 2, so we are done
```
**Important aside - log is the power to which a number must be raised to get some other number.  ex: log(100) = 2, because 10^2 = 100**

## Links:
* https://www.youtube.com/watch?v=T2sFYY-fT5o - g4g video
* http://www.geeksforgeeks.org/binary-search/ - g4g explanation
* https://www.youtube.com/watch?v=j5uXyPJ0Pew - my code school