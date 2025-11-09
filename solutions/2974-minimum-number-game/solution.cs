public class Solution {
    public int[] NumberGame(int[] nums) {
        int[] res = new int[nums.Length];
        Array.Sort(nums);
        for(int i = 1 ;i<nums.Length;i+=2){
            res[i-1] = nums[i];
            res[i] = nums[i-1];
        }

        return res;
    }
}