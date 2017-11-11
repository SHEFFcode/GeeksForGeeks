# Runtime Complexity Analysis

## O Notation:
Upper bound of an algorithm, what is the worst case runtime.
In the case of if else statements, we pick the route that will lead to the worst time complexity.
Loop that iterates a constant number of items (not based on input size) will have a constant time O(1), rather then O(n) complexity.

![BigO](http://www.geeksforgeeks.org/wp-content/uploads/BigO.png)

## Ω Notation: 
Lower bound of an algorithm, what is the best case runtime.
Say in search of an array of 1000 elements the first element is the one we look for, the best case runtime is Ω(1).

![BigΩ](http://www.geeksforgeeks.org/wp-content/uploads/BigOmega.png)

## Θ Notation:
Bounds the function from above and below and defines the bounds of a function's runtime. 
Θ notation finds a function g(n) and 3 constants: c1, c2 and n0 where 0 <= c1*g(n) <= f(n) <= c2*g(n) for all n >= n0
Θ notation is also called the tight bound.

![BigΘ](http://www.geeksforgeeks.org/wp-content/uploads/thetanotation.png)

## Links
https://www.youtube.com/watch?v=6Ol2JbwoJp0 - Asymptotic Analysis Video
https://www.youtube.com/watch?v=iOq5kSKqeR4 - Asymptotic Analysis CS50
https://www.youtube.com/watch?v=aGjL7YXI31Q - Great explanation by Rav
https://www.khanacademy.org/computing/computer-science/algorithms/asymptotic-notation/a/big-o-notation - khan academy