/*

--- Spiral Order Matrix II -- Given an integer A, generate a square matrix filled with elements from 1 to A2 in spiral order. ---

Input Format:
The first and the only argument contains an integer, A.

Output Format:
Return a 2-d matrix of size A x A satisfying the spiral order.

Constraints:
1 <= A <= 1000

Examples:
Input 1:
    A = 3

Output 1:
    [   [ 1, 2, 3 ],
        [ 8, 9, 4 ],
        [ 7, 6, 5 ]   ]

Input 2:
    4

Output 2:
    [   [01, 02, 03, 04],
        [12, 13, 14, 05],
        [11, 16, 15, 06],
        [10, 09, 08, 07]   ]

*/

class Solution
{
    public List<List<int>> generateMatrix(int A)
    {
        List<List<int>> res = new List<List<int>>();
        int k = 1;
        int top = 0;
        int bottom = A - 1;
        int left = 0;
        int right = A - 1;

        for (int i = 0; i < A; i++)
        {
            List<int> r = new List<int>();
            for (int j = 0; j < A; j++)
            {
                r.Add(0);
            }
            res.Add(r);
        }

        while (k <= A * A)
        {
            for (int i = left; i <= right; i++)
            {
                res[top][i] = k;
                k++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                res[i][right] = k;
                k++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                res[bottom][i] = k;
                k++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                res[i][left] = k;
                k++;
            }
            left++;
        }
        return res;
    }
}
