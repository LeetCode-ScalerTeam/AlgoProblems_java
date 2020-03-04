class Solution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer,Integer> prefixSum = new HashMap<>();
        int i=0;
        for(int e:nums){
            prefixSum.put( target-e,i++);
        }
        i=0;
        for(int e:nums){
            Integer j=prefixSum.get(e);
            if(j!=null && j!=i)return new int[]{Math.min(j,i),Math.max(j,i)};
            i++;
        }
        return null;
    }
}