public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return ArrayToString(word1) == ArrayToString(word2);
    }

    private string ArrayToString(string[] words)
    {
        StringBuilder word = new();
        foreach(string s in words)
            word.Append(s);
        return word.ToString();
    }
}