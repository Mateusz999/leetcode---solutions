public class Solution {
    public string RemoveOuterParentheses(string s) {
        StringBuilder result = new  StringBuilder();
        int depth = 0;

        foreach(char c in s){
            if(c == '('){
                if(depth > 0)
                    result.Append(c);
                    depth++;
                } else{
                    depth--;
                    if(depth > 0) result.Append(c);
            }
        }

   return result.ToString();

    }
}
