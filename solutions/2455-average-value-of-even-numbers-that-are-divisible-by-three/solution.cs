public class Solution {
    public int AverageValue(int[] nums) {
        int sum = 0;
        int counter = 0;

        for(int i = 0 ;i <nums.Length;i++){
            if(nums[i] %6 ==0){
                counter++;
                sum+=nums[i];
            }
        }
        return (sum == 0)? 0:sum/counter;
    }
}