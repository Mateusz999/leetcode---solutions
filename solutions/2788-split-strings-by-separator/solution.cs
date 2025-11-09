public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        IList<string> res = new List<string>();


        foreach(string word in words){
            string[] temp = word.Split(new char[] { separator }, StringSplitOptions.None);
            foreach(string t in temp){
                if (t.Length > 0)res.Add(t);
            }
        }
        return res;
    }
}