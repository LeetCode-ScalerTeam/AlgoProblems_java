package com.leetCode;

import java.util.Arrays;

public class ProductExceptSelf {
    public static int[] productExceptSelf(int[] nums) {
        /*       1 2 3 4
    Assign first array Value  as 1 and rest multiplication of prev
     Step 2: 1 (1) (2*1) (3*2*1)
    Assign last array Value  as 1 and rest multiplication of prev
    Step 3 :  (4*3*2)   (4*3)   (4)      1
    Finally Multiply both array Value:

    1       2     3     4
    1      (1)  (2*1)   (3*2*1)
    (4*3*2) (4*3) (4)   (1)
    24      12    8      6

   */
        int[] leftProd=new int[nums.length];
        leftProd[0]=1;
        for(int i=1;i<nums.length;i++)
            leftProd[i]=leftProd[i-1]*nums[i-1];
        int[] rightProd=new int[nums.length];
        rightProd[nums.length-1]=1;
        for(int i=nums.length-2;i>=0;i--)
            rightProd[i]=rightProd[i+1]*nums[i+1];
        for(int i=0;i<nums.length;i++)
            leftProd[i]=leftProd[i]*rightProd[i];
        System.out.println(Arrays.toString(leftProd));
        return leftProd;

    }

    public static void main(String[] args) {
        productExceptSelf(new int[]{1,2,3,4});
    }
}
