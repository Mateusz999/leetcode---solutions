public class Solution {
    public int SmallestIndex(int[] nums) {
        for(int i = 0; i < nums.Length;i++){
            string digit = nums[i].ToString();
                    int sum = 0;
            foreach(char dig in digit){
                sum+= dig - '0';
            }
            if(sum == i) return i;
        }
        
        return -1;
    }
}