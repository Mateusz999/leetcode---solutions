public class Solution {
    public int FindPermutationDifference(string s, string t) {
        int diff = 0;
        foreach(char l in s){
            diff += Math.Abs(s.IndexOf(l) - t.IndexOf(l));
        }
        return diff;
    }
}