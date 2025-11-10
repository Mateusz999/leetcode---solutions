public class Solution {
    public string DecodeMessage(string key, string message) {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string decoded = "";
        var lista = new List<char>();
        
        string keyTrim =  key.Replace(" ", "");

        foreach(char l in keyTrim){
            if(l != ' '){
                if(!lista.Contains(l)) lista.Add(l);
            }
        }
        foreach(char l in message){
            if(l != ' '){
                int indexKey = lista.IndexOf(l);
                decoded += alphabet[indexKey];
            }else {
                decoded += ' ';
            }

        }
        
        return decoded;
    }
}