# Word Wrap Problem

## General
The idea is that you are given a sequence of words and are asked to print only so many words per 
line. This is a great greedy algorithm because the desired outcome on every line also gives us 
the global desired outcome.

## Example
```
input: "aaa bb cc dddd", 6
p1: ["aaa", "bb", "cc", "dddd"] => we split the string by space
p2: line = "" => create an empty line
p3: line = "aaa " => add first word and a space length is 4, max is 6
p4: line = "aaa bb" => add second word, length == max, so don't add a space, print "aaa bb"
p5: line = "" => refresh the line
p6: line = "cc " => length = 3
p7: line = "cc dddd" => length = 7, too long, don't add dddd, print "cc "
p8: line = "" => refresh the line
p9: line = "dddd " => length = 5, ran out of words
p10: line = "dddd " we still have a string to print so print "dddd "
p11: line = "" => refresh the line
```