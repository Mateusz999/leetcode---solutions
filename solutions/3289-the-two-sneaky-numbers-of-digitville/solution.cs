public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] res = new int[2];
        int[] detective = new int[103];
        int counter = 0;
        foreach(int num in nums){
            detective[num]++;
            if(detective[num] ==2){
                res[counter] = num;
                counter++;
            }
        }
        return res;
    }
}