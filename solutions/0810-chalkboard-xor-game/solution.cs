public class Solution {
    public bool XorGame(int[] nums) {
        int xor = 0;

        foreach(int num in nums){
            xor^=num;
        }

        return (xor == 0) || nums.Length % 2 == 0;
    }
}