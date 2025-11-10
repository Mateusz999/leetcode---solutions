public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int prefLen = pref.Length;
        int res = 0;

        foreach(var word in words){
            if(word.Length>=prefLen && word.Substring(0,prefLen) == pref) res++;
        }

        return res;
    }
}