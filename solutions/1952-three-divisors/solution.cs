public class Solution {
    public bool IsThree(int n) {
        int counter = 0;
        for(int i =1;i<=n;i++){
            if(n%i == 0) counter++;
        }

        return (counter == 3)? true:false; 
    }
}