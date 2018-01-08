# Dyanmic Programming:
Dynamic programming is an algorithmic paradigm that solves a given complex problem by breaking it down into sub problems and stores results 
of subproblems to avoid computing the same results again.

In order to use dynamic programming, the problem must have the following two properties:
1) Overlapping Subproblems - something is being recomputed more then once.
2) Optimal Substructure - optimal solution to the whole problem can be obtained through optimal solutions to subproblems.

## Overlapping Subproblems: the resutls of an operation are needed again and again. In DP, computer results are stored and not recomputed.
Example: Binary search does not have common subproblems, while fibbonaci does.

## Optimal Substrcuture:
Example of not having optimal substrcuture:Something that does not have an optimal substructure is the longest path solution below. 

![Longest Path](http://www.geeksforgeeks.org/wp-content/uploads/LongestPath.gif "Longest Path")

On the graph the longest path from q to t is either q->s->t or q->r->t, however the longest path from q to r is q->s->t->r and from r to t is r->q->s->t, which would produce a cycle if used as solutions to the longest q to t path.

## IE:

                          fib(6)
                        /        \
                fib(5)            fib(4)
                /       \          /    \
             fib(4)             fib(3)   fib(3)  fib(2)
             /    \  
           fib(3) fib(2)

Etc. You can see how the results of the same calulation are getting recuomputed time and time again.

## Remembering the results of subproblems can be done in one of two ways:
* a) Memoization (Top Down) - same as recursive algo, but it checks a hash table before doing any computations. Table is filled on demand.
* b) Tabulation (Bottom Up) - builds a table from the bottom up and returns the last item from the table. All values in the table must be filled.





