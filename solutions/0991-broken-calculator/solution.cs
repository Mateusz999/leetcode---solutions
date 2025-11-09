public class Solution {
    public int BrokenCalc(int startValue, int target) {
        int cnt = 0;
        while(startValue < target){
            if(target % 2 == 0) target/=2;
            else target++;
            cnt++;
        }
         return cnt+(startValue - target) ;
    }
}