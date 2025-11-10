public class Solution {
    public int BalancedStringSplit(string s) {
        int counter = 0;
        int right=0,left=0;

        foreach(char sign in s ){
            if(sign == 'L') left++;
            else right++;
            if(left == right) counter++;
        }
        
        return counter;
    }
}