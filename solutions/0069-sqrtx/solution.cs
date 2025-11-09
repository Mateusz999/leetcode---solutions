public class Solution {
    public int MySqrt(int x) {
        int i = 1;
        if(x == 0) return 0;
        while(x/i >= i){
            i++;
        }
        return i-1;
        }
    }
