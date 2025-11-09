public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string word in words){
            if(isPalindrom(word)) return word;
            }
        
        return "";
    }

    public bool isPalindrom(string word){
        for(int i = 0; i<word.Length/2;i++){
            if(word[i] != word[word.Length -1- i]) return false;
        }
        return true;
    }
}