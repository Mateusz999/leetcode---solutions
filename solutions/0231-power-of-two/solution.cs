public class Solution {
    public bool IsPowerOfTwo(int n) {
        for(long i = 0;i<n;i++){
            if(n == (long)Math.Pow(2,i)) return true;
            if(n < (long)Math.Pow(2,i)) return false;
        }
        return false;
    }
}