public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int n = nums.Length;
        while(k-- != 0){
            int ans = nums[0], idx = 0;
            for(int i = 0; i < n; i++){
                if(nums[i] < ans){
                    ans = nums[i];
                    idx = i;
                }
                    
            }
            nums[idx] *= multiplier;
        }
        return nums;
    }
}