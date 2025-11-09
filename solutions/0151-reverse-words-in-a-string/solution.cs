public class Solution {
    public string ReverseWords(string s) {
        string result ="";
        s = s.Trim(' ');
        string[] tablica = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        Array.Reverse(tablica);
        for(int i = 0;i<tablica.Length;i++){
             result += tablica[i];
            if(i < tablica.Length -1) result+=" ";
        }
        return result;
    }
}