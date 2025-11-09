public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left=0,maxSub=0,counterOfZeros=0;

        for(int right = 0;right<nums.Length;right++){
            if(nums[right] == 0) counterOfZeros++;

            while(counterOfZeros>k) {

            if(nums[left] == 0) counterOfZeros--;
            left++;
            }
            
            maxSub =(maxSub > right-left+1)? maxSub : right-left+1;

        }
        return maxSub;
    }
}