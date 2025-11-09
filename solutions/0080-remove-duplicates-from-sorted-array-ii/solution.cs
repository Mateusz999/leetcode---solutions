public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) return nums.Length;

        int startIdx = 2;

        for(int i = 2;i<nums.Length;i++){
            if(nums[i] != nums[startIdx-2]){
                nums[startIdx] = nums[i];
                startIdx++;
            }
        }
        return startIdx;
    }
}