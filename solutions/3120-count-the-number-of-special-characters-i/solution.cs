public class Solution {
    public int NumberOfSpecialChars(string word) {
        int counter = 0;
        Dictionary<char,int> dict = new Dictionary < char, int> ();
        foreach(char letter in word){
            if(dict.ContainsKey(letter)) dict[letter]+=1;
            else dict[letter] = 1;
        }
         foreach(char letter in dict.Keys){
            if(dict.ContainsKey(Char.ToUpper(letter)) && dict.ContainsKey(Char.ToLower(letter))) counter++;
            
        }

       
        return counter/2;
    }
}