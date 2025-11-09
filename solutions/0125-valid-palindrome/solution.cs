public class Solution {
    public bool IsPalindrome(string s) {
        // Przekształć wszystkie znaki na małe litery i usuń wszystkie znaki, które nie są literami lub cyframi
        s = new string(s.Where(c => Char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c)).ToArray());

        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}