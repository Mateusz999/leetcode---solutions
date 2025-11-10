public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>(); // inicjalizujemy stos

        foreach( char c in s){
            if(c=='*'){
                if(stack.Count > 0) stack.Pop(); // jesli * jest znakiem to usuwamy ze stosu szczyt czyli ostatnio dodany znak
            }else{
                stack.Push(c);
            }
        }
        return new string(stack.Reverse().ToArray());
        
    }
}