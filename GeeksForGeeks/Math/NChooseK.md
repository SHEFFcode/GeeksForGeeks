# N Choose K
## General
N choose K is the calculation of all possible ways we can choose K items out of N, such that we dont
double count the identical combinations.

This is solved with a formula C(n/k) = n! / (n! * (n - k)!)

### N Choose K Theory
What is the probability of getting **k** heads in **n** flips.

We start with total possible outcomes of flipping a coin n times.
```
? / 2 * ? / 2 * ? / 2  ... for n times is => 2^n
```
We then want to find out how many times we can get k heads out of n flips (# of favorable outcomes).
```
n * (n - 1) * (n - (k - 1)) => Once a single spot out of n spots is taken up by a heads, we keep
                               we keep reducing the # of spots another heads can be in, until k
                               reaches 1 (hence the k - 1). However this assumes that heads1 is diff
                               from heads2, which is not the case, so we need to divide this # by
                               the # of ways we can arrange k things
k * (k - 1) * (k - 2) ... 1 => This is nothing more then k!, what if we want both to be factorials?
n! / (n - k)!               => We will take n!, but divide it by n - k factorial, because we do not
                               want the n - k factorial terms as the numerator from above. This is 
                               just a nicer way to write down the solution.
```

## N choose K Example
```
P(3/8H) => What is the probability of getting heads 3 times out of 8 flips.
        => This is the same as the probability of favorable outcomes (3) over the probability of all
           possible outcomes (2 outcomes ^ 8 flips) = 256 possible outcomes.
        => Out of 8 flips, we can have any 3 that are favorable, so we have an n choose k problem
           the solution to which is (n/k) = n! / (n! * (n - k)!) = 8!/ (8! * (8 - 3)!) = 56 fav outc
P(56/2^8) = .21875
 ```

## Links
* https://www.khanacademy.org/math/precalculus/prob-comb - Khan Academy