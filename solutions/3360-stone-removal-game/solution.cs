public class Solution {
    public bool CanAliceWin(int n) {
        int res = 10;
       

       while(n>= res){
        n-=res;
        res--;
       }
      return res % 2 != 0;
    }
}