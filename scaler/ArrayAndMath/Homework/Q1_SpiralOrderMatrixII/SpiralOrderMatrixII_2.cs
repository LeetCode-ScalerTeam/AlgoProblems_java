public class Solution
{
    public List<List<int>> GenerateMatrix(int A)
    {
        List<List<int>> result = new List<List<int>>();

        for (int x = 0; x < A; x++)
        {
            List<int> r = new List<int>();
            for (int y = 0; y < A; y++)
            {
                r.Add(0);
            }
            result.Add(r);
        }

        int i = 0, j = 0;
        for (int k = 1; k <= A * A; k++)
        {
            result[i][j] = k;
            bool Up = i == 0 ? false : result[i - 1][j] != 0 ? false : true;
            bool Down = i == A - 1 ? false : result[i + 1][j] != 0 ? false : true;
            bool Left = j == 0 ? false : result[i][j - 1] != 0 ? false : true;
            bool Right = j == A - 1 ? false : result[i][j + 1] != 0 ? false : true;


            if (Down && Right || !Left && !Up && !Down && Right)
            {
                j++;
            }
            else if (Down && Left || !Left && !Up && Down && !Right)
            {
                i++;
            }
            else if (Up && Left || Left && !Up && !Down && !Right)
            {
                j--;
            }
            else if (Up && Right || !Left && Up && !Down && !Right)
            {
                i--;
            }
        }
        return result;
    }
}