# 7 Steps to solving an algorithm

## General

Algorithm will likely involve a whiteboard problem, which is there both to test your thinking, but
also your writing.  Writing neately and in a straight line takes a lot of practice, and I recommend
practicing in front of a white board as much as possible.

Remember writing fast will not impress anyone if they can't read what you wrote, and you yourself
will be much more likely to get lost. So write slow and in a straight line, which will slow you down
a little, but will win major points with the interviewer.

## Specific Steps

1.  Listen carefully to the problem, generally every detail is important to solve the problem optimally.
    * Ex: You have 2 arrays (sorted and distinct), find the # of elements in common. 
        * Sorted is an important detail, as it implies binary search.
        * Distinct saves you from having to verify that fact in the future.
    * You want to write down the input, example and runtime / space restrictions right away!

2.  Ask for an example or come up with better examples on your own.
    * Ex: A[1, 5, 15, 20] B[2, 5, 13, 30] The example is too small and is a special case. 
        * Special case because you have same number of items in each array.
        * Special case because matching elements are in the same position.
        * Special case because there is a matching element.
    * Better: A[1, 5, 15, 20, 30, 37] B[2, 5, 13, 30, 32, 35, 37, 42]
        * This is a much larger example, and you avoid special cases.

3.  Come up with a brute force algo.  
    * If first thing you have is slow and stupid, start with that.
    * **Don't code it! State the brute force and its runtime, and then go on to optimize it.**

4.  Optimize. Spend some good time doing it.
    * See [Optimization Strategies](https://github.com/SHEFFcode/GeeksForGeeks/blob/master/GeeksForGeeks/Theory/Algorithm%20Strategies.md)

5.  Walk through your algorithm. 
    * What are the variables and data structures? 
    * Why and how do they change? 
    * What is the code structure?

6.  Start Coding. 
    * Write well and neatly. Use board space wisely, give your code as much space as possible.
    * Coding style matters, braces, naming conventions, camel case, underscore etc. Just be consistent.
    * Use long discriptive variable names, they can be quite helpful, ask if you can abbrive next time.
    * Modularize your code, any conceptual chunks of code, push that off to another function.
        * Some functions you can even ask if they want you to code up, like swap for example.
          Sometimes they will say don't bother if it's not important for algo.
    * Write error cases, at least with TODOs.

7.  Test your code. 
    * Example test case is usually too big and too familiar to test the code. 
    * Walk through the code line by line, is it doing the right thing. 
        * Pretend you are compiler and look at each line of code line by line.
        * Test your code, not your algorithm.
    * Double check anything that looks weird (decrement vs incremenet etc).
    * Use small test cases, that are different from your example.
    * Go into edge cases (0, empty, null, things are the same).
    * **If you have time** try bigger test cases.
    * When you find the bug, think about what caused it.
        * You don't want to do the first fix that fixes it for that output.


# Links: 
https://www.youtube.com/watch?v=GKgAVjJxh9w&list=PLX6IKgS15Ue02WDPRCmYKuZicQHit9kFt&index=1 - hacker rank guide