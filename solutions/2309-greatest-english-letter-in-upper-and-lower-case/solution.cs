public class Solution {
    public string GreatestLetter(string s) {
        
        char greatest = ' ';
        Dictionary<char,int> dict = new Dictionary < char, int> ();
        foreach(char letter in s){
            if(dict.ContainsKey(letter)) dict[letter]+=1;
            else dict[letter] = 1;
        }
         foreach(char letter in dict.Keys){
            if(dict.ContainsKey(Char.ToUpper(letter)) && dict.ContainsKey(Char.ToLower(letter))) {
                if(letter > greatest) greatest = letter;
            }
            
        }

       
            return (greatest == ' ')? "":Convert.ToString(Char.ToUpper(greatest));
        



    }
}