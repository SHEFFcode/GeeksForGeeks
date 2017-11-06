# Word Wrap Problem.

## Theory
Word wrap problem gives you a string of letters separated by a space and asks you to print out the 
words in such a way that no line is over a certain number of characters.

There are two ways to approach this solution: greedy algorithm and a dynamic problem algorithm.

### Greedy Algorithm

The greedy algorithm approach is used by most word processors. Lets consider it first:

Input: ['aaa', 'bb', 'cc', 'dddd']. Max line length is 6.

```
    1   2   3   4   5   6
1   a   a   a  ' '  b   b
2   c   c  ' '
3   d   d   d   d  ' ' ' '
```

**Note: this is not the most tidy solution based off the cost function, which is discussed below.**

### Dynamic Programming Algorithm

