public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Contains(target)){
            for(int i = 0; i< nums.Length;i++){
                if(nums[i] == target) return i;
        }
        }else {
              for(int i = 0; i< nums.Length;i++){
                if(nums[i] > target) return i;
        }
        }
        return nums.Length;
        
    }
}