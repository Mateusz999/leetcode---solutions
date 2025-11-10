public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        long counterSubarrays = 0;
        long sumSubArray = 0;
        long start = 0;

        for(int end = 0; end < nums.Length; end++){
            sumSubArray+=nums[end];
            while(sumSubArray*(end-start +1) >= k){
                sumSubArray-= nums[start++];
            }
             counterSubarrays += end - start + 1;
        }
        return counterSubarrays;
        
    }
}