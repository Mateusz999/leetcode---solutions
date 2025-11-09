public class Solution {
    public string SortSentence(string s) {
        string[] wordArray =  s.Split(' ');
        string[] res = new string[wordArray.Length];
        for(int i = 0;i<res.Length;i++){
            res[i] = " ";
        }
        foreach(string w in wordArray){
            int index = w[w.Length-1]-'0';
            Console.WriteLine(index);
            res[index-1] = w.Substring(0,w.Length-1);
        }

        return string.Join(' ',res);
    }
}