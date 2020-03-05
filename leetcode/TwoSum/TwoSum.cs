/*

https://leetcode.com/problems/two-sum/

Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

-- Method Followed --
Iterate and insert elements into an Dictionary. 
Check if current element's complement exists in the table. 
If it exists, return the pair.


-- Complexity Analysis --

Time complexity : O(n)
Space complexity : O(n)

*/


public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i];
            if(numDict.ContainsKey(comp))
            {
                return new int[] { numDict[comp], i };
            }
            numDict.Add(nums[i], i);
        }
        throw new Exception("No pairs");
    }
}