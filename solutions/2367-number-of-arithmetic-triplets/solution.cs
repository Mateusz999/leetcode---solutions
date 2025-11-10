public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        
        HashSet<int> sets = new HashSet<int>(nums);

        int res = 0;

        for(int i = 1;i<nums.Length -1 ;i++){
            if(sets.Contains(nums[i] - diff) && sets.Contains(nums[i]+diff)) res++;
        }

return res;
    }
}