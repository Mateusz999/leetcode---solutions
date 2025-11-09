public class Solution {
    public string ReversePrefix(string word, char ch) {
        int charIdx = word.IndexOf(ch);
        if(charIdx == -1) return word;
        string firstPart = word.Substring(0,charIdx+1);
        char[] firtReverse = firstPart.ToCharArray();
        Array.Reverse(firtReverse);
        string reversed = new string(firtReverse);

         string suffix = word.Substring(charIdx + 1);

            return reversed + suffix;
    }
}