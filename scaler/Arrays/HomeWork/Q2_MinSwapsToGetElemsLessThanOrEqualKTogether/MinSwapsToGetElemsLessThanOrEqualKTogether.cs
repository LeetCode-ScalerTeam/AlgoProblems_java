/*
--- Minimum swaps required to bring all elements less than or equal to k together ---

-- Problem Description --
Given an array of integers A and an integer B, find and return the minimum number of swaps required to bring all the numbers less than or equal to B together. Note: It is possible to swap any two elements, not necessarily consecutive. 

-- Problem Constraints--
1 <= length of the array <= 100000
-109 <= A[i], B <= 109

-- Input Format --
The first argument given is the integer array A.
The second argument given is the integer B.

-- Output Format: Return the minimum number of swaps. --

-- Example Input --
Input 1: A = [1, 12, 10, 3, 14, 10, 5], B = 8
Input 2: A = [5, 17, 100, 11], B = 20

-- Example Output --
Output 1: 2
Output 2: 1

-- Example Explanation --
Explanation 1:
A = [1, 12, 10, 3, 14, 10, 5]
After swapping  12 and 3, A => [1, 3, 10, 12, 14, 10, 5].
After swapping  the first occurence of 10 and 5, A => [1, 3, 5, 12, 14, 10, 10].
Now, all elements less than or equal to 8 are together.
*/

class Solution {
    public int solve(List<int> A, int B) 
    {
        int c = 0; 
        for (int i = 0; i < A.Count; i++) 
        if (A[i] <= B)
        {
            c++;
        }
        int outOfRange = 0; 
        for (int i = 0; i < c; i++) 
        {
            if (A[i] > B)
            {
                outOfRange++;
            }
        }
        int result = outOfRange; 
        for (int i = 0, j = c; j < A.Count; ++i, ++j) 
        {
            if (A[i] > B)
            {
                outOfRange--;
            }

            if (A[j] > B)
            {
                outOfRange++;
            }
            result = Math.Min(result, outOfRange); 
        } 
        return result;
    }
}
