public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
       List<int> sortedNums = new List<int>(nums);
       int[] result = new int[nums.Length];
       sortedNums.Sort();
       for(int i =0;i<sortedNums.Count;i++){
            result[i] = sortedNums.IndexOf(nums[i]);
       }

       return result;
    }
}