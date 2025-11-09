public class Solution {
    public int MaxFreqSum(string s) {
        Dictionary<char, int> vovels = new Dictionary<char, int>();
        Dictionary<char, int> consonants = new Dictionary<char, int>();
        string vowels = "aeiou";

        foreach (char l in s) {
            if (!char.IsLetter(l)) continue; // ignorujemy znaki nie będące literami

            char lower = char.ToLower(l);
            if (vowels.Contains(lower)) {
                if (vovels.ContainsKey(lower)) {
                    vovels[lower] += 1;
                } else {
                    vovels[lower] = 1;
                }
            } else {
                if (consonants.ContainsKey(lower)) {
                    consonants[lower] += 1;
                } else {
                    consonants[lower] = 1;
                }
            }
        }

        int maxV = vovels.Count > 0 ? vovels.Max(x => x.Value) : 0;
        int maxC = consonants.Count > 0 ? consonants.Max(x => x.Value) : 0;

        return maxV + maxC;
    }
}
