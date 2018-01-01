# Combinatronics
## General
Combinatronics deals with probabilty and combinations of probabilities to determine the overall
probability of a certain outcome composed out of many different outcomes.

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

 ## Free Throw Example
 Free Throw percentage is 80%.  If I take 5 free throws, what is the probability that I will make
 3/5 free throws?

 ```
 C(5/3) => 5! / (3! * (5 - 3)!) = 10 possible combinations
 P(3/5) => .8^3 + .2^2 = .2048  * 10 = 20.48
 ```
What is the probability of getting at least 3 baskets?
```
P(3/5) + P(4/5) + P(5/5) => .8^3 * .2^2 * C(5/3) + .8 ^ 4 * .2 * C(5/4) + .8^5 * C(5/5)
                            20.48 + 40.96 + 32.77 = 94.21 to get 3 out of 5 baskets.
```

### Probability of Two Heads on Three Flips
Probability of flipping exactly two heads in three coins:
```
P(2/3) => .5 ^2 * .5 ^1 = .125 * C(3/2) = .125 * 3 = .375
```

### Probability of Three Head in Five Flips
```
P(3/5) = .5^3 * .5 ^2 * C(5/3) =  .125 * .25 * 10 = .3125
```

### Combinatronics and Probability
Card game is using 36 cards, there are 4 suits with cards numbered 1 to 9 in each suit. A hand is 
a collection of 9 cards which can be sorted in any order. What is the probability of getting all
four 1s?

```
P(all 4 1s in hand of 9)   => this is what we want to compute. # of ways in which an event can happen
                              divided by all of the possibilities (total # of hands)
C(36/9) = 36!/((9!)*(27!)) => total # of hands is an n choose k problem
  |  |  |  |32|31|30|28|29 => this shows 9 cards, out of which we already got the 4 1s, and we need
                              to see how many ways we can arrange those remaining cards. Keep in 
                              mind that we don't care about the order, so we do need to divide  by
                              the number of ways u can arrange 5 things
(32 * 31 * 30 * 28 * 29)   => This is the number of hands we can have with 4 1s.
------------------------
(5 * 4 * 3 * 2 * 1)

201,376 / 94,143,280 = 0.00214

```

## Links
* https://www.khanacademy.org/math/precalculus/prob-comb - Khan Academy