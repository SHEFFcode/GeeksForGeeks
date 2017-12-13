# Longest Pallindromic Subsequence

## Theory
LPS problems start by giving a string aka a sequence, and asking what is the longest pallindromic subsquence.
In other words we are trying to find the longest pallindrome we can make while still keeping the words
in the same order.

For example a sequence that is given to you BBABCBCAB would return 7 (BABCBAB).

The most intuitive sollution is to generate all subsequences and find the lognest pallindromic one
using recursion. It can be through of as follows:
```
                    L(0, 6)
                /           \
            L(0, 5)         L(1, 6)
            /   \           /     \
        L(0, 4) L(1, 5) L(1 ,5)   L(2, 6)
```

As you can see we have the optimal substrcuture, and repeating subproblems here (as L(1,5) gets
computer twice at this level).  This means we can use dynamic programming.  In fact we can use
a matrix similar to what we did for longest common substring between the current string and
a reversed string.

## Runtime
* Dynamic Programming O(n^2) => polynomial
* Recursive O(2^n) => exponential

## Implementation

To implement the dynamic programming solution we think of the sequence in terms of array indecies
for each character and set up two pointers i and j to traverse the sequence and fill out the longest
pallindrome sequence between pointers maxtrix below for sequence BBABCBCAB:

```
       B   B   A   B   C   B   C   A   B  
       0   1   2   3   4   5   6   7   8 <-j pointers
      __________________________________
B  0 | 1   2   2   3   3   5   5   5   7 |
B  1 |     1   1   3   3   3   3   5   7 |
A  2 |         1   1   1   3   3   5   5 |
B  3 |             1   1   3   3   3   5 |
C  4 |                 1   1   3   3   3 |
B  5 |                     1   1   1   3 |
C  6 |                         1   1   1 |
A  7 |                             1   1 |
B  8 |                                 1 |
      ----------------------------------
   ^ i pointers
```

**Note: The bottom half of the matrix is not filled out, as it will be a mirror of the top half, since
we have the same letters going across and down.**

**Catch: Take a look at the second B, or L[0, 1]. It has nothing below to left, and its length is 2
in this special case we just set it's value to 2.**

1) First we fill out 1 across the table, as any character individually is considered a pallindrome
by definition.
2) We set our pointers i and j such that we can move them around and keep a constant distance between
them, so in this case i will be [i = 0, j = 1], [i = 1, j = 2], [i = 2, j = 3] and so on for 1 char
distance.  This distance will increase on every loop until we reach length of the string.
  * This gets a little tricky, as we need to stop i from looping past the end of the string,
    which we can achieve by stopping i loop at i = len - const dist + 1 (+1 to account for dist being
    1 based counting and i loop being 0 based counting).
3) We will then derive the longest possible common subsequence based off previousely computed results
as follows:
  * If the two chars are the same and if the distance between our pointers is 1 
    (or length of considered substring is 2) we set the cell to equal 2 (since the 2 chars are 
    right next to each other and are the same).
  * If the distance between pointers is more then 1 and they are the same we take the value in the
    cell diagonal and to the bottom left and add 2 to it.  2 is the number of letters we are adding
    to longest pallindrome possible between pointers (if letters are same we add 2 letters to length)
    and down and to the left is to get the value of longest possible pallindrom for chars between
    pointers exclusive of the pointers themselves.
  * If the latters are different, we take the max of the cell to the left or the cell down, as those
    represent the longest possible pallindrome between pointers including only one or the other,
    since they don't match we only care including which one will give us the longest pallindrome.
4) Once we test the distance between pointers being the length of the string we stop and return the 
value in the top right cell as it will always be the longest pallindrome.

**TODO: Write out the longest pallindrome allong the following lines:**
* 5) To write out the sequence with the longest pallindrome find the lowest box with highest number,
then move diagonally down and to the left. If that box is the highest of bottom or left print it, move
diagonally down.  If it is just max move left and don't print the letter. Once you hit the middle
where i and j are the same, just write out the same letters you have to the left so far.

## Links
* https://www.youtube.com/watch?v=TLaGwTnd3HY - g4g