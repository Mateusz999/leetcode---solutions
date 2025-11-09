public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(string.IsNullOrEmpty(s)) return true;
        int idx = 0;
        foreach(char letter in t){
            if(letter == s[idx]){
                idx++;
                if(idx == s.Length) return true;
            }
        }
        return false;
    }
}