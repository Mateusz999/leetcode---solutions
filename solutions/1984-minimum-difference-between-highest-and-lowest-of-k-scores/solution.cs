public class Solution {
    public int MinimumDifference(int[] nums, int k) {
    
        if(k == 1) return 0;

        Array.Sort(nums);
        int roznica = int.MaxValue;

        for(int i = 0 ;i<=nums.Length-k;i++){
            roznica = Math.Min(roznica,nums[k + i-1 ] - nums[i]);
        }

        return roznica;

    }
}