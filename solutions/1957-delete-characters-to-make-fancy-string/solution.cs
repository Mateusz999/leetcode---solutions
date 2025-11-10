public class Solution {
    public string MakeFancyString(string s) {
        if(s.Length < 3) return s;

        char[] chars = s.ToCharArray();

        int j = 2;

        for( int i = 2;i<chars.Length;i++){
            if(chars[i] != chars[j-1] || chars[i] != chars[j-2]) chars[j++] = chars[i];
        }

        return new string(chars,0,j);
    }
}