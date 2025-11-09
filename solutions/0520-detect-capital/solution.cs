public class Solution {
    public bool DetectCapitalUse(string word) {
        if(allUpper(word) || allLower(word) || camelCase(word)) return true;

        return false;
    }

    public bool allUpper(string word){
        foreach(char letter in word){
            if(Char.IsLower(letter)) return false;
        }
            return true;

    }

     public bool allLower(string word){
        foreach(char letter in word){
            if(Char.IsUpper(letter)) return false;
        }
            return true;

    }

    public bool camelCase(string word){
            if(!char.IsUpper(word[0])) return false;

        for(int j = 1;j<word.Length;j++){
            if( !char.IsLower(word[j])) return false;

        }

        return true;
    }
}