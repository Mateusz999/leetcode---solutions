public class Solution {
    public int CountLargestGroup(int n) {
        int[] arr = new int[37];
        int maxCount = 0;
        for(int i =0;i<n;i++){
            int res = digitSum(i+1);
           
                arr[res]+=1;
            if(arr[res] > maxCount) maxCount = arr[res];
                
            
        }
         return  arr.Count(p => p == maxCount);


    }

    public int digitSum(int num){
        int digSum = 0;

        while(num > 0){
            digSum+=num%10;
            num/=10;
        }
        return digSum;
    }
}