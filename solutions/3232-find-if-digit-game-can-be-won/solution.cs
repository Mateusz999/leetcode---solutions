public class Solution {
    public bool CanAliceWin(int[] nums) {
        int sumSingle = 0, sumDouble = 0;

        foreach(int num in nums){
            if(isSingleDigit(num)){
                sumSingle += num;
            }

            else{
                sumDouble += num;
            }
        }

        return sumSingle != sumDouble;
    }

    public bool isSingleDigit(int num){
        int count = 0;

        while(num > 0){
            num /= 10;
            count++;
        }

        return count == 1;
    }
}
