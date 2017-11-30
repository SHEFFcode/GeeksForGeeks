# Djikstras Shortest Path

## General
* Works in directed or undirected, but only with non negative weights
* Issue is it might start looking in the wrong way if those weights are longer, in other words
  if the substructure is not such that locally optimal results give globally optimal solutions.

## Space and Time
* Runtime complexity is O(Elog(v)), with E being edges, and v is vertecies if use a binary heap
  * If you use an adj list the runtime is O(V^2)
* Space: O(n) for the queue to hold the binary heap

## Example
```
              3
          s ----- c
        7/ \2      \
          3         \ 2
        a - b       l
        4\ /4     4/ \4
          d       i - j 6
        5/ \1     4\ /4
        f - h       k
          3  \2    / 5
              g - e
                2

     v | d       | p (vertex, distance, parent)
p1:  S | 0       | s     => initial state, first vertex is always 0 away from iteself
p2:  A | i, 7, 5 | s, b  => as we go to A, the path is 7 through vertex s, but 5 through b
p3:  B | i, 2    | s     => path is 2 to get to b
p4:  C | i, 3    | s     => path is 3 to get to c
p5:  D | i, 6    | s, b  => path is 3 to get to d through b

This continues through the graph, I don't have the patience to get through all of it.
```

## Links
* https://www.youtube.com/watch?v=GazC3A4OQTE - computerphile
* https://www.youtube.com/watch?v=U9Raj6rAqqs - Joe James
* https://www.youtube.com/watch?v=qx9sJ3O3JM0 - bootstrappers