public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] data = s.Split(' ');
        string result = string.Join(' ',data,0,k);
    return result;

    }

}