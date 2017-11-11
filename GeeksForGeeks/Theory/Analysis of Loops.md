# Analysis of Loops

## General
The most common runtimes you will run into are:
* O(1) Constant
  * ![Constant](https://d30y9cdsu7xlg0.cloudfront.net/png/239044-200.png  =250x){:height="250px"}
* O(n) Linear
  * ![Linear](https://i.stack.imgur.com/iqwyt.gif)
* O(n^2) Quadratic
  * ![Quadratic](https://introcs.cs.princeton.edu/java/41analysis/images/standard-plot.png  =250x)
* O(logn) Logarithmic
  * ![Logarithmic](https://i.stack.imgur.com/qPNNp.png  =250x)
* O(log(logn)) - see graph below, it's even more log then log
  * ![DoubleLog](http://cdn.cs50.net/2012/fall/lectures/3/notes3w/graph.png  =250x)

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