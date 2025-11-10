public class Solution {
    public int TriangularSum(int[] nums) {
        for(int i=nums.Length;i>1;i--)
        {
            for (int j = 1; j < i; j++)
            {
                nums[j-1]=(nums[j-1] + nums[j ]) % 10;
            }  
        }
        return nums[0];
    }
}