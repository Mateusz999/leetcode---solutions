public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int leftSum = 0, rightSum = 0, n = nums.Length;
        foreach(int num in nums) rightSum += num;
        for(int i = 0; i < n; i++) {
            int val = nums[i];
            rightSum -= val;
            nums[i] = Math.Abs(leftSum - rightSum);
            leftSum += val;
        }
        return nums;  
    }
}