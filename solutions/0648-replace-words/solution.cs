public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        string[] words = sentence.Split(' ');
        string result = "";
       foreach(string dic in dictionary){
        for(int i = 0;i<words.Length;i++){
            if(words[i].StartsWith(dic)){
                words[i] = dic;
            }
        }
       }
        string res = string.Join(" ", words);
        return res;
       }
}