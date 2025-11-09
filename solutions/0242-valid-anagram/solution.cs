public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        int[] charCounts = new int[26];
        
        foreach (char c in s) charCounts[c - 'a']++;
        foreach (char c in t) {
            charCounts[c - 'a']--;
            if (charCounts[c - 'a'] < 0) return false;
        }
        
        return true;
    }
}