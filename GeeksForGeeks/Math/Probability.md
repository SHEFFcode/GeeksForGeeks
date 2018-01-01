# Probability
## General
Concerns itself with the odds of a certain outcomes out of many possible outcomes.

### Tidbits
* P(a ∩ b) = P(b ∩ a)
* P(a | b) != P(b | a)

### Bayes Rule
```
P(b|a) = P(a|b) * P(b)
         -------------
              P(a)
```

### Bayes Rule Derevation
```
P(a ∩ b) = P(a | b) * P(b)        => Probability of a and b happening is prob of b happening * prob a 
                                     happening given that b happened.
P(b ∩ a) = P(b | a) * P(a)        => Probability of b and a happening is prob of a happening * prob b 
                                     happening given that a happened.
P(a | b) * P(b) = P(b | a) * P(a) => Since P(a ∩ b) = P(b ∩ a), we can set these 2 equal to each other
P(a | b) = P(b | a) * P(a)        => Bayes rule
           --------------
                 P(b)
```

### Example
What is the probability that we picked a two sided coin given that 5/5 tosses were heads.
```
P(2s | 5/5H) = P(5/5H | 2s) * P(2s)  => We apply Bayes rule
               --------------------
                       P(5/5H)
P(2s | 5/5H) = 1 * 1/10                 => P(5/5H | 2s) is 1, since if we have 2 sided coin, heads will
               --------                    always come up. Probability of 2s by def is 1/10
               (41/320)

P(2s | 5/5H) = 32/41 = .780            
```

## Links
* https://www.youtube.com/watch?v=VVr8snbaxZg - Khan Academy Bayes Example
* https://www.youtube.com/watch?v=BLcgeLALLnc - Khan Academy Bayes Derevation