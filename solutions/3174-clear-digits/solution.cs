public class Solution {
    public string ClearDigits(string s) {
        string res = "";


        foreach(char l in s){
            if(char.IsDigit(l)){
                if(res.Length>0){
                    res = res.Remove(res.Length-1);
                }
            }
            else {
                res +=l;
            }
        }
        return res;
    }
}