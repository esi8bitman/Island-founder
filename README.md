# Island Founder

This a famous problem... ☻

You are given a 2D grid of 0s and 1s, where 0 represents water and 1 represents land. An island is a group of connected land cells that are adjacent horizontally, vertically (not diagonally). You need to implement a function that returns the size of the largest island. See if you can optimise your code too.
Your task is to write a function that takes the 2D grid as input and returns the size of the largest island.

You can implement this in any language of your choice. You can also implement in Unity or Unreal and output in the console.


For example:


Input: [ [1, 1, 0, 1, 0],
         [1, 1, 0, 0, 0],
         [0, 0, 1, 0, 0],
         [0, 0, 0, 1, 1]
       ]

Output: Largest island size: 4

Input: [ [1, 0, 0, 0, 0, 0, 0], 
       [0, 1, 0, 0, 0, 0, 0], 
       [0, 1, 1, 0, 0, 0, 0], 
       [0, 0, 0, 1, 1, 1, 0], 
       [0, 0, 0, 1, 1, 0, 0], 
       [0, 0, 0, 1, 1, 0, 0] 
       ]


Output:
Largest island size: 7

So I write a code with recurive algorithm to found all islands!! ^-^ !!
