# Binary Search Tree
## General
Binary search tree is a tree based data strucutre which has the following properties:
* Left subtree contains only the nodes that are less then the node's key
* Right subtree contains only the nodes that are more then the node's key
* Left and Right subtree must also be binary search trees.

<img stc="https://www.geeksforgeeks.org/wp-content/uploads/gq/2014/01/200px-Binary_search_tree.svg_.png" height="250">

## Searching The Tree
To search the binary search tree, you must first compare the item we are trying to find with the 
root. If it is the root, return it, if key is greter then root we go right, if less we go left.

## Insertion
```
         100                               100
        /   \        Insert 40            /    \
      20     500    --------->          20     500 
     /  \                              /  \  
    10   30                           10   30
                                              \   
                                              40
```

## Links
* https://www.geeksforgeeks.org/binary-search-tree-set-1-search-and-insertion/ - G4g