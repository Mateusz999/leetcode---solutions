public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        IList<int> result = new List <int>();

        for(int i = 0;i< words.Length;i++){
            if(words[i].Contains(x))result.Add(i);
        }

        return result;
    }
}