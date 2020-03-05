package com.leetCode;

import java.util.HashMap;

public class TwoSumsSolution {
        public int[] twoSum(int[] nums, int target) {
            HashMap<Integer,Integer> hm= new HashMap<Integer,Integer>();
            for(int i=0;i<nums.length;i++)
            {
                if(hm.containsKey(target-nums[i]))
                    return new int[]  {i,hm.get(target-nums[i])};
                hm.put(nums[i],i);
            }
            throw new IllegalArgumentException("No Two Sum available for target");
        }
}
