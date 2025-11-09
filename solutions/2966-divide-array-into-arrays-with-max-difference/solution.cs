public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
          if (nums.Length % 3 != 0) return new int[0][];

        int numsLength = nums.Length;
        int resultArraySize = numsLength / 3;
        int[][] resultArray = new int[resultArraySize][];
        bool isCase = false ;
        int idx = 0;
   
        Array.Sort(nums);

        for(int i = 0 ;i<numsLength;i+=3){
            if( nums[i+2] - nums[i]  <=k){
                    resultArray[idx] = new int[] { nums[i], nums[i + 1], nums[i + 2] };
                    idx++;
               } else{
                return new int[0][];
               }
        }

        return  resultArray;
    }
}