public class Solution {
    public int SubsetXORSum(int[] nums) {
       return xorsum(nums,0,0);
    }

    private int xorsum(int[]nums, int i, int curr){
        if(i>=nums.Length) return curr;

        return xorsum(nums,i+1,nums[i] ^ curr)+ xorsum(nums,i+1,curr);
    }
}