public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        Dictionary<char,char> mapa = new Dictionary<char,char>();
        mapa.Add(')','(');
        mapa.Add('}','{');
        mapa.Add(']','[');
        
        foreach(char c in s){
            if(mapa.ContainsKey(c)){
                if(stack.Count == 0 || stack.Peek() != mapa[c]) return false;
                stack.Pop();
            }else{
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}