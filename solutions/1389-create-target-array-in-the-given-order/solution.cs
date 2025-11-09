public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        var res = new List<int>(nums.Length);


        for(int i = 0 ;i<nums.Length;i++){
            res.Insert(index[i],nums[i]);
        }

        return res.ToArray();
    }
}