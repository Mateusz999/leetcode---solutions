public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
       string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        HashSet<string> res = new HashSet<string>();
        foreach(string word in words){
            string convertedWord = "";
            foreach(char letter in word){
                int idx = letter-'a';
                convertedWord+=morse[idx];
            }
            res.Add(convertedWord);
        }

        return res.Count;

    }
}