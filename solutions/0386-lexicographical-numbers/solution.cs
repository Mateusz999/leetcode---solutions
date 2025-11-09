public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<string> stringLexicalOrder = new List<string>();
        List<int> result = new List<int>();

        for(int i = 1; i<=n;i++){
            stringLexicalOrder.Add(i.ToString());
        }

        stringLexicalOrder.Sort();
        
        foreach(string element in stringLexicalOrder){
            result.Add(Convert.ToInt32(element));
        }

        return result;
    }
}