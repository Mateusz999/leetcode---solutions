public class Solution {
    public int LongestSubarray(int[] nums) {
        int n = nums.Length,i=0,j=0;
        int maximum =0,count=0;

        while(j<n){
            if(nums[j] == 0) count++;
            while(count > 1){
                if(nums[i] == 0)  count--;
            i++;

            }
            maximum = Math.Max(maximum, j-i);
            j++;
        }


        return maximum;
    }
}