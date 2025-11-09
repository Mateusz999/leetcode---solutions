public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int size = nums.Length;
        int halfSize = size/2;
        int[] shuffled = new int[nums.Length];
        int index =0;
        int indexI = 0;
        int indexJ =0;
        while(index < nums.Length){
            if(index % 2 == 0){
                shuffled[index] = nums[indexI];
                indexI++;

            }else {
                shuffled[index] = nums[halfSize + (indexJ)];
                indexJ++;
            }
                index++;

        }
        return shuffled;
    }
}