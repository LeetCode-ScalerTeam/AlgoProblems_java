/*
--- Rotate Matrix ---

-- Problem Description --
You are given an n x n 2D matrix representing an image. 
Rotate the image by 90 degrees (clockwise). 
You need to do this in place. 
Note: if you end up using an additional array, you will only receive partial score. 

-- Problem Constraints --
1 <= n <= 1000

-- Input Format --
First argument is a 2D matrix of integers

-- Output Format --
Return the 2D rotated matrix.

-- Example Input --
Input 1:
[
    [1, 2],
    [3, 4]
]

-- Example Output --
Output 1:
[
    [3, 1],
    [4, 2]
]

-- Example Explanation --
After rotating the matrix by 90 degree:
1 goes to 2, 2 goes to 4
4 goes to 3, 3 goes to 1
 
*/

class Solution
{
    public void solve(List<List<int>> A)
    {
        int N = A.Count - 1;
        for (int i = 0; i < A.Count / 2; i++)
        {
            for (int j = i; j < N - i; j++)
            {
                int temp = A[i][j];
                A[i][j] = A[N - j][i];
                A[N - j][i] = A[N - i][N - j];
                A[N - i][N - j] = A[j][N - i];
                A[j][N - i] = temp;
            }
        }
    }
}