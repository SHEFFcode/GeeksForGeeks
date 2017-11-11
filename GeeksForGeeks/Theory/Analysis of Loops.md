# Analysis of Loops

## General
The most common runtimes you will run into are:
* O(1) Constant - remains the same regardless of input size
  * <img src="https://d30y9cdsu7xlg0.cloudfront.net/png/239044-200.png" height="250">
* O(n) Linear - increases by a constant with input size
  * <img src="https://i.stack.imgur.com/iqwyt.gif" height="250">
* O(n^c) Polynomial - increases by a constant multiple of input size
  * <img src="https://introcs.cs.princeton.edu/java/41analysis/images/standard-plot.png" height="250">
* O(c^n) Exponential - runtime increases by power of input size (worst runtime possible)
  * **Red is exponential, green is polynomial for comparison.**
  * <img src="http://people.oregonstate.edu/~drayt/MTH251/slides/exp3.jpg" height="250">
* O(logn) Logarithmic - increases by a a log of input size (usually best runtime possible)
  * <img src="https://i.stack.imgur.com/qPNNp.png" height="250">
* O(log(logn)) Double Logarithmic - see graph below, increases by log of log of input size
  * <img src="http://cdn.cs50.net/2012/fall/lectures/3/notes3w/graph.png" height="250">

## Further Analysis
Here is a rundown of how you get to these runtimes:

* O(1) - Constant Loop or no loops / recursion
  * Swap Function
  * Variable Declaration
  * Mathematical Operations
  * for loop where i <= c rather than n.
    * In other words, for loop that runs constant number of times regardless of input size

* O(n) - Single non-nested loop that increments or decrements by a constant
  * for loop with i < n and i++
  * foreach loop
  * Recursive call where the next call param is incremented by a constant

* O(n^c) - Multiple nested loops with c = nesting depth
  * for loop inside another for loop
  * recursion call inside another recursion call
  * selection and insertion sort

* O(logn) - Single non nested loop and increases / decreases by multiple or division
  * for loops where i = i * c or i = i / c
  * recursion that multiplied or divides input size on every call
  * Binary search

* O(log(logn)) - For loop that increses or decreases by a power
  * loops where i = pow(i, c) or i = i^c

**Note: It is important to distinguish the increase in i to the increase in runtime based on
input size.  The two are not related, as for O(logn), i increases by a pultiple of i every loop, 
but runtime is increasing only by logn of input size (much much slower).**