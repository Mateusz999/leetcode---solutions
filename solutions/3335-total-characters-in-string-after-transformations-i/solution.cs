public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        const int MOD = 1000000007;
        int[] count = new int[26];
        
        // Zlicz wystąpienia liter w początkowym łańcuchu
        foreach (char c in s) {
            count[c - 'a']++;
        }
        
        // Wykonaj t transformacji
        for (int i = 0; i < t; i++) {
            int[] newCount = new int[26];
            
            // Przekształć każdą literę
            for (int j = 0; j < 25; j++) {
                newCount[j + 1] = count[j];
            }
            newCount[0] = (newCount[0] + count[25]) % MOD;
            newCount[1] = (newCount[1] + count[25]) % MOD;
            
            count = newCount;
        }
        
        // Oblicz sumę długości łańcucha po t transformacjach
        long result = 0;
        foreach (int c in count) {
            result = (result + c) % MOD;
        }
        
        return (int)result;
    }
}
