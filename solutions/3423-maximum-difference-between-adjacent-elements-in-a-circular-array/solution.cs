public class Solution {
    public int MaxAdjacentDistance(int[] nums) {

        int max = -1;
        for(int i =0;i<=nums.Length;i++){
            if(Math.Abs(nums[i%nums.Length] -
                nums[(i+1)%nums.Length]) > max) max =Math.Abs(nums[i%nums.Length] -
                nums[(i+1)%nums.Length]
                );
        }
        return max;
    }
}