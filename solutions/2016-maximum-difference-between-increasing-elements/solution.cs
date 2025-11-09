public class Solution {
    public int MaximumDifference(int[] nums) {
        int minNum = int.MaxValue;
        int maxDiff = -1;
        foreach (int num in nums) {
            if (num <= minNum) {
                minNum = num;
            } else {
                maxDiff = Math.Max(maxDiff, num - minNum);
            }
        }
        return maxDiff;
    }
}