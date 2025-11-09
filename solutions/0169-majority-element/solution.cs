public class Solution {
    public int MajorityElement(int[] nums) {
        int count =0,candidates = -1;
        for(int i = 0 ; i < nums.Length ; i++ ){
            if(count == 0){
                   count = 1;
                   candidates = nums[i];
            } else{
                if(candidates == nums[i]) count ++;
                else count--;
            }
        }
        return candidates;
    }
}