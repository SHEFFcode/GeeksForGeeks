# Combinatronics
## General
Combinatronics deals with probabilty and combinations of probabilities to determine the overall
probability of a certain outcome composed out of many different outcomes.

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
P(3/5) + P(4/5) + P(5/5) => .8^3 + .2^2 * C(5/3) + .8 ^ 4 * .2 * C(5/4) + .8^5 * C(5/5)
                            20.48 + 40.96 + 32.77 = 94.21 to get 3 out of 5 baskets.
```

### Probability of Two Heads on Three Coins
