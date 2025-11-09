public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,string> rules = new Dictionary<char,string>();
        string[] sentance = s.Split(' ');
        
        if(pattern.Length != sentance.Length){
            return false;
        }
        for(int i = 0 ;i<pattern.Length;i++){
            if(rules.ContainsKey(pattern[i]) ){
                if(rules[pattern[i]] != sentance[i])return false;
            } 
            else{
                if(rules.ContainsValue(sentance[i])) return false;
                rules[pattern[i]] = sentance[i];
            }
        }
        return true;
    }
}