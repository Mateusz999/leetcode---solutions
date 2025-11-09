public class Solution {
    public int ClimbStairs(int n) {
     if(n == 1) return 1;
     if(n == 2) return 2;
    int prev = 1;
    int cur = 2;
    for(int i =2;i<n;i++){
        int temp = prev;
        prev = cur;
        cur = temp + prev;
    }
    return cur;
    }
}