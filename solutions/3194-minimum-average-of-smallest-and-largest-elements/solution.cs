public class Solution {
    public double MinimumAverage(int[] nums) {
        Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;

        double average = nums[right];
        while(left < right){
            average = Math.Min(((nums[left++] + nums[right--]) / 2D), average);
        }
        return average;
    }
}