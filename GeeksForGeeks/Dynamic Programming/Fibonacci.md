# Fibonacci [Recursion / Memoization / Tabulation]

## General
There are three different ways to solve fibonacci sequence presented here:
* Pure Recursion
  * Advantage - simplicty, single line function
  * Disadvantage - runtime is O(2^n) without DP.
* Memoization
  * Advantage - O(n)
  * Disadvantage - more complex to write, more space
* Tabulation
  * Advantage - O(n)
  * Disadvantage - need to computer the whole table before giving the solution

## Approach

### Pure Recursion
* We know that fib of 0 is 0 and fib of 1 is 1.
* If we are asked to calculate any of those, we just return desiredFib
* IF we are asked to calculate any other number, we recursively call (fib - 1) + (fib - 2) until we
  get to the base case above, then fill out the rest of fib.

It looks something like this:
```
                                            fib(4)
                                          /       \
                                    fib(3)         fib(2)
                                  /       \       /      \
                            fib(2)   fib(1)   fib(1)    fib(0)
                            /  \
                        fib(1) fib(0)
```
**Note: We calculate the same subproblem [fib(2)] more than once, which points to DP solution.**

### Memoization
* We use the strategy above, but introduce a data structure to keep results
* Here on the right we actually calc and fill in the table values for fib(2), fib(3)

```
Data Structure: DS
 _________________
| fib(4)|    ?    |
| fib(3)|    2    |
| fib(2)|    1    |
| fib(1)|    1    |
| fib(0)|    0    |
-------------------
                                            fib(4)
                                          /       \
                                    fib(3)         fib(2)
                                  /       \       /      \
                        DS[fib(2)  DS[fib(1)]   fib(1)    fib(0)
                            /  \
                  DS[fib(1)]  DS[fib(0)]
```
**Note: we don't have to fill in fib of 4, since we will not use it to come up with a solution in a memoization approach.**

### Tabulation
* We apply a whole new strategy, where our goal is only to fill out the data table with values.
* We will fill the whole table first, and then look at the top for the result.
* This is one of the disadvantages of tabulation, we always have to fill out the whole table to come up with the result.

```
Data Structure: DS
 _________________
| fib(4)|    3    | => return as result
| fib(3)|    2    |
| fib(2)|    1    |
| fib(1)|    1    |
| fib(0)|    0    |
-------------------
```
