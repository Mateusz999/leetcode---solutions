public class Solution {
    public int CountSubarrays(int[] nums) {
        int cnt = 0;
        for (int i = 1; i + 1 < nums.Length; ++i) {
            if ((nums[i - 1] + nums[i + 1]) * 2 == nums[i]) {
                ++cnt;
            }
        }
        return cnt;
    }
}
