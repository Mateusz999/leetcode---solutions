public class Solution {
    public void SortColors(int[] nums) {
        int[] counting = new int[4];
        int k = 0;
        
        foreach(int digit in nums) counting[digit]++;
        
        for(int i =0;i<=2;i++){
            for(int j =1;j<=counting[i];j++) nums[k++] = i;
        }
    }
}