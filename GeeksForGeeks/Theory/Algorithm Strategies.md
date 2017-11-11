# Algorithm Optimization Strategies

## General
There are three strategies for approaching an algorithm question:

1. BUD
2. Space / Time Tradeoffs
3. DIY

## BUD

BUD Principle of optimization involves 3 criteria to be optimized:
* **B**ottlenecks
* **U**nnecessary Work
* **D**uplicated work 

### Bottleneck:
Ex: 2 arrays, find the number of elements in common between 2 arrays. We take each element in A1 and check each element in A2.

Brute Force:
* Set up nested for loops and iterate through A[] and B[], comparing each value of A to each value of B.

Where is the bottleneck? 
* The bottleneck is in searching through B array to see if contains an element from A for ever element in A.
* It necessitates a runtime of O(A * B).

How can we reduce it?  
* Introduce a hashset where the element in B is key, and value is 1. 
* Then run through each element in A, and if it is in the hash set from B increment its value.
* This optimization gets us to an O(A + B) algorithm.
* To give an example that is not similar to duplicated work:
    * If bottleneck is search, we can use a more efficient search algorithm then checking each element.

### Unnecessary Work;

Ex: a^3 + b^3 = c^3 + d^3, find all solutions where a, b, c and d are integers between 1 and 1000.

Brute Force:
* Check each value of a, b, c and d from 1 to n and see if the equation holds true.

Where is unnecessary work?
* The unnecessary work is in solving for d by iterating from 1 to n.  D will have to be a^3 + b^3 - c^3.
* **Note the work here is not duplicated, but unnecessary to getting the solution.  We KNOW we don't 
    need to do this work, rather then trying to do it more than once.**

How can we reduce it?
* We can say hey, if we find a, b, c we solve for d, and if it's a valid number we break, as there can't be
     any more then 1 d solution for this set of a, b and c.
* This turns removes the fourth level of nesting, reducing time complexity from n^4 to n^3

### Duplicated Work:
Ex: a^3 + b^3 = c^3 + d^3, same as above.

Brute Force:
* Same as above. Check each value of a, b, c and d from 1 to n and see if the equation holds true.

Where is duplicated work?
* Duplicated work is to have to resolve for various values of n^3.
    * We can store those results in a hash set and reference them if we need them again.


## Space / Time Tradeoffs

Using a different data structure (usually a hashtable). So you are using more space, but hopefully in less time.

## DIY

Ex. Given an array of numbers, give the # of items in the longest increasing subsequence.

Burte force:
* Run a recursive algorithm for ever fewer number of items in an array and see if they are increasing.
* Really slow, with a lot of duplicate work.
* Have your brain do the work, see how it does it, and then write an algo based on how the brain naturally does it.

Solution:
* Create a data structure as an array of same size as the input and set two pointers.
* Fill out the data structure by comparing the pointer i to pointer j, and increasing the LIS # as you go.
* Find the max LIS value and print it.
* If the solution in your brain is much faster then what you can do in code, chances are your code is inefficient
    * Analyze how your brain thinks of it and try to mimic that in an algorithm.
* For complete solution see LIS [here](https://github.com/SHEFFcode/GeeksForGeeks/blob/master/GeeksForGeeks/Dynamic%20Programming/LIS.cs).


# Links:
https://www.youtube.com/watch?v=84UYVCluClQ&index=2&list=PLX6IKgS15Ue02WDPRCmYKuZicQHit9kFt - hacker rank guide