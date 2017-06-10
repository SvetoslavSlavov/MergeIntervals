# MergeIntervals

Merge intervals
Create a program that merge all overlapping intervals in a collection of intervals.
Given is a collections of intervals. Some of them overlap the others. Merge all overlapping intervals in a new collection of intervals.
The program gets from the standard input a collection of intervals (e.g. arrays with two elements each) and prints 
the new collection of intervals in the following format [x1, x2], [x3, x4], .., [xM, xN]. If there are no overlapping intervals prints -1.

# Example
Input

[1,3], [2,6], [8,10], [15,18] </br>
[1, 3], [5,7], [8,10]	

Output
	
[1,6], [8,10], [15,18] </br>
	 -1
