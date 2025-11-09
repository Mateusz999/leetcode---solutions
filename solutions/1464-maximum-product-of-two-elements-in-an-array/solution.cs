public class Solution {
    public int MaxProduct(int[] nums) {
        int max =0;
        int max2=0;

        foreach(int num in nums){
            if(num > max){
                max2 = max;
                max = num;
            } else if(num > max2) max2 = num;
        
        }

        return (max-1)*(max2-1);
    }
}