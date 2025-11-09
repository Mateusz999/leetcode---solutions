public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num < 1) return false;
        /*
            zaczynamy od pełnego przedzialy
            jesli wartosc okazuje sie kwaratem zwracamy true;
            jesli nie za mala to przechodzimy od mid+1;right
            jesli za duza to przechodzimy do left;mid-1
        */
        long left = 1, right = num;
        while(left<=right){
            long middle = left + (right - left)/2;
            long sq = middle*middle;
            if(sq == num) return true;
            else if(sq < num) left = middle+1;
            else right = middle-1;
        }
        return false;
    }
}