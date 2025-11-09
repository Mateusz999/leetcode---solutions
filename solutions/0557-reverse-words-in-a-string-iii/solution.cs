public class Solution {
    public string ReverseWords(string s) {
        string[] res = s.Split(' ');
        List<string> result = new List<string>();
        foreach(string word in res ){
                char[] charArray = word.ToCharArray();
                
                Array.Reverse(charArray);
                result.Add(new string(charArray));
        }
        return string.Join(' ',result.ToArray());
    }
}