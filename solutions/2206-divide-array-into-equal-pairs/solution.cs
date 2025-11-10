public class Solution {
    public bool DivideArray(int[] nums) {
        int counter = 0;
        int[] res = new int[501];
        foreach(int digit in nums){
            res[digit]++;
        }

        foreach(int el in res){
            if(el % 2 == 1) return false;
        }
        return true;
    }
}