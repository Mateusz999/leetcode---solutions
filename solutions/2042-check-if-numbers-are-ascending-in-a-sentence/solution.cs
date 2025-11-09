public class Solution {
    public bool AreNumbersAscending(string s) {

    int prev = -1;
        foreach (string word in s.Split(' ')) {
            if (int.TryParse(word, out int num)) {
                if (num <= prev) return false;
                prev = num;
            }
        }
        return true;
    }
}