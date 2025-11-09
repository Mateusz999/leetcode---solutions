public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int sumSubarray = 0;
        int prmSum = 0;

        for(int k = 0 ;k<arr.Length;k++){
            prmSum+=arr[k];
        }
        for(int i = 0 ;i<arr.Length;i++){
            for(int j = i+1;j<arr.Length;j++){
                if(((j-i+1))% 2 == 0) continue;
                for(int k=i;k<=j;k++){
                    sumSubarray+=arr[k];
                }
            }
        }

        return sumSubarray+prmSum;
    }
}