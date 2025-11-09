public class Solution {
    public int MissingNumber(int[] nums) {
        int missing = 0;
        bool tag = false;
        Array.Sort(nums);
        for(int i =0;i<nums.Length;i++){
            if(!nums.Contains(i)) {
                missing= i;
                tag = true;
                }
            
        }   
        if(tag == false) missing = nums.Length;
        return missing;
    }
}