public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        IList<string> res = new List<string>();
        int last = -1;
        for(int i = 0; i < words.Length;i++) {
            if(groups[i] != last){
                res.Add(words[i]);
                last = groups[i];
            }
        }
        return res;
    }
}