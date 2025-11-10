public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {

         List<int> less = new List<int>();
          List<int> moreEqual = new List<int>();
          List<int> pvt = new List<int>();

        for(int i = 0;i<nums.Length;i++){
            if(nums[i] < pivot) {
                less.Add(nums[i]);

                }
            
            if(nums[i] > pivot){
               moreEqual.Add(nums[i]);
            }
            if(nums[i] == pivot) pvt.Add(nums[i]);
             
        }

          less.AddRange(pvt);
          less.AddRange(moreEqual);

         int[] array = less.ToArray();
        return array;
    }
}