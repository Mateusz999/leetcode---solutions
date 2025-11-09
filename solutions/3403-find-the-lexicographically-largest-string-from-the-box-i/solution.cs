public class Solution {
    public string AnswerString(string word, int numFriends) {
        string res = "";
        if(numFriends == 1) return word;
    
        string c = "";
        string result = "";
        for(int i = 0;i<word.Length;i++){
        int seqSize = word.Length - numFriends;
         if(i+seqSize > word.Length -1 ) seqSize = word.Length - i -1;
            c = word.Substring(i,seqSize+1);
            if(String.Compare(c,result) > 0) result = c;
        }
        return result;
    }
}