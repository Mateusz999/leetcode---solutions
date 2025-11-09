public class Solution {
    public int ReverseDegree(string s) {
        // 97 - 122 a-z
        // 1-26
        // 
        int result =0;
        for(int i =0;i<s.Length;i++){
            int asciLetter = (int)s[i];

            result+= (Math.Abs(asciLetter-123))*(i+1);
        }
        return result;
    }
}