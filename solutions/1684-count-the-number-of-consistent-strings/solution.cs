public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int count = 0;
        foreach(string word in words){
            bool match = true;
           foreach(char letter in word){
            if(!allowed.Contains(letter)){
                match = false;
                break;
            }
           } 
           if(match == true) count++;
        }
        return count;
    }
}