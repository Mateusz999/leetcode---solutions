public class Solution {
    public int FindGCD(int[] nums) {
        int max = nums.Max();
        int min = nums.Min();
        while(min!=max){
            if(max>min){
                max-=min;
            }else min-=max;
        }

        return max;
    }
}