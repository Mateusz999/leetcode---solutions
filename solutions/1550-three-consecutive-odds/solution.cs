public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        for(int i = 2;i<arr.Length;i++){
            if(arr[i-2] % 2 != 0 &&
               arr[i-1] % 2 != 0 &&
               arr[i] % 2 != 0
            ) return true;
        }

        return false;
    }
}