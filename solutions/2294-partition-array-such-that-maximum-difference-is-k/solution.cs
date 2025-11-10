public class Solution {
    public int PartitionArray(int[] nums, int k) {

        int n = nums.Length;
        int left = 0;
        int subCounter =1;
        Array.Sort(nums);

        for(int i = 0; i<n;i++){
            if(nums[i] - nums[left] <= k) continue;
                subCounter++;
                left = i;
        }
        
    return subCounter;
    }
}


        