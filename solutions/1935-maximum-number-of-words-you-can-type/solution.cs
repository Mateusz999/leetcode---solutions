public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int count=0;
        var hs = new HashSet<char>();
        foreach(char b in brokenLetters){
            hs.Add(b);
        }

        string[] words = text.Split(" ");
        foreach(string s in words){
            if(containsNoBroken(s,hs)) count++;
        }

        return count;
        
    }
    bool containsNoBroken(string s, HashSet<char> hs){
        foreach(char c in s){
            if(hs.Contains(c)) return false;
        }
        return true;
    }
}