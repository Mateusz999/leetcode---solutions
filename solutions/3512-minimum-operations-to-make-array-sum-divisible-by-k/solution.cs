public class Solution {
    public int MinOperations(int[] nums, int k) {
        int sumOfArray = 0;
        int movesCount =0;
        for(int i =0; i<nums.Length;i++){
            sumOfArray += nums[i];
        }
        
        
          
        
        return sumOfArray % k;;
    }
}