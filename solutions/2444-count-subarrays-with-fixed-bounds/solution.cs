public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long cnt = 0;
        long k = -1;
        long prevMin = -1;
        long prevMax = -1;
        for(int i = 0;i<nums.Length;i++){
            if(!(nums[i] >= minK && nums[i] <= maxK)) k = i;
            if(nums[i] == minK) prevMin = i;
            if(nums[i] == maxK) prevMax = i;
            cnt += Math.Max(0, Math.Min(prevMin, prevMax) - k);
        }
   
        return cnt;
    }
}