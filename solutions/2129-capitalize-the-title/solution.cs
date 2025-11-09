public class Solution {
    public string CapitalizeTitle(string title) {
        if (title.Length < 3) return title.ToLower();

        string[] words = title.Split(' ');
        List<string> formattedWords = new List<string>();

        foreach (string word in words) {
            if (word.Length > 2) {
                string capitalized = Char.ToUpper(word[0]) + word.Substring(1).ToLower();
                formattedWords.Add(capitalized);
            } else {
                formattedWords.Add(word.ToLower());
            }
        }

        return string.Join(" ", formattedWords);
    }
}
