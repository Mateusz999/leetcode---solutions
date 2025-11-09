public class Solution {
    public int MostWordsFound(string[] sentences) {
        int mostWords = 0;

        foreach(string sentence in sentences){
            string[] sen = sentence.Split(' ');
            if(sen.Length > mostWords) mostWords = sen.Length;
        }

        return mostWords;
    }
}