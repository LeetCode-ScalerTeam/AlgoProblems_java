package com.leetCode;

import java.util.*;

class TwoSumsSolution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> seenMap = new HashMap<>();
        int res[] = new int[2];
        for(int i = 0 ; i < nums.length ; i++){
            int temp = target - nums[i];
            //System.out.println("temp -> "+temp+" seenMap.containsKey(temp) ->  "+seenMap.containsKey(temp));
            if(seenMap.containsKey(temp)){
                //System.out.println("In If");
                res[0] = seenMap.get(temp);
                res[1] = i;
                return res;
            }
            else{
                //System.out.println("else ");
                seenMap.put(nums[i],i);
            }
            //System.out.println(seenMap);
        }
        return res;
    }
}