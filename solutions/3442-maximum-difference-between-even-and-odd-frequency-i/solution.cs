public class Solution {
    public int MaxDifference(string s) {
        int[] result = new int[26];

        foreach(char l in s){
           result[l-'a']++;
        }
        int min = 101;
        int max = -1;

        foreach(int x in result){
            if( x != 0 && x%2 ==0 && x < min){
                min = x;
            }
            if( x != 0 && x%2 != 0 && x > max){
                max = x;
            }
        }


            return max-min;

    }
}