public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int length = nums.Length;
        int[] pref = new int[length+1];

        for(int i = 0;i<queries.Length;i++){
            int left = queries[i][0];
            int right = queries[i][1];
            
            pref[left]++;
            if(right+1 < length) pref[right+1]--;
        }

        int prefixSumy = 0;

        for(int j = 0 ; j<length;j++){
            prefixSumy+=pref[j];
            if(nums[j] > prefixSumy) return false;
        }
    return true;
    }
}