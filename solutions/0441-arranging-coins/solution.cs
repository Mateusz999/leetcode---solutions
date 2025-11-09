public class Solution {
    public int ArrangeCoins(int n) {
        int indx = 1;
        int id = 0;
        if(n == 1 )return 1;
        while(n >= 0){
            n-=indx;
            indx++;
            id++;
        }
        if(n != 1 ) return id-1;
        return id;
    }
}