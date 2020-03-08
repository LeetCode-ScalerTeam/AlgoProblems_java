/*
--- Minimum number of jumps to reach end ---

-- Problem Description --
Given an array of non-negative integers A where each element represents your maximum jump length at that position.
The initial position is the first index of the array and goal is to reach the last index of the array with the minimum number of jumps. 
Note: If it not possible to reach the last index return -1 instead.  

-- Problem Constraints --
1 <= length of the array <= 100000
0 <= A[i] <= 109

-- Input Format: The only argument given is the integer array A. --

-- Output Format: Return the minimum number of jumps to reach the last index or -1 if it is not possible. --

-- Example Input --
Input 1: A = [1, 2, 3, 4, 5]
Input 2: A = [5, 17, 100, 11]
 
-- Example Output --
Output 1: 3
Output 2: 1

-- Example Explanation --
Initial position is the first index.
From index 0 we can only jump to index 1 as first element is 0.
From index 1 we can jump to index 2 or index 3.
From index 2 we can reach the last index i.e. 4 in 1 jump.
so, the minimum number of jumps required is 3.
*/

class Solution
{
    public int solve(List<int> A)
    {
        int jumps = 0;
        int curEnd = 0;
        int curFarthest = 0;
        for (int i = 0; i < A.Count; i++)
        {
            if (i > curFarthest)
            {
                return -1;
            }
            curFarthest = Math.Max(curFarthest, i + A[i]);
            if (i < A.Count - 1 && i == curEnd)
            {
                jumps++;
                curEnd = curFarthest;
            }
        }
        return jumps;
    }
}